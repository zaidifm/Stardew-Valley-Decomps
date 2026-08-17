# AStarNode furniture obstacle pass 8

Targets:

- `ContainsFurniture`, token `0x0600664C`, native `0x101fab848`
- `GetFurniture`, token `0x0600664D`, native `0x101faba3c`

Source commit: `2a5a552ad941bfeb9adb7a8b111e260d0994f3c2`.

## Shared evidence

Both methods read `AStarGraph.gameLocation.furniture`, construct/use this node's 64x64 `rect`, and test furniture bounding boxes against that rectangle.

The anonymous direct native call used for each furniture bounding box maps through the all-AOT table to `StardewValley.Object.GetBoundingBox`, token `0x06003E48`, native `0x1019aa6d8`.

The iOS metadata and current Linux `Furniture` source agree on the relevant furniture-type constants:

- `Furniture.rug = 12`
- `Furniture.bed = 15`

## `ContainsFurniture`

The native loop reads `furniture.furniture_type.Value` and deliberately skips both type 12 (rug) and type 15 (bed). Any other furniture whose bounding box intersects the node rectangle returns true. If none match, it returns false.

Beds are handled separately by `isBlockingBedTile`, so their exclusion here is intentional rather than an artifact of the decompiler.

## `GetFurniture`

This method has two passes:

1. Return the first intersecting furniture whose type is not rug (12).
2. If that finds nothing, make a second pass and return the first intersecting rug.
3. Otherwise return null.

Unlike `ContainsFurniture`, beds are not excluded by `GetFurniture`.

The two-pass ordering is preserved because it establishes an observable priority when a rug overlaps another furniture object.

## Validation

The reconstructed methods were compiled with the persisted .NET SDK `10.0.400` against signature-compatible minimal stubs for `GameLocation.furniture`, `Furniture.furniture_type`, `Furniture.GetBoundingBox`, and `Rectangle.Intersects`.

Result: 0 errors. One `CS0649` warning is solely the stripped harness leaving `_aStarGraph` uninitialized.
