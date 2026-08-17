# TapToMoveUtils resource-clump cluster pass 43

Targets:

- `IsMatureTreeStumpOrBoulderAt(Vector2)` token `0x060066F0`, native `0x101fcc7b0`
- `IsTreeStumpOrBoulderAt(Vector2)` token `0x060066F1`, native `0x101fcc848`
- `IsStumpAt(AStarNode/Vector2/int,int)` tokens `0x06006701..03`
- `IsGiantWeedAt(AStarNode/Vector2/int,int)` tokens `0x06006704..06`
- `IsBoulderAt(AStarNode/Vector2/int,int)` tokens `0x06006707..09`
- private `isResourceClumpBoulderAt(ResourceClump,int,int)` token `0x0600670A`, native `0x101fce110`

Source commit: `2c00b5a77aeb2aae0c0117f5b18316d18f090c64`.

## Shared ResourceClump mechanics

All stump/giant-weed checks iterate `TapToMoveUtils.gameLocation.resourceClumps` and call mapped `ResourceClump.occupiesTile(x,y)` at native `0x101a983a0`.

The native bit tests decode exactly against current shared ResourceClump constants:

- stump/hollow-log: `(index | 2) == 0x25A` -> 600 / 602 -> `stumpIndex` / `hollowLogIndex`
- green-rain giant weeds: `(index | 2) == 0x2E` -> 44 / 46 -> `greenRainBush1Index` / `greenRainBush2Index`

## Wrapper behavior

AStarNode overloads directly read `endNode.x/endNode.y`; native has no friendly null return and follows ordinary null-reference failure for a null node.

Vector2 overloads truncate X/Y to ints and delegate.

## Boulder helper

`isResourceClumpBoulderAt` first requires `resourceClump.occupiesTile(x,y)`, then accepts exactly these parent-sheet indexes:

- `mineRock1Index = 752`
- `mineRock2Index = 754`
- `mineRock3Index = 756`
- `mineRock4Index = 758`
- `boulderIndex = 672`
- `meteoriteIndex = 622`

The native test is an optimized range/bitmask for 752/754/756/758 plus explicit 672/622 comparisons. A null clump is not accepted; native follows its null/throw path, so the staged helper does not invent a null guard.

## `IsBoulderAt(int,int)`

LLVM CLASS patch decoding proves the two specialized location tests:

- `0x1038c69d0` -> `StardewValley.Farm`
- `0x1038c6de0` -> `StardewValley.Locations.MineShaft`

The native body duplicates the resource-clump scan for Farm and MineShaft but in both branches uses the same `gameLocation.resourceClumps` collection. The staged C# collapses only this proven duplicate structure to:

`gameLocation is Farm || gameLocation is MineShaft` -> scan resource clumps with the helper.

After the clump scan, the native falls back to `gameLocation.objects.TryGetValue(new Vector2(x,y), out obj)` and checks the object's virtual ItemId getter against exact LLVM strings:

- `Stone`
- `Boulder`

So an ordinary placed object with either ItemId is also considered a boulder.

## Composite wrappers

`IsMatureTreeStumpOrBoulderAt(Vector2)` truncates coordinates and short-circuits in shipped order:

1. `IsTreeAt(x,y)`
2. `TreeGrowthStage(x,y) >= 1`
3. `IsChoppableBushAtPoint(x,y)`
4. `IsStumpAt(x,y)`
5. `IsBoulderAt(x,y)`

Note the mobile method passes tile-space integer X/Y directly to `IsChoppableBushAtPoint`, even though that leaf otherwise operates in pixel-space. This oddity is present in the native calls and is preserved rather than silently multiplying by 64.

`IsTreeStumpOrBoulderAt(Vector2)` similarly tests:

1. tree
2. stump
3. boulder
4. `IsChoppableBushAtPoint(x,y)`

## Validation

All 12 methods compile together with .NET SDK 10.0.400 against MonoGame.Framework plus signature-compatible GameLocation/Object/ResourceClump/MineShaft stubs.

Result: **0 warnings, 0 errors**.

## Result

The post-AStar TapToMoveUtils reconstruction now has **32 methods** across the core/passability, tree, bush, and resource-clump clusters.

Next useful frontier: `IsTerrainFeatureAt` plus the crab-pot/path-accessibility helpers, or another small geometry/helper cluster based on dependency locality. Avoid expanding into huge TapToMove integration methods until the utility vocabulary is broader.
