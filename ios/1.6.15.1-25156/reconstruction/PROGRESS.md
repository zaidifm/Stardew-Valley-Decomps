# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

This is the compact resume marker. Detailed evidence lives in `methods.tsv`, append-only `ledger/*.tsv`, and `notes/`.

## Current checkpoint

Native-verified reconstructed methods: **88**.

- `AStarPath`: 8 emitted; `ToString` remains triaged pending exact AOT-managed string recovery.
- `AStarNode`: 51 emitted.
- `AStarGraph`: 29 emitted.

The mobile pilot remains native-first because current Linux `1.6.15.24356` has no `StardewValley.Mobile.AStar*`, `TapToMove*`, or `VirtualJoypad` implementation counterpart.

## Recent AStarGraph passes

### Pass 17: direction / bubble helpers

Source `0de7f431a06d1c1f1787c80319281451953e094d`, 16 methods.

Includes adjacency/equality, cardinal/diagonal direction helpers, both graph distance functions, `PathBetweenNodesExists`, the bubble-checked A* wrapper, and Stardew cardinal-direction conversion.

Important: uppercase `Distance(x1,y1,x2,y2)` is squared Euclidean float; lowercase `distance(x1,x2,y1,y2)` is true Euclidean double with `sqrt`.

### Pass 18: graph state / bubble grid

Source `f440b04c41ab963ca84e5cefc47204fecb57e244`, 5 methods.

- `Init`: stores gameLocation/map, allocates map-sized `AStarNode[,]`, constructs one node per tile.
- `FarmerAStarNode`: player position / 64 tile lookup.
- `FetchNeighbourNodeThatIsPassible`: probe +x,-x,+y,-y for first passable + TileClear node.
- `ResetBubbles`: clears bubbleChecked and selected bubble IDs over map-sized grid.
- `mergeBubbleID2IntoBubbleID`: promotes secondary zero-region into primary zero-region and clears checked state.

### Pass 19: farmer offset / bubble refresh

Source `394de850b060daf6f0991d81e5714f69a8866f07`, 2 methods.

`FarmerAStarNodeOffset` uses `(player.position + 32) / 64`. If the offset node is null, it falls back to `FetchNeighbourNodeThatIsPassible` only when `Game1.currentLocation is FarmHouse`.

The FarmHouse class identity is proven by exact reuse of native class global `0x1038c6c50` in iOS `DecoratableLocation.MakeMapModifications`, whose shared C# branch is explicitly `this is FarmHouse`.

`RefreshBubbles` resets both bubble sets and floods primary bubble 0 from `FarmerAStarNodeOffset` when the farmer/offset nodes are available.

### Pass 20: direction masks

Source `80bbb4c6e440dcda15242496ddec608c25eabe0b`, 2 methods.

- `AreOppositeWalkDirection`: ARM64 jump tables/masks reduced to an exact readable enum truth table and exhaustively checked against the native control-flow translation.
- `WalkDirectionBetweenTwoPointsWithLastDirection`: native masks decoded into compatible previous-direction sets; diagonal/cardinal branch ordering and threshold asymmetry preserved.

## AStarNode / TileClear state

The emitted TileClear orchestration and verified leaves cover gate/fence logic, furniture, blocking beds, travelling shops, animals, NPCs, festival/event props, chests, scarecrows, resource clumps, and building retrieval primitives.

Canonical correction: Mono class/supertype tests here are subclass-friendly C# `is`, not exact runtime-type equality. `ContainsTravellingCart` is `is Forest`; `ContainsTravellingDesertShop` is `is Desert` and includes `DesertFestival`. Older base-ledger prose saying exact type is superseded.

## Reusable tooling

- `scripts/resolve_mono_vtable_offset.py`: exact .NET 8.0.15 / Mono `50c4cb9f...` ARM64 virtual-slot resolver.
- `scripts/check_reconstruction_ledger.py`: validates base `methods.tsv` + append-only fragments.

## Active frontiers

### Path construction / search

1. Reconstruct `RetracePath` and `SmoothRightAngles` as bounded path units.
2. Recover `DiagonalWalkDirection` from raw ARM64 if smoothing requires it.
3. Then reconstruct core `GetShortestPathAStar` and `GetShortestPathDijkstra` with the path helpers already known.
4. Handle the larger diagonal/bubble-check path wrapper after its child semantics are readable.

### AOT string recovery

The private workspace contains extracted `StardewValley.dll` and `StardewValley.aotdata.arm64`. Official Mono runtime source proves `LDSTR` patch records encode image index + user-string token offset. Regular separate-data GOT patch decoding is understood. Apple LLVM AOT constants referenced from later BSS globals remain outside the regular `jit_got` range; mapping those globals back to LLVM patch-info/string tokens is the reusable blocker.

Solving that should unlock `ContainsCinema`, `BrokenFestivalTile`, `IsBuildingPassable`, `ContainsStumpOrBoulder`, `AStarPath.ToString`, and other string-dependent methods.

## Validation / discipline

Every emitted method in passes 17–20 was compile-checked with the persisted .NET SDK `10.0.400` against minimal signature-compatible stubs; current checks have **0 compile errors** and the most recent helper/state/mask batches have 0 warnings.

Do not guess AOT strings, collapse observable distinctions, or add convenience helpers absent from managed metadata when shipped structure is known. iOS native evidence remains implementation authority; Linux source is a naming/semantic reference oracle.
