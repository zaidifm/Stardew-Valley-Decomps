# TapToMoveUtils tree lookup core pass 41

Targets:

- `TreeGrowthStage(AStarNode)` token `0x060066F2`, native `0x101fcc8cc`
- `TreeGrowthStage(Vector2)` token `0x060066F3`, native `0x101fcc91c`
- `TreeGrowthStage(int,int)` token `0x060066F4`, native `0x101fcc95c`
- `IsTreeAt(AStarNode)` token `0x060066F5`, native `0x101fccac8`
- `IsTreeAt(Vector2)` token `0x060066F6`, native `0x101fccb0c`
- `IsTreeAt(int,int)` token `0x060066F7`, native `0x101fccb4c`
- `GetTreeAt(int,int)` token `0x060066F8`, native `0x101fccc38`

Source commit: `964f48e11204d2e323cff921b6dc57c2803dfb61`.

## Terrain-feature dictionary

All carrying methods use `TapToMoveUtils.gameLocation` and the GameLocation object field at native offset `+0x120`. This is the managed `GameLocation.terrainFeatures` dictionary. The native helper `0x1003554a0` performs the Vector2-keyed lookup with an out terrain-feature reference.

## Exact terrain-feature type constants

LLVM `MONO_PATCH_INFO_CLASS` records decode:

- scalar `0x1038c7998` -> TypeDef 1265 -> `StardewValley.TerrainFeatures.Tree`
- scalar `0x1038c7910` -> TypeDef 1255 -> `StardewValley.TerrainFeatures.FruitTree`

`IsTreeAt(int,int)` therefore returns true only when the terrain feature at `(x,y)` is Tree or FruitTree.

`GetTreeAt(int,int)` returns that same feature for Tree/FruitTree and null otherwise.

## Growth stage

`TreeGrowthStage(int,int)` performs the same dictionary lookup and returns:

- `Tree.growthStage.Value` for a Tree;
- `FruitTree.growthStage.Value` for a FruitTree;
- 0 for missing or other terrain features.

The native field access on both types reaches their `growthStage : NetInt` and reads the NetInt value at `+0x68`.

## Wrapper overloads

`TreeGrowthStage(AStarNode)` directly passes `endNode.x/endNode.y` to the int overload. It has no null guard; a null node therefore follows ordinary null-reference behavior.

`TreeGrowthStage(Vector2)` truncates X/Y to ints and delegates.

`IsTreeAt(AStarNode)` is explicitly null-safe and returns false for a null node, otherwise delegates by x/y.

`IsTreeAt(Vector2)` truncates and delegates.

These wrapper differences are preserved.

## Validation

All seven methods were compiled together with .NET SDK `10.0.400` against MonoGame.Framework plus signature-compatible terrain-feature/dictionary stubs.

Result: **0 warnings, 0 errors**.

## Next

Continue outward through Bush/choppable-bush/stump/boulder predicates, then close the two higher-level wrappers `IsMatureTreeStumpOrBoulderAt` and `IsTreeStumpOrBoulderAt` once their leaf predicates are reconstructed.
