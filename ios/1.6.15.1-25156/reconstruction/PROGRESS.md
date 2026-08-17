# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

Compact resume marker. Detailed evidence lives in base `methods.tsv`, append-only `ledger/*.tsv`, and `notes/`.

## Current checkpoint

Native-verified reconstructed methods: **100**.

- `AStarPath`: **9/9 complete**.
- `AStarNode`: **57/64 emitted**.
- `AStarGraph`: **34/35 emitted**; only private `DiagonalWalkDirection` remains.

## Major capability breakthrough: LLVM AOT scalar/string recovery

The Apple LLVM AOT string problem is solved mechanically, not by guessing literals.

Checked-in decoder:

`scripts/decode_llvm_aotconst.py`

Evidence note:

`reconstruction/notes/LLVM-AOT-LDSTR-recovery.md`

The exact embedded Mono runtime states LLVM AOT code keeps constants in separate scalar variables and populates them through generated `llvm_init_aotconst(index,value)`. For this module:

- `MonoAotFileInfo` VM: `0x1037e3b90`
- `llvm_init_aotconst`: `0x102106788`
- LLVM constant / GOT-info domain: 34,726 slots
- generated switch table: `0x10327b874`
- separate-data `LLVM_GOT_INFO_OFFSETS` has the same 34,726-entry domain

The decoder inverts:

`scalar address -> llvm_init_aotconst slot -> LLVM patch record -> LDSTR image/#US offset -> exact managed literal`

A private full scan produced **19,185 LLVM LDSTR mappings**. The full literal table and decoder are persisted in the Universal File Library under the private native-AOT mappings directory; the public repo contains the reusable decoder but not the full bulk string corpus.

Recovered literals already used include `fall`, `winter`, `ccMovieTheater`, `Buildings`, `Passable`, `t`, `true`, `Shadow`, `Boulder`, `Warp`, `WarpMensLocker`, `LockedDoorWarp`, `WarpWomensLocker`, `-1`, and the exact `AStarPath.ToString` formatting fragments.

SFLDA/static-field decoding has also started: the scalar used by `BrokenFestivalTile` decodes through Mono `decode_field_info` to `StardewValley.Game1.dayOfMonth`, proving the date field directly.

## Methods 95-100

### 95: `AStarNode.ContainsParrotExpress`

Source `a97021ee12e354dc2ce8f5ea88f77320220ee748`.

IslandLocation-only. Iterates `parrotPlatforms`, calls proven `ParrotPlatform.OccupiesTile(Vector2)`, but leaves the platform-relative cells `(1,1)` and `(1,0)` passable. Vector2 add/inequality trampolines were independently identified from recovered TapToMove helpers.

### 96: `AStarPath.ToString`

Source `18a5e2d3140ad0c25b65762cd46a8773855e5c50`.

Exact recovered behavior:
- null/empty nodes -> `No path`;
- build `[(` coordinate list with comma separators and `), ` endings;
- strip final comma-space;
- append `], Length:` plus node count.

This completes all managed methods in AStarPath.

### 97: `AStarNode.ObjectParentSheetIndexOnTile`

Source `951747df807cdfc7e2745e9cbf6cb752a45e78c1`.

Tile object lookup returns `Item.ItemId`; missing object returns exact recovered literal `-1`. Despite the historical method name, shipped iOS uses ItemId rather than numeric ParentSheetIndex.

### 98: `AStarNode.BrokenFestivalTile`

Source `e6b3109e873bc1b1ba153b6de52829cb188a1508`.

Requires CurrentEvent, then blocks exactly:
- `(18,31)` on fall 16
- `(16,19)` on fall 27
- `(66,4)` on winter 8
- `(103,28)` on winter 8

`fall`/`winter` are exact LDSTR recoveries; the static date scalar is proven `Game1.dayOfMonth` through SFLDA patch decoding to matching TypeDef/FieldDef metadata.

### 99: `AStarNode.ContainsCinema`

Source `cdae95d2b45a9c6a2d5e08c6602b70bd467ff4a5`.

Town-only and gated by exact mail flag `ccMovieTheater`. Town class identity is proven by exact class-global reuse in iOS `GameLocation.performGreenRainUpdate`, whose matching shared branch is `if (this is Town) return;`.

Cinema tile footprint:
- x 47..58, y 17..19; or
- y 20 with x 47 or x 55..58.

### 100: `AStarNode.DebugTileClear`

Source `7d80b045c0be5a65908705b7f4966b325c43ecff`.

Exact wrapper: call `DebugObjectParentSheetIndexOnTile()`, evaluate/discard `TileClear`, return. The child debug formatter remains its own unresolved method.

## Earlier completed path/search work

Core A*, Dijkstra, retracing, smoothing orchestration, bubble state, direction helpers/masks, farmer offsets, and diagonal-target wrapper are all emitted and evidence-logged.

Important native quirks preserved:
- A* reads `fCost` for ranking but does not write it during relaxation.
- Dijkstra includes start and end and bakes normal/unreachable paths; start==end returns the single-node path without Bake.
- diagonal target fallback uses strict minima for NW/NE/SW and then accepts SE if TileClear without a final distance comparison.
- uppercase `AStarGraph.Distance` is squared Euclidean; lowercase `distance` uses sqrt.

## Remaining AStarGraph method

Only:

`DiagonalWalkDirection(AStarPath,int)` token `0x06006614`, native `0x101fa3e1c`.

Its high-level Ghidra decompile crashed and the body spans ~11 KB. Raw ARM64 is persisted privately. `SmoothRightAngles` is already reconstructed around this child.

## Remaining AStarNode methods (7)

- `DebugObjectParentSheetIndexOnTile`
- `IsBuildingPassable`
- `DebugIsTilePassable`
- `ContainsSomeKindOfWarp`
- `ContainsStumpOrBoulder`
- `ContainsBuilding`
- `ToString`

The string decoder materially lowers the cost of all of these. Immediate high-value targets are `IsBuildingPassable`, warp detection, building fallback, and stump/boulder. Debug methods can follow their dependencies. `AStarNode.ToString` is large but its formerly opaque formatting strings can now be recovered exactly.

## Canonical correction

Mono class/supertype tests in this target use subclass-friendly C# `is`, not exact `GetType()` equality. `ContainsTravellingCart` is `is Forest`; `ContainsTravellingDesertShop` is `is Desert` and includes `DesertFestival`. Older base-ledger prose saying exact type is superseded until ledger consolidation.

## Validation / discipline

Every emitted semantic unit through method 100 has been compile-checked with persisted .NET SDK `10.0.400` against minimal signature-compatible stubs. Current units have zero compile errors.

Do not guess constants, collapse observable quirks, or add convenience helpers absent from managed metadata when shipped structure is known. iOS native evidence is implementation authority; Linux current source is a naming/semantic reference oracle.
