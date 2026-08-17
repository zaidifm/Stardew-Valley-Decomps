# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

Compact resume marker. Detailed evidence lives in base `methods.tsv`, append-only `ledger/*.tsv`, and `notes/`.

## Current checkpoint

Native-verified reconstructed methods: **107**.

- `AStarPath`: **9/9 complete**.
- `AStarNode`: **64/64 complete**.
- `AStarGraph`: **34/35 complete**.

Only **one managed method remains** across the complete AStar pilot:

`AStarGraph.DiagonalWalkDirection` (`0x06006614`, native `0x101fa3e1c`, ~11 KB raw ARM64 body).

## Method 107: `AStarNode.DebugIsTilePassable`

Source commit: `a408a6da456d2fa4d58ef4892aa6b2501bfd33d5`.
Evidence note: `notes/AStarNode-DebugIsTilePassable-pass36.md`.
Ledger: `ledger/pass-36-debug-passability.tsv`.

Canonical native address correction: `DebugIsTilePassable` maps to **`0x101fa9a74`**, not the stale `0x101faa698` value previously written in this progress file.

Recovered behavior:

- logs initial mobile `isTilePassable()` result;
- probes Back and Buildings layers with `PickTile((x<<6,y<<6), viewport.Size)`;
- handles Back `Passable`, Buildings `Passable`/`Shadow`, Back `Water`/`WaterSource` branches with exact recovered literals;
- dumps Buildings TileIndexProperties and direct Properties in the diagnostic C branch;
- compares mobile `AStarNode.isTilePassable()` with mapped `GameLocation.isTilePassable(Vector2)` (`0x060039E3`, native `0x1018d3064`);
- preserves the shipped discrepancy fallback that rechecks Back/Buildings state rather than simply returning either passability result.

Validation used .NET SDK 10.0.400 plus the **actual owned Linux 1.6.15.24356 xTile.dll and MonoGame.Framework.dll**. Result: **0 warnings, 0 errors**.

## Method 106: `AStarNode.ToString`

Source commit: `6f338b4a310dc831d6ac4462ff428651a4222f82`.
Evidence: `notes/AStarNode-ToString-pass35.md` / `ledger/pass-35-node-tostring.tsv`.

This completed the large layer/tile/property diagnostic formatter using exact LLVM-managed literals plus same-era xTile API identities.

## Major reusable capabilities established during the pilot

### LLVM AOT scalar/string decoder

`scripts/decode_llvm_aotconst.py`

Mechanically resolves:

`LLVM scalar global -> llvm_init_aotconst slot -> LLVM_GOT_INFO_OFFSETS patch -> managed #US string`

A private 19,185-row LDSTR mapping is persisted in the Universal File Library.

### Same-era xTile dependency oracle

The owned Linux `1.6.15.24356` `xTile.dll` was decompiled with ILSpy 11.0.0.9375 and persisted privately under the Linux decompilation reference-dependencies area.

### Mono vtable resolver

`scripts/resolve_mono_vtable_offset.py` resolves opaque Mono virtual-call offsets against the exact .NET 8.0.15 / Mono runtime used by this iOS build.

## Important reconstructed quirks preserved

- `AStarPath.Distance` is squared Euclidean distance.
- `AStarGraph.Distance` is squared Euclidean while lowercase `distance` uses `sqrt`.
- core A* ranks by `fCost` but the shipped native body does not update `fCost` during relaxation.
- Dijkstra includes start and end nodes and bakes normal/unreachable paths; start==end returns early without Bake.
- diagonal-target fallback uses strict minima for NW/NE/SW but accepts SE if TileClear when none of those wins.
- `isGate()` excludes solo gates while `ContainsGate()` / `FetchGate()` do not.
- `ContainsNPC` ignores a pet sleeping on the farmer bed while `FetchNPC` does not.
- Mono AOT class-test sequences here correspond to subclass-friendly C# `is`, not exact runtime-type equality.

## Immediate next action

Reduce `AStarGraph.DiagonalWalkDirection` from persisted raw ARM64. When it is verified and emitted, the AStarPath/AStarNode/AStarGraph pilot becomes **108/108 complete**.

Then use the recovered machinery and conventions to expand into `TapToMoveUtils.IsTilePassable`, broader TapToMove helpers, and VirtualJoypad.

## Validation / discipline

Every emitted semantic unit through method 107 has been compile-checked or signature-checked against matching managed/dependency shapes. Preserve shipped quirks; do not invent helper methods, guess constants, or replace native mobile behavior with cleaner modern APIs. iOS native evidence remains implementation authority; current Linux source/dependencies are naming and semantic reference oracles.
