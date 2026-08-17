# AStarNode blocking-bed predicate pass 7

Target: `StardewValley.Mobile.AStarNode.isBlockingBedTile`, token `0x0600663C`, native `0x101fa8f0c`.

Source commit: `ab3ae535c735de297a1f70d03f79a127e0583817`.

## Recovered behavior

The native method reads this node's `AStarGraph.gameLocation`, performs the runtime type guard used elsewhere by the mobile code for `DecoratableLocation`, then calls:

`StardewValley.Objects.BedFurniture.GetBedAtTile(location, x, y)`

The static call is mapped exactly by the all-AOT map to token `0x060047FF`, native `0x101add830`.

If no bed is returned, the result is false. Otherwise the method constructs the node's pixel rectangle:

`new Rectangle(x << 6, y << 6, 64, 64)`

and invokes a BedFurniture virtual boolean method through `MonoVTable + 0x660`.

## Virtual call identity

The receiver returned by `GetBedAtTile` is a `BedFurniture`, and the call takes exactly one `Rectangle` value and returns a boolean.

The iOS metadata exposes `BedFurniture.IntersectsForCollision(Rectangle)` as token `0x06004810`, mapped to native `0x101adf394`.

Direct ARM64 at `0x101adf394` independently matches the current Linux `1.6.15.24356` BedFurniture implementation:

1. obtain the bed bounding box;
2. test a top 64-pixel-high rectangle against the input rectangle;
3. if that misses, shift a copy down by 128 pixels and reduce its height by 128;
4. test that lower rectangle;
5. return true on either intersection, otherwise false.

That uniquely matches `IntersectsForCollision(Rectangle)` and establishes the `+0x660` dispatch used by `isBlockingBedTile`.

## Type guard

The repeated AOT runtime-type-check pattern in this mobile corpus is the same pattern used by wallpaper/decoratable-location paths such as `TapToMove.holdingWallpaperAndTileClickedIsWallOrFloor`. The semantic reconstruction therefore preserves the source-level guard as:

`gameLocation is DecoratableLocation`.

This also correctly includes subclasses such as `FarmHouse`, where bed interaction is expected.

## Validation

The staged method was compiled with the persisted .NET SDK `10.0.400` against signature-compatible minimal stubs for `DecoratableLocation`, `BedFurniture`, and `Rectangle`.

Result: 0 errors. One `CS0649` warning is solely the stripped harness leaving `_aStarGraph` uninitialized.

## Next

Continue the `TileClear` predicate frontier with the smallest independently recoverable children. `ContainsFestivalProp` is already complete. Strong next candidates are `ContainsStumpOrBoulder`, `ContainsFurniture`, `ContainsAnimals`, and `ContainsNPC` before descending into the larger `TapToMoveUtils.IsTilePassable` dependency tree.
