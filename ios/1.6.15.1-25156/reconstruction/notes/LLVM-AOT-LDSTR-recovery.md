# LLVM AOT scalar / LDSTR recovery

Target: Stardew Valley iOS `1.6.15.1` build `25156`, embedded .NET 8.0.15 / Mono AOT format version 185.

Checked-in tool: `../scripts/decode_llvm_aotconst.py`.

## Problem

LLVM-generated AOT code in this Apple mobile build does not read one contiguous runtime LLVM GOT from the Mach-O. The generated native methods reference many separate scalar globals in zero-fill data. Before this pass, those globals appeared in Ghidra as opaque values like `uRam00000001038e79a0`, which blocked exact recovery of property names, mail flags, seasons, item IDs, and formatting strings.

## Runtime/compiler evidence

At the exact embedded runtime source commit `50c4cb9fc31c47f03eac865d7bc518af173b74b7`:

- `MonoAotModule` has a runtime-only `llvm_got` allocation.
- `aot-runtime.c` explicitly notes that LLVM code keeps its data in **separate scalar variables**.
- resolved LLVM GOT slots are copied into generated scalar globals by `MonoAotFileInfo.llvm_init_aotconst(index,value)`.
- `aot-compiler.c` maintains a distinct `llvm_got_info` and emits `MONO_AOT_TABLE_LLVM_GOT_INFO_OFFSETS`.
- each GOT-info record begins with the patch type and its encoded patch payload.
- `MONO_PATCH_INFO_LDSTR` payloads encode an image index and managed user-string token/heap offset.

## Target-specific bridge

The StardewValley `MonoAotFileInfo` at VM `0x1037e3b90` points `llvm_init_aotconst` to `0x102106788`.

That generated function is an index switch over all LLVM AOT constants:

1. a 34,726-entry signed jump table selects the scalar-init case;
2. each case computes one scalar global address in `x8`;
3. the common tail stores the resolved runtime value to `[x8]`.

The separate-data `LLVM_GOT_INFO_OFFSETS` table also contains exactly 34,726 entries, matching the LLVM constant-index domain.

The decoder therefore mechanically inverts:

`scalar VM address -> init_aotconst switch index -> LLVM GOT-info patch -> LDSTR image/string offset -> managed #US literal`

No runtime execution, OCR, or literal guessing is involved.

## Managed string extraction

For image index zero, the tool parses the matching managed PE/CLI metadata root, locates the `#US` heap, decodes the ECMA compressed length, removes the one-byte #US terminal flag, and decodes the UTF-16 payload.

A private full scan of this StardewValley module produced 19,185 LLVM LDSTR rows. The full literal map is deliberately kept in the private workspace/Library rather than checked into the public derived repo.

## Verified examples

Selected scalar mappings used by the reconstruction:

- `0x1038ef1f8` -> `fall`
- `0x1038ef200` -> `winter`
- `0x1038e79a0` -> `ccMovieTheater`
- `0x1038cc720` -> `Buildings`
- `0x1038e0408` -> `Passable`
- `0x1038e0e88` -> `t`
- `0x1038e5138` -> `true`
- `0x1038e5238` -> `Shadow`
- `0x1038ecef0` -> `Boulder`
- `0x1038c7b38` -> `Warp`
- `0x1038e7e08` -> `WarpMensLocker`
- `0x1038e7e10` -> `LockedDoorWarp`
- `0x1038e7e18` -> `WarpWomensLocker`

Formatting/default literals newly recovered include `-1`, `No path`, `[`, `(`, `,`, `), `, and `], Length:`.

These examples were checked by independently decoding their scalar slot and patch record with the committed tool.

## CLI

Resolve selected scalar globals:

```text
python scripts/decode_llvm_aotconst.py \
  --macho StardewValley \
  --aotdata StardewValley.aotdata.arm64 \
  --assembly StardewValley.dll \
  --module-info-vm 0x1037e3b90 \
  --address 0x1038e79a0 \
  --address 0x1038ecef0
```

Emit all LLVM LDSTR mappings as TSV with `--all-ldstr --tsv`.

## Scope / portability

The script discovers the generated `llvm_init_aotconst` jump table and scalar targets from ARM64 instructions instead of hardcoding the 34,726 scalar addresses. It reads the AOT blob and LLVM GOT-info table offsets from the supplied `MonoAotFileInfo`.

The current structure offsets correspond to 64-bit Mono AOT format 185. Revalidate those structure offsets before using the tool on a materially different runtime/AOT format or ABI.
