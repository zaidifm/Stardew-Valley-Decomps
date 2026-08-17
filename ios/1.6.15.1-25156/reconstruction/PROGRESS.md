# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

Compact resume marker. Detailed evidence lives in base `methods.tsv`, append-only `ledger/*.tsv`, and `notes/`.

## Current checkpoint

Native-verified reconstructed methods: **94**.

- `AStarPath`: 8 emitted; `ToString` remains string-blocked.
- `AStarNode`: 52 emitted.
- `AStarGraph`: 34 emitted out of 35 managed methods; only private `DiagonalWalkDirection` remains unreconstructed.

## Search/path work completed after checkpoint 88

### Pass 21: path shaping

Source `3ec8c26868acb7071ed1413c2d07838e6c650c11`.

- `RetracePath`: follow `parentNode` end-to-start, exclude start, reverse nodes.
- `SmoothRightAngles`: record `i+1` when `DiagonalWalkDirection(path,i)` is non-None, clone node list, remove recorded indices descending, reassign list.

### Pass 22: core A*

Source `b0cbebe8efc5489edc6735ade0e9faf7bcdf2ed3`.

Open List + closed HashSet; lowest `fCost`, hCost tie-break; cardinal TileClear neighbours; gCost+1 relaxation; squared-Euclidean hCost; parent update; blocking-bed avoidance in DecoratableLocation unless bed is target; `RetracePath` on success.

Important shipped quirk: native A* reads `fCost` for ranking but does **not write fCost** during relaxation. Reconstruction preserves that behavior.

### Pass 23: Dijkstra

Source `cfca0085cddc038778a39bc0da7060fe5fa18cf0`.

- null start/end throws target `System.ArgumentNullException` (corelib token `0x0200006A`).
- compiler-generated lambda signature is `float(AStarNode)` and captures `Dictionary<AStarNode,float> distances`, proving `OrderBy(node => distances[node]).ToList()`.
- initializes all `_nodes` distances to `float.MaxValue`, start to zero.
- relaxes passable cardinal neighbours with inlined squared coordinate edge distance.
- path reconstruction through previous dictionary includes **both start and end**.
- normal/unreachable return calls `path.Bake()`; `start == end` returns single-node path without Bake.

### Pass 24: diagonal-target wrapper

Source `106ea0a4bc5d06b22876654a1705b464449c5d95`.

`GetShortestPathToNeighbouringDiagonalAStarWithBubbleCheck` first tries normal bubble-checked A*. On fake-clear target failure it tests end's NW/NE/SW/SE diagonal neighbours by true Euclidean distance from start. NW/NE/SW require strict unique minimum + TileClear; if none wins, SE is accepted if TileClear with no final distance comparison. This unusual tie/fallback behavior is preserved.

## New AStarNode method

### Pass 25: `isBed`

Source `4032d4774185c85add1ebe34bc4b88246d039c33`.

FarmHouse-only. Uses mapped `Utility.getHomeOfFarmer(Game1.player)`, `FarmHouse.GetBed(BedType.Any,0)`, virtual `BedFurniture.GetBedSpot()`, fallback `(-1000,-1000)`, then compares node `x/y` against `bedSpot.X/Y * 64`. The apparent tile-vs-pixel mismatch is present in ARM64 and intentionally preserved.

## AStarGraph remaining blocker

Only `DiagonalWalkDirection(AStarPath,int)` remains. Its high-level Ghidra decompile crashed; native body spans about 11,156 bytes (`0x101fa3e1c..0x101fa69b0`). Raw ARM64 is persisted locally for dedicated reduction. `SmoothRightAngles` is already reconstructed as an orchestration method around this child.

## AStarNode remaining frontiers

Strong blockers/targets include:

- `ContainsParrotExpress`
- `BrokenFestivalTile`
- `ContainsCinema`
- `ObjectParentSheetIndexOnTile` / debug version
- `IsBuildingPassable`
- `ContainsSomeKindOfWarp`
- `ContainsStumpOrBoulder`
- `ContainsBuilding` fallback branch
- debug/logging methods
- `AStarNode.ToString`

Several are blocked primarily by exact AOT-managed string/property-name recovery.

## AOT string recovery

Private workspace contains extracted `StardewValley.dll` and `StardewValley.aotdata.arm64`. Official Mono runtime source confirms LDSTR patch records encode image index + user-string token offset. Regular separate-data GOT decoding is understood; Apple LLVM AOT constants referenced from later BSS globals still need mapping back to LLVM patch-info/string tokens.

Solving this should unlock multiple remaining node methods and both AStar ToString methods.

## Canonical correction

Mono class/supertype tests used by these native methods are subclass-friendly C# `is`, not exact `GetType()` equality. `ContainsTravellingCart` is `is Forest`; `ContainsTravellingDesertShop` is `is Desert` and therefore includes `DesertFestival`. Older base-ledger prose saying exact type is superseded until next consolidation.

## Validation / discipline

Every emitted pass through method 94 has been compile-checked with .NET SDK `10.0.400` against minimal signature-compatible stubs. Current semantic units have zero compile errors.

Do not guess AOT strings, collapse observable quirks, or add convenience helpers absent from managed metadata when shipped structure is known. iOS native evidence is implementation authority; Linux current source is a semantic naming/reference oracle.
