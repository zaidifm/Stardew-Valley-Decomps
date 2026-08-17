# TapToMoveUtils core/passability cluster pass 39

Targets in iOS `1.6.15.1` build `25156`:

- `get_gameLocation` token `0x060066CB`, native `0x101fc84fc`
- `get_inMiniGameWhereWeDontWantTaps` token `0x060066CC`, native `0x101fc85dc`
- `IsWater(Vector2)` token `0x060066EC`, native `0x101fcbb7c`
- `IsBuildingPassable(Vector2)` token `0x060066ED`, native `0x101fcbdd8`

Source commits:

- `TapToMoveUtils.Core.cs`: `0db5c325297179394192535ad851966ec1c61f50`
- expanded `TapToMoveUtils.Passability.cs`: `441d9055f33833fad1b1591e0df4cb66eda4130f`

Together with pass 38 `IsTilePassable`, this establishes the first coherent TapToMoveUtils passability core.

## Class constants decoded from LLVM AOT patch metadata

The scalar-to-LLVM-slot machinery also exposes `MONO_PATCH_INFO_CLASS` records. These common class constants encode `MONO_AOT_TYPEREF_TYPEDEF_INDEX`; matching TypeDef indexes against iOS metadata gives exact identities:

- `0x1038d5370` -> TypeDef 1478 -> `StardewValley.Minigames.FishingGame`
- `0x103904a90` -> `AbigailGame`
- `0x103904a88` -> `FantasyBoardGame`
- `0x1038d54f0` -> `GrandpaStory`
- `0x103904a80` -> `HaleyCowPictures`
- `0x103904a78` -> `MineCart`
- `0x103904a70` -> `PlaneFlyBy`
- `0x103904a68` -> `RobotBlastoff`
- `0x1038c6e68` -> TypeDef 1547 -> `StardewValley.Locations.Submarine`
- `0x1038d7950` -> `StardewValley.Locations.VolcanoDungeon` (already independently proven in pass 38)

This removes semantic guesses from the minigame/location type tests.

## `gameLocation`

If `Game1.currentMinigame is FishingGame`, return that minigame's `location` field. iOS managed metadata marks `FishingGame.location` assembly-visible. Otherwise return `Game1.currentLocation`.

## `inMiniGameWhereWeDontWantTaps`

Returns false for null `Game1.currentMinigame`. Otherwise true exactly for:

- AbigailGame
- FantasyBoardGame
- GrandpaStory
- HaleyCowPictures
- MineCart
- PlaneFlyBy
- RobotBlastoff

Native uses separate Mono class/supertype checks; these are subclass-friendly C# `is` tests.

## `IsWater(Vector2)`

Special Submarine rectangle: X 9..20 and Y 7..11 inclusive -> true.

For VolcanoDungeon:

1. `IsCooledLava((int)X,(int)Y)` -> false.
2. otherwise `CanRefillWateringCanOnTile((int)X,(int)Y)` -> true when set.

Fallback uses virtual `GameLocation.doesTileHaveProperty` on Back:

- `Water` non-null -> true;
- otherwise `WaterSource` non-null -> true;
- else false.

## `IsBuildingPassable(Vector2)`

Pick Buildings tile at pixel `((int)X << 6, (int)Y << 6)`. Null -> false.

1. TileIndexProperties `Passable`: `T` or `True` -> true.
2. direct tile Properties `Passable`: any non-null value -> true.
3. TileIndexProperties `Shadow`: return whether non-null.

Exact literals come from LLVM AOT: `Buildings`, `Passable`, `T`, `True`, `Shadow`.

The PropertyValue conversion helper is semantically its string/ToString conversion; same-era xTile source shows both expose the underlying value's `ToString()`.

This method is observably different from `TapToMoveUtils.IsTilePassable` and completed `AStarNode.IsBuildingPassable`.

## Validation

Combined four-method harness compiled with .NET SDK `10.0.400` against the actual owned Linux 1.6.15.24356 `xTile.dll` and `MonoGame.Framework.dll` plus signature-compatible Stardew stubs.

Result: **0 warnings, 0 errors**.

## Result / next

TapToMoveUtils reconstructed in this phase:

- get_gameLocation
- get_inMiniGameWhereWeDontWantTaps
- IsWater
- IsBuildingPassable
- IsTilePassable

Next: `IsWateringCanFillingSource`, which reuses this cluster and adds buildable-location/FishPond/Railroad source checks.
