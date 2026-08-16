#!/usr/bin/env python3
import argparse,csv,struct
from pathlib import Path

LC_SEGMENT_64=0x19

def segments(macho: bytes):
    magic=struct.unpack_from('<I',macho,0)[0]
    if magic!=0xfeedfacf: raise ValueError(f'expected little-endian Mach-O64, magic={magic:#x}')
    ncmds=struct.unpack_from('<I',macho,16)[0]
    off=32; segs=[]
    for _ in range(ncmds):
        cmd,cmdsize=struct.unpack_from('<II',macho,off)
        if cmd==LC_SEGMENT_64:
            segname=macho[off+8:off+24].split(b'\0',1)[0].decode('ascii','replace')
            vmaddr,vmsize,fileoff,filesize=struct.unpack_from('<QQQQ',macho,off+24)
            segs.append((segname,vmaddr,vmsize,fileoff,filesize))
        off += cmdsize
    return segs

def vm_to_file(addr,segs):
    for _,vm,vmsz,fo,fsz in segs:
        if vm <= addr < vm+fsz:
            return fo+(addr-vm)
    return None

def cstr(macho,addr,segs,maxlen=1024):
    off=vm_to_file(addr,segs)
    if off is None: return None
    end=macho.find(b'\0',off,min(len(macho),off+maxlen))
    if end<0: end=min(len(macho),off+maxlen)
    try: return macho[off:end].decode('utf-8')
    except: return macho[off:end].decode('latin1','replace')

PTR_NAMES=['jit_got','mono_eh_frame','llvm_get_method','llvm_get_unbox_tramp','llvm_init_aotconst','jit_code_start','jit_code_end','method_addresses','llvm_unbox_tramp_indexes','llvm_unbox_trampolines','blob','class_name_table','class_info_offsets','method_info_offsets','ex_info_offsets','extra_method_info_offsets','extra_method_table','got_info_offsets','llvm_got_info_offsets','image_table','weak_field_indexes','method_flags_table','mem_end','assembly_guid','runtime_version','specific_trampolines','static_rgctx_trampolines','imt_trampolines','gsharedvt_arg_trampolines','ftnptr_arg_trampolines','unbox_arbitrary_trampolines','globals','assembly_name','plt','plt_end','unwind_info','unbox_trampolines','unbox_trampolines_end','unbox_trampoline_addresses']
SCALAR_NAMES=['plt_got_offset_base','plt_got_info_offset_base','got_size','llvm_got_size','plt_size','nmethods','nextra_methods','flags','opts','simd_opts','gc_name_index','num_rgctx_fetch_trampolines','double_align','long_align','generic_tramp_num','card_table_shift_bits','card_table_mask','tramp_page_size','call_table_entry_size','nshared_got_entries','datafile_size','llvm_unbox_tramp_num','llvm_unbox_tramp_elemsize','n_exported_methods','exported_methods']
TABLE_NAMES=['BLOB','CLASS_NAME','CLASS_INFO_OFFSETS','METHOD_INFO_OFFSETS','EX_INFO_OFFSETS','EXTRA_METHOD_INFO_OFFSETS','EXTRA_METHOD_TABLE','GOT_INFO_OFFSETS','LLVM_GOT_INFO_OFFSETS','IMAGE_TABLE','WEAK_FIELD_INDEXES','METHOD_FLAGS_TABLE']

def parse_info(macho,off,segs):
    version,dummy=struct.unpack_from('<II',macho,off)
    ptr={n:struct.unpack_from('<Q',macho,off+8+i*8)[0] for i,n in enumerate(PTR_NAMES)}
    sc={n:struct.unpack_from('<I',macho,off+320+i*4)[0] for i,n in enumerate(SCALAR_NAMES)}
    tables={n:struct.unpack_from('<I',macho,off+420+i*4)[0] for i,n in enumerate(TABLE_NAMES)}
    return {'file_offset':off,'vm_address':next((vm+(off-fo) for _,vm,_,fo,fs in segs if fo<=off<fo+fs),None),'version':version,'ptr':ptr,'scalar':sc,'tables':tables,'assembly_name':cstr(macho,ptr['assembly_name'],segs),'runtime_version':cstr(macho,ptr['runtime_version'],segs),'assembly_guid':cstr(macho,ptr['assembly_guid'],segs)}

