# TapToMoveUtils bush lookup cluster pass 42

Targets:

- `IsBushAt(AStarNode)` token `0x060066F9`
- `IsBushAt(Vector2)` token `0x060066FA`
- `IsBushAt(int,int)` token `0x060066FB`
- `IsBushAtPoint(int,int)` token `0x060066FC`
- `IsChoppableBushAtPoint(int,int)` token `0x060066FD`
- `FetchBushAt(AStarNode)` token `0x060066FE`
- `FetchBushAtPoint(int,int)` token `0x060066FF`

Source commit: `49d21c343098c099fd16318be2563718a39ccbbb`.

## Exact class/field identities

LLVM CLASS patch decoding gives:

- scalar `0x1038c78e0` -> TypeDef 1252 -> `StardewValley.TerrainFeatures.Bush`
- scalar `0x1038c69d0` -> TypeDef 1140 -> `StardewValley.Farm`

The two GameLocation collections used by native code are:

- `+0x108` -> `largeTerrainFeatures`
- `+0x120` -> `terrainFeatures`

`Game1.whichFarm` is the matching public static managed field (token `0x0400151B`).

Mapped `Bush.isDestroyable()` is token `0x060044BA`, native `0x101a7ce58`.

## Two bush storage paths

The mobile helpers intentionally recognize bushes stored in two different systems.

### LargeTerrainFeature bushes

`IsBushAtPoint(pixelX,pixelY)` iterates `gameLocation.largeTerrainFeatures`. For each `Bush`, it calls `Bush.getBoundingBox().Contains(pixelX,pixelY)`. The first hit returns true.

`FetchBushAtPoint` performs the same scan and returns the first matching Bush.

`IsChoppableBushAtPoint` performs the same hit test and then returns `bush.isDestroyable()` for the matching bush. No hit returns false.

### terrainFeatures bushes

The AStarNode and Vector2 overloads first delegate to the int/int large-feature route. If that fails, they probe `gameLocation.terrainFeatures` at the exact tile key and accept a direct `Bush` terrain feature.

`FetchBushAt(AStarNode)` reverses the preference: it first returns a Bush found directly in `terrainFeatures`, then falls back to the large-feature pixel scan.

## Farm-layout special case

`IsBushAt(int x,int y)` preserves one hardcoded mobile exception:

`x == 32 && y == 9 && Game1.whichFarm == 2 && Game1.currentLocation is Farm` -> false.

Otherwise it calls `IsBushAtPoint(x << 6, y << 6)`.

The Farm type is proven by the decoded CLASS patch, not inferred from the `whichFarm` condition.

## Wrapper null behavior

`IsBushAt(AStarNode)` and `FetchBushAt(AStarNode)` directly read the node's x/y fields; there is no null guard in native code. A null node therefore follows ordinary null-reference behavior.

Vector2 overload truncates X/Y to ints before delegation.

## Validation

All seven methods compile together with .NET SDK 10.0.400 against MonoGame.Framework plus signature-compatible GameLocation/Bush/terrain-feature stubs.

Result: **0 warnings, 0 errors**.

## Next

Proceed through `IsStumpAt`, `IsGiantWeedAt`, `IsBoulderAt`, and `isResourceClumpBoulderAt`, then close the higher-level tree/stump/boulder wrappers now that their leaf predicates are known.
