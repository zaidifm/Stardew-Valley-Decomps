# AStarNode initial TileClear child predicates pass 5

Target: the first three independently bounded child predicates behind `AStarNode.TileClear` in iOS `1.6.15.1` build `25156`.

Original source commit: `7f586bef60a509a7fc888127998c9c6a0fb995a0`.
Type-test correction source commit: `ae80ac2cb6c9da7d42cd1ae6a2f409174ed89bd4`.

## Correction: Mono type-test interpretation

The first version of this note incorrectly described the AOT class/supertype comparison sequence as an exact `GetType() == typeof(...)` test.

That interpretation is disproven by direct comparison with iOS `GameLocation.isFarmBuildingInterior` (token `0x06003B4B`, native `0x10193f8c8`). The current shared C# implementation is simply:

`return this is AnimalHouse;`

and its ARM64 uses the same optimized Mono class/supertype comparison pattern seen in these mobile predicates. The pattern therefore represents subclass-friendly C# `is`, not exact runtime-type equality.

The staged source has been corrected accordingly. Any earlier statement that `DesertFestival : Desert` must be excluded was wrong and is superseded by this note.

## `isTilePassable`

- token: `0x06006643`
- native address: `0x101fa9730`

The shipped native body is a thin wrapper around `TapToMoveUtils.IsTilePassable`. It passes exactly:

1. `_aStarGraph.gameLocation`
2. this node's `x`
3. this node's `y`

The called managed method is `TapToMoveUtils.IsTilePassable`, token `0x060066EE`. The wrapper is reconstructed without attempting to inline or reinterpret the helper.

## `ContainsTravellingCart`

- token: `0x06006639`
- native address: `0x101fa8b20`

The class/supertype test identifies `StardewValley.Locations.Forest`; source semantics are `gameLocation is Forest`.

For a Forest-compatible location:

1. Read `Forest.travelingMerchantBounds`.
2. If the list is null, return false.
3. Construct this node's 64x64 pixel rectangle at `(x << 6, y << 6)`.
4. Iterate each merchant `Rectangle`.
5. Return true on the first `merchantBounds.Intersects(tileBounds)`.
6. Otherwise return false.

The iOS managed metadata identifies `travelingMerchantBounds` as `NetList<Rectangle, NetRectangle>`. Linux supplies the same shared field/type naming; iOS native code remains behavioral authority.

## `ContainsTravellingDesertShop`

- token: `0x0600663A`
- native address: `0x101fa8d00`

The class/supertype test identifies `StardewValley.Locations.Desert`; source semantics are `gameLocation is Desert`.

The method constructs the node's 64x64 pixel rectangle and returns the intersection result with `Desert.desertMerchantBounds`.

Because this is an `is Desert` test, subclasses such as `DesertFestival : Desert` are included. The previous note/source that used exact type equality was an overconstraint and has been corrected.

## Validation

The corrected staged partial compiles with the persisted .NET SDK `10.0.400` against minimal signature-compatible location/geometry stubs with 0 errors.

## Next dependency choices

Avoid string-dependent predicates until exact AOT-managed string recovery is available. Continue bounded collision/location predicates and use the now-proven Mono `is`-test interpretation for the remaining class-guarded methods.
