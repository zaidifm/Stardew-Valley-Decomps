# AStarNode Parrot Express pass 26

Target: `ContainsParrotExpress`, token `0x06006636`, native `0x101fa8688`, iOS `1.6.15.1` build `25156`.

Source commit: `a97021ee12e354dc2ce8f5ea88f77320220ee748`.

## Location / field identity

The native method's location class guard and field layout identify `StardewValley.Locations.IslandLocation`:

- the guarded location field at `+0x2f8` is the public `List<ParrotPlatform> parrotPlatforms` field in current managed metadata/shared source;
- the same class global is used by `TapToMoveUtils.retargetToParrotExpressSpot`, which iterates that same collection.

Non-IslandLocation nodes return false.

## Platform virtual call

Each item is a `StardewValley.BellsAndWhistles.ParrotPlatform`.

The native virtual dispatch uses MonoVTable byte offset `+0x80`. ParrotPlatform directly inherits `System.Object`; with the exact Mono ARM64 header (`0x50`) this is physical slot 6. The class's non-final NEW_SLOT virtuals are assigned in Mono reverse metadata order, and slot 6 resolves to `ParrotPlatform.OccupiesTile(Vector2)`, token `0x06005CBB` (mapped native `0x101dd714c`).

The argument is `new Vector2(x,y)`.

## Vector helper identities and passable platform cells

When `OccupiesTile(tile)` is true, native computes:

- `platform.position / 64f + new Vector2(1f,1f)`
- `platform.position / 64f + new Vector2(1f,0f)`

and compares each against the node tile.

The external trampoline at `0x10035025c` is Vector2 addition. This is independently exposed by `TapToMoveUtils.retargetToParrotExpressSpot`, which passes platform tile position plus `(1,0)` and returns the resulting Point.

The comparison trampoline at `0x1003501d0` is Vector2 inequality. This is independently confirmed by `TapToMoveUtils.GetTileNextToBuildingNearestFarmer`, where candidate tiles are tested against the static `Vector2.Zero` value and nonzero candidates are accepted when this trampoline returns true.

Therefore `ContainsParrotExpress` is true when a platform occupies the node tile **except** for the two platform-relative center cells `(1,1)` and `(1,0)`.

That distinction matches the native branch order exactly and is preserved rather than replaced by a generic platform-collision test.

## Validation

The staged method compiles under .NET SDK `10.0.400` against minimal IslandLocation/ParrotPlatform/Vector2 stubs with 0 errors. The only stripped-harness warning is the expected uninitialized `_aStarGraph` field.
