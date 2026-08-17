# TapToMoveUtils IsTilePassable pass 38

Target: `StardewValley.Mobile.TapToMoveUtils.IsTilePassable(GameLocation,int,int)`, token `0x060066EE`, native `0x101fcbff8`, iOS `1.6.15.1` build `25156`.

Source commit: `fb5f5eb616a9f637dd0b42afdaf361a2bd19bbd3`.

This is the first method reconstructed after the completed 108/108 AStar pilot.

## Exact map/property literals

The LLVM AOT scalar decoder independently resolves the native globals used here to:

- `Buildings`
- `Back`
- `Passable`
- `Water`
- `WaterSource`
- `Shadow`
- `0`

No map/property names were guessed.

## Same-era xTile identities

The owned Linux `1.6.15.24356` `xTile.dll` decompile establishes the framework API identities used by the iOS native body:

- `Map.GetLayer(string)`
- `Layer.PickTile(Location, Size)`
- `Tile.TileIndexProperties`
- inherited direct `Tile.Properties`
- `IPropertyCollection.TryGetValue`
- `PropertyValue.ToString()`

The probe location is `(tileX << 6, tileY << 6)` with `Game1.viewport.Size`.

## VolcanoDungeon identity / vtable proof

The native class global `0x1038d7950` is proven to be `StardewValley.Locations.VolcanoDungeon`:

- iOS `GameLocation.StoreCachedMultiplayerMap` uses the exact same class global in the branch corresponding to current shared C# `this is VolcanoDungeon` before its subsequent `MineShaft` check.

The virtual call through `VolcanoDungeon` at MonoVTable `+0x700` resolves to `VolcanoDungeon.IsCooledLava(int,int)`:

- physical slot `(0x700 - 0x50)/8 = 214`;
- GameLocation's reconstructed prefix plus IslandLocation's four new virtuals place VolcanoDungeon's newly assigned virtual slots at this range;
- in reversed Mono NEW_SLOT assignment order, `IsCooledLava` lands at slot 214;
- the shared method semantics exactly match the native water exception.

## Reconstructed behavior

### No Buildings tile

Pick the Back tile. If it is null, return false.

Read Back `TileIndexProperties["Passable"]` if present:

- convert to lowercase and inspect the first character;
- if it is `'f'`, return false;
- if the original property string is exactly `"0"`, return false.

This preserves the native string-index behavior, including the fact that an empty property string would fail at `[0]` rather than being silently accepted.

Read Back `Water`:

- normally a present Water property makes the tile impassable;
- exception: when `gameLocation is VolcanoDungeon` and `IsCooledLava(tileX,tileY)` is true, continue.

Read Back `WaterSource`:

- present -> false;
- absent -> true.

### Buildings tile present

Property precedence is deliberately nested and differs from `AStarNode.IsBuildingPassable`:

1. Try Buildings `TileIndexProperties["Passable"]`.
2. Only if absent, try direct `Properties["Passable"]`.
3. Only if both Passable values are absent, try TileIndexProperties `Shadow`.

Then:

- first Passable exists and lowercase first char is `'t'` -> true;
- otherwise, if direct Passable was the selected source and lowercase first char is `'t'` -> true;
- otherwise return whether Shadow was found.

A present-but-non-true higher-priority Passable property does **not** fall through to the lower-priority source or Shadow. This ordering is observable in the iOS native control flow and is preserved.

## Cross-reference with AStarNode

Completed `AStarNode.isTilePassable()` is a thin wrapper around this exact method. Completing this method therefore closes the previously external semantic dependency behind that AStarNode result.

## Validation

The reconstructed method was compiled with .NET SDK `10.0.400` against the **actual owned Linux 1.6.15.24356 `xTile.dll` and `MonoGame.Framework.dll`**, plus signature-compatible Stardew stubs.

Result: **0 warnings, 0 errors**.

## Next

The closest siblings are `TapToMoveUtils.IsWater`, `IsBuildingPassable`, and `IsWateringCanFillingSource`. They reuse the same Back/Buildings/Water property vocabulary and VolcanoDungeon semantics, making them the highest-value next bounded cluster before moving to unrelated utility functions.
