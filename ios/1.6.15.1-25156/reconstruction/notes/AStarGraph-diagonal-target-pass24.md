# AStarGraph diagonal-target wrapper pass 24

Target: `GetShortestPathToNeighbouringDiagonalAStarWithBubbleCheck`, token `0x06006618`, native `0x101fa7078`, iOS `1.6.15.1` build `25156`.

Source commit: `106ea0a4bc5d06b22876654a1705b464449c5d95`.

## Direct-path first

The method first calls `GetShortestPathAStarWithBubbleCheck(startNode,endNode)` and returns it immediately when non-null.

If that fails, the native method reads the end node's `_fakeTileClear` backing byte (`+0x45`). If false, return null.

## Diagonal candidates

The four diagonal nodes around end are fetched in this exact order:

- NW `(x-1,y-1)`
- NE `(x+1,y-1)`
- SW `(x-1,y+1)`
- SE `(x+1,y+1)`

For each non-null candidate the native ARM64 computes true Euclidean distance from the **start node** with SIMD integer subtraction, double conversion, squares, horizontal add and `fsqrt`. Null candidates receive `double.MaxValue` (`0x7fefffffffffffff`).

The implementation does not call the class's lowercase `distance` helper; the square-root arithmetic is repeated directly in this native method, so the staged C# likewise keeps the calculation local.

## Selection and tie behavior

The native comparisons are strict:

1. Select NW only if it is TileClear and `dNW < dNE`, `dNW < dSW`, `dNW < dSE`.
2. Otherwise select NE only if TileClear and strictly smaller than NW, SW, and SE.
3. Otherwise select SW only if TileClear and strictly smaller than NW, NE, and SE.
4. Otherwise select SE if it is non-null and TileClear, with **no remaining distance comparison**.
5. Otherwise return null.

This means a tie can deliberately fall through to SE even when SE is not uniquely closest. The staged reconstruction preserves the observed branch structure rather than replacing it with a generic `MinBy` or stable nearest-candidate operation.

The chosen diagonal candidate is then passed to `GetShortestPathAStarWithBubbleCheck(startNode,candidate)` and that result is returned.

## Validation

The reconstructed wrapper compiles with .NET SDK `10.0.400` against minimal AStarNode/path stubs with **0 warnings, 0 errors**.
