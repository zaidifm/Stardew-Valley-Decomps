#!/usr/bin/env python3
"""Resolve a Mono object-vtable byte offset to a managed MethodDef candidate.

This helper models the non-interface newslot assignment used by the Mono runtime
embedded in the Stardew Valley iOS 1.6.15.1 target.  Mono first reserves the
parent/interface portion of the class vtable, then gathers virtual methods and
builds the work list with g_slist_prepend, so newly assigned non-final newslot
methods are consumed in reverse metadata order.

The caller supplies first_non_interface_slot because computing inherited and
packed-interface offsets for an arbitrary type requires cross-assembly type
resolution.  For StardewValley.GameLocation in this target it is 14:
4 System.Object slots + 10 packed interface method slots.
"""

from __future__ import annotations

import argparse
import csv
from pathlib import Path


def int_auto(value: str) -> int:
    return int(value, 0)


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("methods_tsv", type=Path)
    parser.add_argument("declaring_type")
    parser.add_argument("byte_offset", type=int_auto)
    parser.add_argument("--first-non-interface-slot", type=int, required=True)
    parser.add_argument("--mono-vtable-header-size", type=int_auto, default=0x50)
    parser.add_argument("--pointer-size", type=int, default=8)
    parser.add_argument("--nearby", type=int, default=3)
    args = parser.parse_args()

    delta = args.byte_offset - args.mono_vtable_header_size
    if delta < 0 or delta % args.pointer_size:
        raise SystemExit(
            f"offset 0x{args.byte_offset:x} is not a vtable entry for "
            f"header=0x{args.mono_vtable_header_size:x}, pointer={args.pointer_size}"
        )

    physical_slot = delta // args.pointer_size
    class_index = physical_slot - args.first_non_interface_slot
    if class_index < 0:
        raise SystemExit(
            f"physical slot {physical_slot} is in the parent/interface prefix; "
            "this helper resolves newly assigned class slots only"
        )

    methods: list[dict[str, str]] = []
    with args.methods_tsv.open(newline="", encoding="utf-8") as handle:
        for row in csv.DictReader(handle, delimiter="\t"):
            if row["declaring_type"] != args.declaring_type:
                continue
            attrs = row["attributes"]
            if "Virtual" not in attrs:
                continue
            if "VtableLayoutMask" not in attrs:  # metadata NEW_SLOT bit
                continue
            if "Final" in attrs:  # interface implementation keeps interface slot
                continue
            methods.append(row)

    # mono_class_setup_vtable_general gathers metadata-order virtual methods with
    # g_slist_prepend, then assigns unclaimed non-interface slots by walking that
    # reversed list.
    assigned = list(reversed(methods))
    if class_index >= len(assigned):
        raise SystemExit(
            f"class slot index {class_index} exceeds {len(assigned)} assignable methods"
        )

    row = assigned[class_index]
    print(f"declaring_type: {args.declaring_type}")
    print(f"byte_offset: 0x{args.byte_offset:x}")
    print(f"MonoVTable.vtable[] header offset: 0x{args.mono_vtable_header_size:x}")
    print(f"physical_slot: {physical_slot}")
    print(f"first_non_interface_slot: {args.first_non_interface_slot}")
    print(f"class_assignment_index: {class_index}")
    print(f"token: {row['token']}")
    print(f"method: {row['method']}")
    print(f"attributes: {row['attributes']}")

    lo = max(0, class_index - args.nearby)
    hi = min(len(assigned), class_index + args.nearby + 1)
    print("nearby assigned slots:")
    for i in range(lo, hi):
        candidate = assigned[i]
        marker = "*" if i == class_index else " "
        slot = args.first_non_interface_slot + i
        offset = args.mono_vtable_header_size + slot * args.pointer_size
        print(
            f"{marker} slot={slot:3d} offset=0x{offset:03x} "
            f"{candidate['token']} {candidate['method']}"
        )
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
