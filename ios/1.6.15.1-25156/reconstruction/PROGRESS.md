# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

This is the compact resume marker. Detailed evidence lives in `methods.tsv`, append-only `ledger/*.tsv`, and `notes/`.

## Current checkpoint

Native-verified reconstructed methods: **79**.

- `AStarPath`: 8 emitted; `ToString` remains triaged pending exact AOT-managed string recovery.
- `AStarNode`: 51 emitted.
- `AStarGraph`: 20 emitted.

The mobile pilot remains native-first because current Linux `1.6.15.24356` has no `StardewValley.Mobile.AStar*`, `TapToMove*`, or `VirtualJoypad` implementation counterpart.

## Most recent pass: AStarGraph direction / bubble helpers

Pass 17 added 16 native-verified methods in source commit `0de7f431a06d1c1f1787c80319281451953e094d`.

Evidence: `notes/AStarGraph-direction-bubble-pass17.md` and `ledger/pass-17-astargraph-direction-bubble.tsv`.

Recovered methods:

- `Distance`
- `IsNeighbouringNode`
- `IsNeighbouringNodeNoDiagonals`
- `IsNeighbouringNodeOnDiagonal`
- `IsSameNode`
- `OppositeWalkDirection`
- `WalkDirectionToNextNode`
- `WalkDirectionBetweenNodes`
- `WalkDirectionBetweenTwoPoints`
- `WalkDirectionBetweenTwoPointsNoDiagonals`
- `WalkDirectionBetweenTwoNodes`
- `WalkDirectionBetweenTwoTiles`
- lowercase `distance`
- `GetShortestPathAStarWithBubbleCheck`
- `PathBetweenNodesExists`
- `walkingDirectionToStardewDirection`

Important distinction: `AStarGraph.Distance(int x1,int y1,int x2,int y2)` is squared Euclidean distance returned as float, while lowercase `distance(int x1,int x2,int y1,int y2)` is true Euclidean distance returned as double with `sqrt`.

`OppositeWalkDirection` is proven from the native table at `0x103333500`: Up<->Down, Left<->Right, UpLeft<->DownRight, UpRight<->DownLeft. `walkingDirectionToStardewDirection` maps Up=0, Down=2, Left=3, Right=1 and returns -1 for non-cardinal directions.

`WalkDirectionBetweenTwoTiles` preserves a non-obvious shipped behavior: identical/near-dead-zone points fall through the dominant-axis rule, and identical points return `Down`, not None.

## Previously completed AStarNode anchors

The emitted `TileClear` orchestration and its verified leaves now cover gate/fence handling, furniture, beds, travelling shops, animals, NPCs, festival/event props, chest lookup, scarecrows, resource-clump predicates, and building retrieval primitives.

Preserved quirks/distinctions include:

- lowercase `isGate()` excludes `Fence.isSoloGate`; `ContainsGate()` / `FetchGate()` do not.
- `ContainsNPC` ignores a `Pet` sleeping on the farmer bed; `FetchNPC` does not.
- `ContainsTravellingCart` and `ContainsTravellingDesertShop` use subclass-friendly `is Forest` / `is Desert` semantics. Any older prose saying these were exact `GetType()` tests is superseded.
- `AStarPath.Distance` is squared Euclidean distance, no square root.

## Reusable tooling

- `scripts/resolve_mono_vtable_offset.py`: exact .NET 8.0.15 / Mono `50c4cb9f...` ARM64 virtual-slot resolver.
- `scripts/check_reconstruction_ledger.py`: validates the logical union of base `methods.tsv` and append-only fragments.

## Active frontiers

### AStarGraph

Next low-risk graph units:

1. `ResetBubbles` and `mergeBubbleID2IntoBubbleID`, whose native bodies are bounded 2-D array traversals.
2. `FarmerAStarNode` and `FetchNeighbourNodeThatIsPassible`; `FarmerAStarNode` already resolves through `Game1.player.Position` / `NetPosition` coordinates.
3. `RefreshBubbles` after the farmer-node pair is complete.
4. Reduce `AreOppositeWalkDirection` and `WalkDirectionBetweenTwoPointsWithLastDirection` to exact truth tables/masks before emitting them.
5. Then tackle `RetracePath`, `SmoothRightAngles`, core A*, and Dijkstra as larger semantic units.

### AOT string recovery

The iOS IPA contains both `StardewValley.dll` and `StardewValley.aotdata.arm64`; both are extracted in the private workspace. Official Mono runtime source proves LDSTR patch records encode image index plus string-token offset. Regular GOT decoding is understood, but the Apple LLVM AOT string constants referenced from later BSS globals are not in the regular `jit_got` range. The next step is to map those LLVM AOT constant globals to their patch-info/string tokens. This should unlock `ContainsCinema`, `BrokenFestivalTile`, `IsBuildingPassable`, `ContainsStumpOrBoulder`, `AStarPath.ToString`, and other currently string-blocked methods.

## Validation / discipline

The latest 16-method AStarGraph batch compiles under the persisted .NET SDK `10.0.400` against minimal signature-compatible stubs with **0 warnings and 0 errors**.

Do not guess AOT strings, collapse observable distinctions, or add convenience helpers absent from managed metadata when the shipped structure is known. iOS native evidence remains implementation authority; Linux source is a naming/semantic reference oracle.
