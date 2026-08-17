# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

Compact resume marker. Detailed evidence lives in base `methods.tsv`, append-only `ledger/*.tsv`, and `notes/`.

## Current checkpoint

### AStar pilot

**COMPLETE: 108/108 managed methods**

- `AStarPath`: 9/9
- `AStarNode`: 64/64
- `AStarGraph`: 35/35

Completion commit: `d45eeb4e19e0e5ec0485084b7ec19bca7ce34ddd`.

### Active frontier: TapToMoveUtils

`TapToMoveUtils` native recovery: 84/84 selected methods available.

Semantic C# reconstruction completed so far: **32/84 methods**.

Completed TapToMoveUtils clusters:

1. Core location/minigame accessors
   - `gameLocation`
   - `inMiniGameWhereWeDontWantTaps`
2. Passability/water
   - `IsWater`
   - `IsBuildingPassable`
   - `IsTilePassable`
   - `IsWateringCanFillingSource`
3. Tree core
   - 3 `TreeGrowthStage` overloads
   - 3 `IsTreeAt` overloads
   - `GetTreeAt`
4. Bush core
   - 3 `IsBushAt` overloads
   - `IsBushAtPoint`
   - `IsChoppableBushAtPoint`
   - `FetchBushAt`
   - `FetchBushAtPoint`
5. Resource-clump/tree-stump-boulder core
   - `IsMatureTreeStumpOrBoulderAt`
   - `IsTreeStumpOrBoulderAt`
   - 3 `IsStumpAt` overloads
   - 3 `IsGiantWeedAt` overloads
   - 3 `IsBoulderAt` overloads
   - `isResourceClumpBoulderAt`

Latest resource-clump source: `2c00b5a77aeb2aae0c0117f5b18316d18f090c64`.
Evidence: `notes/TapToMoveUtils-resource-clumps-pass43.md`.
Ledger: `ledger/pass-43-resource-clumps.tsv`.

## TapToMoveUtils semantic anchors established

### `IsTilePassable`

Mobile behavior is distinct from shared `GameLocation.isTilePassable` and from `AStarNode.IsBuildingPassable`.

- Buildings tile takes precedence.
- Back `Passable` values beginning with lowercase `f`, and exact `0`, reject.
- Back `Water` rejects except cooled lava in VolcanoDungeon.
- Back `WaterSource` rejects.
- Buildings property precedence is TileIndex `Passable`, then direct `Passable`, then `Shadow`, with no fallthrough when a higher-priority Passable exists but is false.

### `IsWateringCanFillingSource`

Accepted sources include:

- impassable `IsWater` tiles;
- completed FishPond or `buildingType == Well` building;
- Submarine water rectangle;
- Greenhouse sink tiles `(9,7)` / `(10,7)`;
- Railroad trough rectangle;
- VolcanoDungeon refill source.

### Trees/bushes/resource clumps

Exact decoded classes and constants now cover:

- Tree / FruitTree growth and existence;
- Bush storage in both `largeTerrainFeatures` and `terrainFeatures`;
- stump/hollow-log 600/602;
- green-rain bushes 44/46;
- boulder/meteorite/mine-rock indexes 672/622/752/754/756/758;
- ordinary object ItemId fallback `Stone` / `Boulder`.

## Reusable capabilities

- `scripts/decode_llvm_aotconst.py`: LLVM scalar -> AOT patch -> exact managed string/class constants.
- private ~19k-row LDSTR map persisted in the Universal File Library.
- `scripts/resolve_mono_vtable_offset.py`: exact Mono virtual-slot resolver.
- same-era owned Linux xTile.dll decompile persisted as a private dependency oracle.
- actual same-era xTile.dll / MonoGame.Framework.dll used for compile validation where possible.

## Next action

Do not choose remaining utility methods alphabetically. Generate a deterministic inventory of the unreconstructed TapToMoveUtils methods with native body size and dependency neighborhood, then take the largest low-ambiguity/high-locality cluster.

Likely candidates include small geometry/path-accessibility/crab-pot helpers and other methods already sitting on top of the reconstructed tree/water/passability vocabulary. Defer broad integration behavior until the utility leaf vocabulary is substantially complete.

## Validation / discipline

All emitted TapToMoveUtils clusters through pass 43 compile with 0 errors in signature-compatible harnesses; clusters using xTile are checked against the actual same-era owned xTile/MonoGame assemblies. Preserve shipped quirks and native method boundaries. iOS native evidence remains implementation authority; current Linux source/dependencies are naming and semantic reference oracles.
