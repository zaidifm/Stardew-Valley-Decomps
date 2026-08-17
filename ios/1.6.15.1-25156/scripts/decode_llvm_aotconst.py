#!/usr/bin/env python3
"""Decode Mono LLVM AOT scalar constants back to AOT patch metadata.

Given the Mach-O, matching separate .aotdata file, managed assembly, and the
MonoAotFileInfo VM address, this script inverts llvm_init_aotconst():

    scalar global address -> LLVM GOT slot -> patch record -> LDSTR #US literal

It can resolve selected scalar addresses or emit all LDSTR scalar mappings.
"""
from __future__ import annotations

import argparse
import csv
import struct
import sys
from pathlib import Path

MONO_AOT_FILE_VERSION = 185
MONO_AOT_TABLE_BLOB = 0
MONO_AOT_TABLE_LLVM_GOT_INFO_OFFSETS = 8
MONO_PATCH_INFO_LDSTR = 15


def int0(s: str) -> int:
    return int(s, 0)


def u32(buf: bytes, off: int) -> int:
    return struct.unpack_from('<I', buf, off)[0]


def u64(buf: bytes, off: int) -> int:
    return struct.unpack_from('<Q', buf, off)[0]


def sign_extend(v: int, bits: int) -> int:
    top = 1 << (bits - 1)
    return (v ^ top) - top


class MachO:
    def __init__(self, data: bytes):
        self.data = data
        magic = u32(data, 0)
        if magic != 0xFEEDFACF:
            raise ValueError(f'expected little-endian Mach-O 64 magic, got 0x{magic:08x}')
        ncmds = u32(data, 16)
        pos = 32
        self.segments: list[tuple[int, int, int, int, str]] = []
        for _ in range(ncmds):
            cmd, cmdsize = struct.unpack_from('<II', data, pos)
            if cmd == 0x19:  # LC_SEGMENT_64
                segname = data[pos+8:pos+24].split(b'\0', 1)[0].decode('ascii', 'replace')
                vmaddr, vmsize, fileoff, filesize = struct.unpack_from('<QQQQ', data, pos+24)
                self.segments.append((vmaddr, vmsize, fileoff, filesize, segname))
            pos += cmdsize

    def vm_to_off(self, vm: int, allow_zerofill: bool = False) -> int:
        for va, vs, fo, fs, name in self.segments:
            if va <= vm < va + vs:
                delta = vm - va
                if delta >= fs and not allow_zerofill:
                    raise ValueError(f'VM 0x{vm:x} is zero-fill in {name}, no file bytes')
                return fo + delta
        raise ValueError(f'VM address 0x{vm:x} not in Mach-O segments')

    def read32(self, vm: int) -> int:
        return u32(self.data, self.vm_to_off(vm))


def decode_adr(insn: int, pc: int) -> int | None:
    if (insn & 0x9F000000) != 0x10000000:
        return None
    immlo = (insn >> 29) & 0x3
    immhi = (insn >> 5) & 0x7FFFF
    return pc + sign_extend((immhi << 2) | immlo, 21)


def decode_adrp(insn: int, pc: int) -> int | None:
    if (insn & 0x9F000000) != 0x90000000:
        return None
    immlo = (insn >> 29) & 0x3
    immhi = (insn >> 5) & 0x7FFFF
    imm = sign_extend((immhi << 2) | immlo, 21) << 12
    return (pc & ~0xFFF) + imm


def decode_add_imm(insn: int) -> tuple[int, int, int] | None:
    if (insn & 0xFF000000) != 0x91000000:
        return None
    rd = insn & 0x1F
    rn = (insn >> 5) & 0x1F
    imm = (insn >> 10) & 0xFFF
    if (insn >> 22) & 1:
        imm <<= 12
    return rd, rn, imm


def addr_from_adrp_add(macho: MachO, pc: int, reg: int) -> int | None:
    insn = macho.read32(pc)
    page = decode_adrp(insn, pc)
    if page is None or (insn & 0x1F) != reg:
        return None
    add = decode_add_imm(macho.read32(pc + 4))
    if add is None:
        return None
    rd, rn, imm = add
    if rd != reg or rn != reg:
        return None
    return page + imm


