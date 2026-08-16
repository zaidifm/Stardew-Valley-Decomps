# AStarNode initial TileClear child predicates pass 5

Target: the first three independently bounded child predicates behind `AStarNode.TileClear` in iOS `1.6.15.1` build `25156`.

Source commit: `7f586bef60a509a7fc888127998c9c6a0fb995a0`.

## `isTilePassable`

- token: `0x06006643`
- native address: `0x101fa9730`

The shipped native body is a thin wrapper around `TapToMoveUtils.IsTilePassable`. It passes exactly:

1. `_aStarGraph.gameLocation`
2. this node's `x`
3. this node's `y`

The called managed method is `TapToMoveUtils.IsTilePassable`, token `0x060066EE`. The wrapper is therefore reconstructed without attempting to inline or reinterpret the TapToMoveUtils implementation.

## `ContainsTravellingCart`

- token: `0x06006639`
- native address: `0x101fa8b20`

The native method first performs an exact runtime-type check for `StardewValley.Locations.Forest`. It does not use a subclass-friendly `is Forest` test. This distinction is preserved with `location.GetType() == typeof(Forest)`.

For a Forest location:

1. Read `Forest.travelingMerchantBounds`.
2. If the list is null, return false.
3. Construct this node's 64x64 pixel rectangle at `(x << 6, y << 6)`.
4. Iterate each merchant `Rectangle`.
5. Return true on the first `merchantBounds.Intersects(tileBounds)`.
6. Otherwise return false.

The iOS managed metadata identifies `travelingMerchantBounds` as `NetList<Rectangle, NetRectangle>`. The current Linux Forest decompile independently uses the same bounds collection and rectangle-intersection semantics in shared collision code; Linux is a naming/shape cross-check here, while the iOS native method establishes the mobile behavior.

## `ContainsTravellingDesertShop`

- token: `0x0600663A`
- native address: `0x101fa8d00`

The method performs an exact runtime-type check for `StardewValley.Locations.Desert`, then intersects the node's 64x64 pixel rectangle with `Desert.desertMerchantBounds`.

This exact-type check matters because `DesertFestival : Desert` exists in the iOS metadata. Using `location is Desert` would incorrectly include the festival subclass and would not match the shipped native class-identity comparison. The reconstruction therefore uses `location.GetType() == typeof(Desert)`.

The current Linux Desert source independently confirms the shared `desertMerchantBounds` field and rectangle-intersection collision semantics.

## Validation

The staged partial source was compiled with the persisted .NET SDK `10.0.400` against minimal signature-compatible location/geometry stubs.

Result: 0 errors. One `CS0649` warning is caused only by the stripped harness leaving `_aStarGraph` uninitialized.

## Next dependency choices

Avoid `ContainsCinema` and `BrokenFestivalTile` until their AOT-managed string constants are recovered instead of guessed. Two cleaner next targets are:

- `ContainsFestivalProp`, whose native body is collection/rectangle driven and appears resolvable from Event metadata;
- `isBlockingBedTile`, after resolving its BedFurniture virtual call through the checked-in Mono vtable-offset machinery.
