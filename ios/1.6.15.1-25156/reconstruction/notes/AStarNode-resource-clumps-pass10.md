# AStarNode resource-clump predicate pass 10

Targets:

- `ContainsGiantWeed`, token `0x06006648`, native `0x101fab1dc`
- `ContainsGiantCrop`, token `0x06006649`, native `0x101fab390`
- `FetchGiantCrop`, token `0x0600664A`, native `0x101fab530`
- `ContainsStumpOrHollowLog`, token `0x0600664B`, native `0x101fab6dc`

Source commit: `275ba546a794ca24d83eb9af49e5f70a90233f11`.

## Common primitive

All four methods ultimately use native `0x101a983a0`, which the all-AOT map resolves exactly to:

`StardewValley.TerrainFeatures.ResourceClump.occupiesTile(int x, int y)`

token `0x06004578`.

The current Linux `ResourceClump` source independently supplies stable names for the integer constants used by the iOS native code.

## `ContainsGiantWeed`

The native method iterates `gameLocation.resourceClumps`. For a clump occupying `(x,y)`, it accepts when:

`(parentSheetIndex | 2) == 46`

For the relevant nonnegative sprite indices this is exactly the pair 44/46, named in shared source as:

- `ResourceClump.greenRainBush1Index = 44`
- `ResourceClump.greenRainBush2Index = 46`

The reconstruction expresses the two named constants explicitly rather than preserving the compiler's bit trick.

## `ContainsGiantCrop` / `FetchGiantCrop`

Both methods first require the mobile game location to pass the same Farm type-test pattern used by other Farm-specific tap-to-move logic. They then iterate the Farm's inherited `resourceClumps`, require `clump.occupiesTile(x,y)`, and type-test the clump as `GiantCrop`.

`ContainsGiantCrop` returns the boolean result; `FetchGiantCrop` returns the first matching `GiantCrop`, or null.

## `ContainsStumpOrHollowLog`

The native method iterates `gameLocation.resourceClumps` and accepts an occupying clump when:

`(parentSheetIndex | 2) == 602`

The shared constants identify the two values encoded by this test:

- `ResourceClump.stumpIndex = 600`
- `ResourceClump.hollowLogIndex = 602`

The reconstruction uses those named constants explicitly.

## Validation

All four methods were compiled with the persisted .NET SDK `10.0.400` against signature-compatible `GameLocation`, `Farm`, `ResourceClump`, `GiantCrop`, and `NetInt` stubs.

Result: 0 errors. One `CS0649` warning is solely the stripped harness leaving `_aStarGraph` uninitialized.
