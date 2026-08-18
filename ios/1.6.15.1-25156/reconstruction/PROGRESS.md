# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

Compact resume marker. Detailed evidence lives in base `methods.tsv`, append-only `ledger/*.tsv`, and `notes/`.

## Current checkpoint

### AStar pilot

**COMPLETE: 108/108 managed methods**

- `AStarPath`: 9/9
- `AStarNode`: 64/64
- `AStarGraph`: 35/35

Completion marker: `d45eeb4e19e0e5ec0485084b7ec19bca7ce34ddd`.

### Active frontier: TapToMoveUtils

Native selected recovery: **84/84 methods available**.

Semantic C# reconstruction: **80/84 methods complete**.

Only four TapToMoveUtils methods remain:

1. `GetTileNextToBuildingNearestFarmer`
2. `ListOfTilesSurroundingBuilding`
3. `ItemCanBePlaced`
4. `TraceMap`

## Passes completed since the prior 60/84 marker

### Pass 49 — warp cluster

Source `ac62fb1b8218523eedcb54ae46c274931ff2d224`.

Completed `InWarpRange`, `NodeIsWarp`, `WarpIfInRange`, `NpcAtWarpOrDoor`. Preserved VolcanoEntrance -> VolcanoDungeon0 temporary warp remap, IslandSouth `westernTurtleMoved` guard, BusStop/Desert skip, dual click/player distance checks, and NPC one-tile-ahead Buildings/Action lookup.

### Pass 50 — ore / suspension bridge

Source `594f8d925db8a1ffcdde7001d9d4265c185c95fb`.

Completed the two deliberately deferred helpers without guessing:

- `IsOreAt`: external SFLDA proven `Microsoft.Xna.Framework.Point.zeroPoint` / `Point.Zero`; GameLocation field proven `orePanPoint`.
- `isOnOrNearSuspensionBridge`: Farmer `+0x438` proven `onBridge` through native `Farmer.SetOnBridge`.

There are currently no intentionally unresolved TapToMoveUtils field identities.

### Pass 51 — interaction helpers

Source `f681eb58d85acbfda00ca7f83451a8228177a8d3`.

Completed `FetchAccessibleTileNextToBuilding`, `HoeSelectedAndTileHoeable`, `TappedEggAtEggFestival`, `FetchFarmAnimal`.

Important shipped behavior: successful `FetchAccessibleTileNextToBuilding` leaves the selected node `FakeTileClear=true`; the reset occurs only on failure. `FetchFarmAnimal` prefers an unpetted matching animal and retains a petted hit only as fallback.

### Pass 52 — crab-pot helpers

Source `b07cfdcc83da83c51d1cbd51257f4bd60130f98e`.

Completed `FetchMostAccessibleNodeToCrabPot`, `CrabPotNeighbour`, `ClickedCrabPot`.

Raw ARM64 confirms a shipped duplicate in `FetchMostAccessibleNodeToCrabPot`: its eight water probes are N,S,W,E,NW,NE,SW,**SW again**. There is no SE probe.

### Pass 53 — retarget / furniture

Source `fc8bc9895d1061826715d784d18ef91d2aba73f6`.

Completed `retargetToParrotExpressSpot`, `retargetToBedSpot`, `NodeContainsFurniture`, `GetFurnitureClickedOn`.

Preserved two unusual branches: IslandLocation with no matching parrot platform returns `Point.Zero`, while non-Island returns the original click; single-bed retarget chooses the left bed tile when the normal bed spot is strictly closer to the player than the left tile.

### Pass 54 — Island North / water path helpers

Source `91ed92b92bf73d206cd717271458ecf47b02298e`.

Completed `getPathOnIslandNorthBridge`, `FetchAStarNodeNearestWaterSource`, and `FetchNearestAStarLandNodePerpendicularToWaterSource`.

The nearest-water-source helper probes +/-X then +/-Y at radii 1..29. With multiple candidates, its distance loop begins at index 1 with `float.MaxValue`, so candidate 0 is never distance-tested. Distance is from `PlayerOffsetPosition` to the candidate's `NodeCenterOnMap`. The perpendicular scan returns the previous node before the first clear non-filling node.

## Reusable capabilities

- `scripts/decode_llvm_aotconst.py`: LLVM scalar -> AOT patch -> exact managed string/class constants.
- private ~19k-row LDSTR map persisted in the Universal File Library.
- exact SFLDA/static-field decoding across dependent assemblies demonstrated.
- `scripts/resolve_mono_vtable_offset.py`: exact Mono virtual-slot resolver.
- GameLocation vtable identities used in current work include `+0x260 -> doesTileHaveProperty` and `+0x3e8 -> IsTileOccupiedBy`.
- same-era owned Linux `xTile.dll` decompile persisted privately.
- actual same-era xTile/MonoGame assemblies used for compile validation where appropriate.

## Immediate next action

Finish the final four TapToMoveUtils methods in bounded passes:

- building geometry/accessibility: `ListOfTilesSurroundingBuilding`, `GetTileNextToBuildingNearestFarmer`;
- placement: `ItemCanBePlaced`;
- remaining map diagnostic/trace method: `TraceMap`.

Then mark TapToMoveUtils **84/84 complete**, checkpoint GitHub + Library, and move directly to `VirtualJoypad` (80/80 native high-level recoveries available).

## Validation / discipline

Every emitted TapToMoveUtils cluster through pass 54 has been compile-checked in a signature-compatible harness; dependency-sensitive clusters use the actual same-era owned xTile/MonoGame assemblies. Preserve shipped quirks, native method boundaries, exact constants, and observable side effects. iOS native evidence remains implementation authority; current Linux source/dependencies are naming and shared-semantics oracles.