def discover_init_switch(macho: MachO, init_vm: int) -> tuple[int, int, int]:
    """Return (jump_table_vm, target_base_vm, default_scalar_vm)."""
    table_vm = None
    target_base = None
    default_scalar = None
    for pc in range(init_vm, init_vm + 0x80, 4):
        insn = macho.read32(pc)
        if insn == 0xD61F0140:  # br x10: generated indirect dispatch
            break
        if (insn & 0x1F) == 9:
            candidate = addr_from_adrp_add(macho, pc, 9)
            if candidate is not None:
                table_vm = candidate
        if (insn & 0x1F) == 10:
            candidate = decode_adr(insn, pc)
            if candidate is not None:
                target_base = candidate
        if (insn & 0x1F) == 8:
            candidate = addr_from_adrp_add(macho, pc, 8)
            if candidate is not None:
                default_scalar = candidate
    if table_vm is None or target_base is None or default_scalar is None:
        raise ValueError(
            f'failed to discover init_aotconst switch: table={table_vm}, '
            f'target_base={target_base}, default_scalar={default_scalar}'
        )
    return table_vm, target_base, default_scalar


def scalar_for_case(macho: MachO, target: int, default_scalar: int) -> int | None:
    first = macho.read32(target)
    if first == 0xD65F03C0:  # ret
        return None
    if first == 0xF9000101:  # str x1, [x8] common store
        return default_scalar
    addr = addr_from_adrp_add(macho, target, 8)
    if addr is None:
        raise ValueError(f'unrecognized init_aotconst case at 0x{target:x}: 0x{first:08x}')
    return addr


def decode_value(buf: bytes, pos: int) -> tuple[int, int]:
    b = buf[pos]
    if (b & 0x80) == 0:
        return b, pos + 1
    if (b & 0x40) == 0:
        return ((b & 0x3F) << 8) | buf[pos + 1], pos + 2
    if b != 0xFF:
        return (((b & 0x1F) << 24) | (buf[pos+1] << 16) | (buf[pos+2] << 8) | buf[pos+3], pos + 4)
    return ((buf[pos+1] << 24) | (buf[pos+2] << 16) | (buf[pos+3] << 8) | buf[pos+4], pos + 5)


def decode_offset_table(buf: bytes, off: int, index: int) -> int:
    noffsets, group_size, ngroups, index_entry_size = struct.unpack_from('<4I', buf, off)
    if not 0 <= index < noffsets:
        raise IndexError(index)
    group = index // group_size
    if index_entry_size == 2:
        indexes = struct.unpack_from(f'<{ngroups}H', buf, off + 16)
        data_start = off + 16 + 2 * ngroups
    elif index_entry_size == 4:
        indexes = struct.unpack_from(f'<{ngroups}I', buf, off + 16)
        data_start = off + 16 + 4 * ngroups
    else:
        raise ValueError(f'unsupported offset-table index size {index_entry_size}')
    p = data_start + indexes[group]
    value, p = decode_value(buf, p)
    for _ in range(group * group_size + 1, index + 1):
        delta, p = decode_value(buf, p)
        value += delta
    return value


def pe_rva_to_off(data: bytes, rva: int) -> int:
    pe = u32(data, 0x3C)
    coff = pe + 4
    nsec = struct.unpack_from('<H', data, coff + 2)[0]
    opt_size = struct.unpack_from('<H', data, coff + 16)[0]
    sec = coff + 20 + opt_size
    for i in range(nsec):
        o = sec + i * 40
        vsize, va, raw_size, raw_ptr = struct.unpack_from('<IIII', data, o + 8)
        if va <= rva < va + max(vsize, raw_size):
            return raw_ptr + (rva - va)
    raise ValueError(f'PE RVA 0x{rva:x} not mapped')


def find_us_heap(data: bytes) -> tuple[int, int]:
    pe = u32(data, 0x3C)
    coff = pe + 4
    opt = coff + 20
    magic = struct.unpack_from('<H', data, opt)[0]
    dd = opt + (112 if magic == 0x20B else 96)
    cli_rva = u32(data, dd + 14 * 8)
    cli = pe_rva_to_off(data, cli_rva)
    metadata_rva = u32(data, cli + 8)
    md = pe_rva_to_off(data, metadata_rva)
    if data[md:md+4] != b'BSJB':
        raise ValueError('invalid CLI metadata signature')
    ver_len = u32(data, md + 12)
    p = (md + 16 + ver_len + 3) & ~3
    _, streams = struct.unpack_from('<HH', data, p)
    p += 4
    for _ in range(streams):
        stream_off, stream_size = struct.unpack_from('<II', data, p)
        p += 8
        end = data.index(0, p)
        name = data[p:end].decode('ascii')
        p = (end + 1 + 3) & ~3
        if name == '#US':
            return md + stream_off, stream_size
    raise ValueError('managed image has no #US stream')


def read_compressed_uint(buf: bytes, pos: int) -> tuple[int, int]:
    b = buf[pos]
    if (b & 0x80) == 0:
        return b, pos + 1
    if (b & 0xC0) == 0x80:
        return ((b & 0x3F) << 8) | buf[pos+1], pos + 2
    if (b & 0xE0) == 0xC0:
        return (((b & 0x1F) << 24) | (buf[pos+1] << 16) | (buf[pos+2] << 8) | buf[pos+3], pos + 4)
    raise ValueError('invalid CLI compressed uint')