def find_infos(macho,segs,data_size,version=None):
    # datafile_size is at byte offset 400 inside MonoAotFileInfo. Search that
    # 32-bit value directly instead of walking every aligned byte in a large Mach-O.
    out=[]; needle=struct.pack('<I',data_size); pos=0; seen=set()
    while True:
        pos=macho.find(needle,pos)
        if pos<0: break
        off=pos-400; pos += 1
        if off<0 or off+600>len(macho) or off%4: continue
        v=struct.unpack_from('<I',macho,off)[0]
        if version is not None and v!=version: continue
        if version is None and not (100<=v<=300): continue
        try: info=parse_info(macho,off,segs)
        except Exception: continue
        if info['assembly_name'] and off not in seen:
            out.append(info); seen.add(off)
    return out

def decode_call(macho,segs,addr):
    off=vm_to_file(addr,segs)
    if off is None or off+4>len(macho): return None,None
    ins=struct.unpack_from('<I',macho,off)[0]
    if (ins & 0xFC000000) not in (0x14000000,0x94000000): return ins,None
    imm=ins & 0x03ffffff
    if imm & 0x02000000: imm -= 1<<26
    return ins,(addr+(imm<<2)) & 0xffffffffffffffff

def resolve_island(macho,segs,addr,limit=16):
    chain=[]; cur=addr
    for _ in range(limit):
        if cur in chain: break
        chain.append(cur)
        ins,tgt=decode_call(macho,segs,cur)
        if tgt is not None and ins is not None and (ins & 0xFC000000)==0x14000000:
            cur=tgt; continue
        break
    return cur,chain

def main():
    ap=argparse.ArgumentParser()
    ap.add_argument('--mach-o',required=True); ap.add_argument('--aotdata',required=True); ap.add_argument('--methods-tsv'); ap.add_argument('--assembly'); ap.add_argument('--version',type=int); ap.add_argument('-o','--output')
    a=ap.parse_args(); macho=Path(a.mach_o).read_bytes(); ds=Path(a.aotdata).stat().st_size; segs=segments(macho)
    infos=find_infos(macho,segs,ds,a.version)
    if a.assembly: infos=[x for x in infos if x['assembly_name']==a.assembly]
    if len(infos)!=1:
        print(f'candidates={len(infos)}');
        for x in infos: print(hex(x['file_offset']),x['version'],x['assembly_name'],x['scalar']['nmethods'])
        if not infos: raise SystemExit(2)
    info=infos[0]
    print(f"MonoAotFileInfo {info['assembly_name']}: file={info['file_offset']:#x} vm={info['vm_address']:#x} version={info['version']} nmethods={info['scalar']['nmethods']} nextra={info['scalar']['nextra_methods']} method_addresses={info['ptr']['method_addresses']:#x}")
    if not a.methods_tsv: return
    rows=list(csv.DictReader(open(a.methods_tsv),delimiter='\t')); out=[]; mt=info['ptr']['method_addresses']; es=info['scalar']['call_table_entry_size']
    for r in rows:
        idx=int(r['index']); entry=mt+idx*es; ins,tgt=decode_call(macho,segs,entry)
        if tgt is None: status='bad_call_entry'; native=''; chain=''
        elif tgt==mt: status='absent'; native=''; chain=f'{tgt:#x}'
        else:
            native_addr,ch=resolve_island(macho,segs,tgt); status='mapped'; native=f'{native_addr:#x}'; chain=','.join(f'{x:#x}' for x in ch)
        out.append({**r,'call_entry':f'{entry:#x}','call_insn':f'{ins:#010x}' if ins is not None else '', 'initial_target':f'{tgt:#x}' if tgt is not None else '', 'native_address':native,'status':status,'resolve_chain':chain})
    op=Path(a.output or (Path(a.methods_tsv).with_name('managed-native-map.tsv'))); 
    with op.open('w',newline='') as f:
        w=csv.DictWriter(f,fieldnames=out[0].keys(),delimiter='\t'); w.writeheader(); w.writerows(out)
    from collections import Counter
    print(Counter(x['status'] for x in out)); print('output',op)
if __name__=='__main__': main()
