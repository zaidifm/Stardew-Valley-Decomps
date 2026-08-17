# TapToMoveUtils IsWateringCanFillingSource pass 40

Target: `StardewValley.Mobile.TapToMoveUtils.IsWateringCanFillingSource(Vector2)`, token `0x060066EF`, native `0x101fcc490`, iOS `1.6.15.1` build `25156`.

Source commit: `d9333e6de77c73842ba85c977fcb06085df8bc5a`.

## Reused completed dependencies

The method begins with the now-reconstructed mobile helpers:

`IsWater(tile) && !IsTilePassable(gameLocation,(int)tile.X,(int)tile.Y)` -> true.

This establishes ordinary impassable water as a watering-can source before the special cases below.

## Buildable-location building source

Native `0x101938908` maps exactly to `GameLocation.getBuildingAt(Vector2)` (`0x06003B2B`).

The native class scalar `0x1038c6590` decodes via LLVM CLASS patch metadata to TypeDef 1692, `StardewValley.Buildings.FishPond`.

For non-FishPond buildings the native body loads Building field `+0x88`, which is `buildingType : NetString`, and invokes its equality path with exact LLVM literal `Well` (`0x1038ff008`). Current Netcode `NetFieldBase.Equals(object)` confirms that `building.buildingType.Equals("Well")` compares the underlying NetString value to the string.

Building field `+0x70` is `daysOfConstructionLeft : NetInt`; the native reads its value and requires `< 1`.

Therefore a building source is accepted when:

- location `IsBuildableLocation()`;
- `getBuildingAt(tile)` returns a building;
- building is `FishPond` OR `building.buildingType.Equals("Well")`;
- `daysOfConstructionLeft.Value < 1`.

## Submarine

LLVM CLASS scalar `0x1038c6e68` is `Submarine`.

Within a Submarine, X 9..20 and Y 7..11 inclusive is accepted. This is the same rectangle used by completed `IsWater`.

## Greenhouse sink tiles

The otherwise opaque GameLocation field at native object offset `+0x1A8` is independently proven to be `isGreenhouse : NetBool`:

- iOS `GameLocation.get_IsGreenhouse` (`0x0600398A`, native `0x1018c0394`) loads exactly `this + 0x1A8`, then reads the NetBool value byte at `+0x68`.

When `gameLocation.IsGreenhouse`, exact tiles `(9,7)` and `(10,7)` are accepted.

## Railroad trough

LLVM CLASS scalar `0x1038c6e28` decodes to TypeDef 1543, `StardewValley.Locations.Railroad`.

In Railroad, X 14..16 and Y 55..56 inclusive is accepted.

## VolcanoDungeon fallback

If no earlier source matched, a `VolcanoDungeon` returns `CanRefillWateringCanOnTile((int)X,(int)Y)`. Non-Volcano locations return false.

## Validation

The reconstructed method was compiled with .NET SDK `10.0.400` against MonoGame.Framework plus signature-compatible GameLocation/Building/FishPond/Submarine/Railroad/Volcano stubs.

Result: **0 warnings, 0 errors**.

## Result

TapToMoveUtils passability/water core now includes six methods:

- get_gameLocation
- get_inMiniGameWhereWeDontWantTaps
- IsWater
- IsBuildingPassable
- IsTilePassable
- IsWateringCanFillingSource

Next bounded cluster: tree/stump/boulder lookup and growth-stage overloads, which are heavily interdependent and should amortize their terrain-feature/resource-clump analysis.