def read_user_string(image: bytes, us_off: int, heap_offset: int) -> str:
    p = us_off + heap_offset
    length, p = read_compressed_uint(image, p)
    if length == 0:
        return ''
    raw = image[p:p+length]
    return raw[:-1].decode('utf-16le', errors='replace')


def main() -> int:
    ap = argparse.ArgumentParser()
    ap.add_argument('--macho', type=Path, required=True)
    ap.add_argument('--aotdata', type=Path, required=True)
    ap.add_argument('--assembly', type=Path, required=True)
    ap.add_argument('--module-info-vm', type=int0, required=True)
    ap.add_argument('--address', type=int0, action='append', default=[])
    ap.add_argument('--all-ldstr', action='store_true')
    ap.add_argument('--tsv', action='store_true')
    args = ap.parse_args()

    macho = MachO(args.macho.read_bytes())
    aot = args.aotdata.read_bytes()
    assembly = args.assembly.read_bytes()
    mi = macho.vm_to_off(args.module_info_vm)
    version = u32(macho.data, mi)
    if version != MONO_AOT_FILE_VERSION:
        raise ValueError(f'AOT version {version}, expected {MONO_AOT_FILE_VERSION}')

    llvm_init = u64(macho.data, mi + 0x28)
    table_offsets = [u32(macho.data, mi + 0x1A4 + i * 4) for i in range(12)]
    blob_off = table_offsets[MONO_AOT_TABLE_BLOB]
    llvm_info_off = table_offsets[MONO_AOT_TABLE_LLVM_GOT_INFO_OFFSETS]
    nslots = u32(aot, llvm_info_off)

    jump_table_vm, target_base, default_scalar = discover_init_switch(macho, llvm_init)
    jump_table_off = macho.vm_to_off(jump_table_vm)
    jump_offsets = struct.unpack_from(f'<{nslots}i', macho.data, jump_table_off)

    scalar_to_slot: dict[int, int] = {}
    slot_to_scalar: list[int | None] = []
    for slot, delta in enumerate(jump_offsets):
        target = target_base + delta
        scalar = scalar_for_case(macho, target, default_scalar)
        slot_to_scalar.append(scalar)
        if scalar is not None:
            if scalar in scalar_to_slot:
                raise ValueError(f'duplicate scalar address 0x{scalar:x}')
            scalar_to_slot[scalar] = slot

    us_off, _ = find_us_heap(assembly)

    def record_for(slot: int, scalar: int | None):
        blob_index = decode_offset_table(aot, llvm_info_off, slot)
        p = blob_off + blob_index
        patch_type, p = decode_value(aot, p)
        image_index = None
        string_offset = None
        literal = None
        if patch_type == MONO_PATCH_INFO_LDSTR:
            image_index, p = decode_value(aot, p)
            string_offset, p = decode_value(aot, p)
            if image_index == 0:
                literal = read_user_string(assembly, us_off, string_offset)
        return {
            'scalar_address': scalar,
            'slot': slot,
            'patch_type': patch_type,
            'image_index': image_index,
            'user_string_offset': string_offset,
            'literal': literal,
        }

    records = []
    if args.all_ldstr:
        for slot, scalar in enumerate(slot_to_scalar):
            if scalar is None:
                continue
            rec = record_for(slot, scalar)
            if rec['patch_type'] == MONO_PATCH_INFO_LDSTR:
                records.append(rec)
    else:
        if not args.address:
            ap.error('provide --address or --all-ldstr')
        for scalar in args.address:
            slot = scalar_to_slot.get(scalar)
            if slot is None:
                records.append({
                    'scalar_address': scalar, 'slot': None, 'patch_type': None,
                    'image_index': None, 'user_string_offset': None, 'literal': None,
                })
            else:
                records.append(record_for(slot, scalar))

    fields = ['scalar_address','slot','patch_type','image_index','user_string_offset','literal']
    if args.tsv:
        out = csv.DictWriter(sys.stdout, fieldnames=fields, delimiter='\t', lineterminator='\n')
        out.writeheader()
        for rec in records:
            row = dict(rec)
            row['scalar_address'] = '' if rec['scalar_address'] is None else f"0x{rec['scalar_address']:x}"
            out.writerow(row)
    else:
        for rec in records:
            addr = rec['scalar_address']
            print(f"scalar={'' if addr is None else f'0x{addr:x}'} slot={rec['slot']} "
                  f"type={rec['patch_type']} image={rec['image_index']} "
                  f"us={rec['user_string_offset']} literal={rec['literal']!r}")
    return 0


if __name__ == '__main__':
    raise SystemExit(main())
