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

Native selected recovery: 84/84 methods available.

Semantic C# reconstruction: **60/84 methods complete**.

Latest pass: player/warp geometry (`PlayerOffsetPosition`, `PlayerPositionOnScreen`, `WarpRange`) source commit `a0c24242a9cf0fb574b2fff966b0295a2abbcb6e`, evidence `notes/TapToMoveUtils-player-geometry-pass48.md`, ledger `ledger/pass-48-player-geometry.tsv`.

## Completed TapToMoveUtils clusters

### Core / location / minigame

- `gameLocation`
- `inMiniGameWhereWeDontWantTaps`
- empty constructor

### Passability / water

- `IsWater`
- `IsBuildingPassable`
- `IsTilePassable`
- `IsWateringCanFillingSource`

### Trees / bushes / resource clumps

- 3 `TreeGrowthStage` overloads
- 3 `IsTreeAt` overloads
- `GetTreeAt`
- 3 `IsBushAt` overloads
- `IsBushAtPoint`
- `IsChoppableBushAtPoint`
- `FetchBushAt`
- `FetchBushAtPoint`
- `IsMatureTreeStumpOrBoulderAt`
- `IsTreeStumpOrBoulderAt`
- 3 `IsStumpAt` overloads
- 3 `IsGiantWeedAt` overloads
- 3 `IsBoulderAt` overloads
- `isResourceClumpBoulderAt`

### Direction / geometry

- `ConvertWalkDirection`
- `WalkDirectionForAngle`
- `WalkDirectionForAngleJustDiagonals`
- `FaceDirectionForAngle`
- `WalkDirectionsAgree`
- `GetWalkDirectionFacing`
- `GetDirectionFacing`
- `FetchNextPointOut`
- `PlayerOffsetPosition`
- `PlayerPositionOnScreen`
- `WarpRange`

### Fixed-location / interaction helpers

- `ContainsTravellingCart`
- `ContainsTravellingDesertShop`
- `ContainsCinemaDoor`
- `ContainsCinemaTicketOffice`
- `IsIslandNorthSuspensionBridgeRightSide`
- 2 `IsWizardBuilding` overloads

### Object / terrain helpers

- `NodeContainsMusicBlock`
- `NodeContainsHousePlant`
- `GetHousePlant`
- `IsTerrainFeatureAt`
- `FetchGate`

### Inventory / tools

- `SelectTool`
- `PlayerHasTool`
- `getBestAvailableWeapon`
- `FetchItemInInventoryByName`

## High-value semantic anchors

- Mobile `IsTilePassable` is distinct from shared `GameLocation.isTilePassable`; its property precedence and Volcano cooled-lava exception are preserved exactly.
- `IsWateringCanFillingSource` includes impassable water, completed FishPond/Well, Submarine rectangle, Greenhouse sink tiles, Railroad trough, and Volcano refill logic.
- tree/bush/clump helpers now resolve the two bush storage systems, Tree/FruitTree, stump/hollow-log 600/602, green-rain bushes 44/46, mine-rock/boulder/meteorite resource-clump indexes, and ordinary object `Stone`/`Boulder` fallback.
- direction helpers preserve all native angle-boundary asymmetries and the raw Mach-O direction lookup table.
- inventory helpers compare `ItemId`, not display names; best-weapon selection deliberately treats current-best `Scythe` as replaceable by any later MeleeWeapon.
- `WarpRange` is 128f outdoors or in `BathHousePool`, otherwise 96f.

## Reusable capabilities

- `scripts/decode_llvm_aotconst.py`: LLVM scalar -> AOT patch -> exact managed string/class constants.
- private ~19k-row LDSTR map persisted in the Universal File Library.
- `scripts/resolve_mono_vtable_offset.py`: exact Mono virtual-slot resolver.
- same-era owned Linux `xTile.dll` decompile persisted privately.
- actual same-era `xTile.dll` and `MonoGame.Framework.dll` used in compile validation where appropriate.

## Deliberately unresolved / deferred

- `IsOreAt`: surrounding logic is understood, but one external-assembly SFLDA static field still needs exact identity.
- `isOnOrNearSuspensionBridge`: Farmer NetBool field at native object offset `+0x438` still needs exact identity.

Do not guess either field merely to increase the completion count.

## Immediate next action

Take the shared warp cluster now that `PlayerOffsetPosition` and `WarpRange` are reconstructed:

- `InWarpRange`
- `NodeIsWarp`
- `WarpIfInRange`
- `NpcAtWarpOrDoor`

Resolve only the actual dependencies those methods expose. After the warp cluster, re-rank the remaining utilities by native body size and dependency locality.

## Validation / discipline

Every emitted TapToMoveUtils cluster through pass 48 has been compile-checked in a signature-compatible harness; xTile-dependent clusters use the actual same-era owned xTile/MonoGame assemblies. Preserve shipped quirks, native method boundaries, exact constants, and observable side effects. iOS native evidence remains implementation authority; current Linux source/dependencies are naming and shared-semantics oracles.
