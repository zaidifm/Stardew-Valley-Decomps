# String-unblocked reconstruction pass 27

Targets: `AStarPath.ToString` and `AStarNode.ObjectParentSheetIndexOnTile`, iOS `1.6.15.1` build `25156`.

Source commits:
- AStarPath `ToString`: `18a5e2d3140ad0c25b65762cd46a8773855e5c50`
- object ItemId tile lookup: `951747df807cdfc7e2745e9cbf6cb752a45e78c1`

These methods were previously withheld because their LLVM AOT scalar string constants were unnamed. `scripts/decode_llvm_aotconst.py` now recovers those constants mechanically from the generated `llvm_init_aotconst` switch plus `LLVM_GOT_INFO_OFFSETS` patch records.

## `AStarPath.ToString`

Token `0x06006663`, native `0x101fae714`.

Recovered scalar literals:
- `0x1039047c0` -> `No path`
- `0x1038efee0` -> `[` 
- `0x1038dfaa0` -> `(`
- `0x1038d3dd0` -> `,`
- `0x1039047c8` -> `), `
- `0x1039047d0` -> `], Length:`

Native behavior:

1. obtain `nodes`; null or zero count returns `No path`;
2. begin with `[`;
3. for each node append six concat elements: existing result, `(`, x, `,`, y, `), `;
4. remove the final two characters with `Substring(0,Length-2)`, leaving the final closing parenthesis while stripping comma-space;
5. append `], Length:` and node count.

The staged C# preserves this structure and closes the only previously unresolved method in `AStarPath`.

## `ObjectParentSheetIndexOnTile`

Token `0x06006641`, native `0x101fa951c`.

Recovered scalar literal:
- `0x1038d74f8` -> `-1`

The native dictionary helper is the already-mapped `OverlaidDictionary.TryGetValue`, using tile key `new Vector2(x,y)`. If an object exists, the mapped managed call is `Item.get_ItemId`; otherwise the method returns the recovered `-1` literal.

Despite the historical method name mentioning ParentSheetIndex, the shipped iOS implementation returns the string `ItemId`.

## Validation

Both staged methods compile under the persisted .NET SDK `10.0.400` in a combined minimal harness with **0 warnings, 0 errors**.
