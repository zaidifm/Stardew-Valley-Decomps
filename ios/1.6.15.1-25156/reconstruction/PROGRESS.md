# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

Compact resume marker. Detailed evidence lives in base `methods.tsv`, append-only `ledger/*.tsv`, and `notes/`.

## Current checkpoint

Native-verified reconstructed methods: **106**.

- `AStarPath`: **9/9 complete**.
- `AStarNode`: **63/64 complete**.
- `AStarGraph`: **34/35 complete**.

Only two managed methods remain across the complete AStar pilot:

1. `AStarNode.DebugIsTilePassable` (`0x06006645`, native `0x101faa698`).
2. `AStarGraph.DiagonalWalkDirection` (`0x06006614`, native `0x101fa3e1c`, ~11 KB raw ARM64 body).

## Method 106: `AStarNode.ToString`

Source commit: `6f338b4a310dc831d6ac4462ff428651a4222f82`.
Evidence note: commit `47086152cc14f1bbea6f2048dfabc6edc7f345ac`.
Ledger record: `ledger/pass-35-node-tostring.tsv`, commit `bc81cd1d1dbe421c40a8b5c9645d882400cece3a`.

Recovered semantics:

- starts with an `AStarNode -> x:<x>, y:<y>` diagnostic header;
- iterates every map layer;
- reads `layer.Tiles[x,y]`;
- null tile emits the recovered null-tile diagnostic line;
- non-null tile appends the tile's own `ToString()`;
- separately enumerates `TileIndexProperties` and direct inherited `Properties`, formatting each key/value pair with the recovered literals.

The exact same-era owned Linux `xTile.dll` decompile is used to name/verify the map/layer/tile/property APIs, while iOS AOT remains implementation authority.

## Major reusable capabilities established during the pilot

### LLVM AOT scalar/string decoder

Checked in:

`scripts/decode_llvm_aotconst.py`

The decoder mechanically resolves:

`LLVM scalar global -> llvm_init_aotconst slot -> LLVM_GOT_INFO_OFFSETS patch -> managed #US string`

A private 19,185-row LDSTR mapping is persisted in the Universal File Library. This broke the former string bottleneck and unlocked AStarPath.ToString, AStarNode map/property methods, festival/cinema/warp logic, and diagnostic formatters.

### Same-era xTile dependency oracle

The owned Linux `1.6.15.24356` `xTile.dll` was decompiled with persisted ILSpy 11.0.0.9375 and saved privately under the Linux decompilation reference-dependencies area. It is used to name/verify xTile API calls in the iOS native AOT without relying on stale public framework source.

### Mono vtable resolver

`scripts/resolve_mono_vtable_offset.py` resolves opaque Mono virtual-call offsets against the exact .NET 8.0.15 / Mono runtime used by this iOS build.

## Important reconstructed quirks preserved

- `AStarPath.Distance` is squared Euclidean distance.
- `AStarGraph.Distance` is squared Euclidean while lowercase `distance` uses `sqrt`.
- core A* ranks by `fCost` but the shipped native body does not update `fCost` during relaxation.
- Dijkstra includes start and end nodes and bakes normal/unreachable paths; the start==end case returns early without Bake.
- diagonal-target fallback uses strict minima for NW/NE/SW but accepts SE if TileClear when none of those wins.
- `isGate()` excludes solo gates while `ContainsGate()` / `FetchGate()` do not.
- `ContainsNPC` ignores a pet sleeping on the farmer bed while `FetchNPC` does not.
- Mono AOT class-test sequences here correspond to subclass-friendly C# `is`, not exact runtime-type equality.

## Immediate next actions

1. Finish `AStarNode.DebugIsTilePassable` using the now-known exact xTile APIs and recovered LLVM literals. This should complete AStarNode 64/64.
2. Reduce `AStarGraph.DiagonalWalkDirection` from the persisted raw ARM64 to complete AStarGraph 35/35.
3. At that point the AStarPath/AStarNode/AStarGraph pilot is **108/108 complete**.
4. Use the reconstruction machinery learned here to expand into `TapToMoveUtils.IsTilePassable`, then broader TapToMove / VirtualJoypad dependencies.

## Validation / discipline

Every emitted semantic unit through method 106 has been compile-checked or signature-checked against matching managed/dependency shapes. Preserve shipped quirks; do not invent helper methods, guess constants, or replace native mobile behavior with cleaner modern APIs. iOS native evidence remains implementation authority; current Linux source/dependencies are naming and semantic reference oracles.
