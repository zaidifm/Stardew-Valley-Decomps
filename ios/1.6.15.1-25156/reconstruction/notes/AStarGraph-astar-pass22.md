# AStarGraph core A* pass 22

Target: `StardewValley.Mobile.AStarGraph.GetShortestPathAStar`, token `0x06006603`, native `0x101fa23f0`, iOS `1.6.15.1` build `25156`.

Source commit: `b0cbebe8efc5489edc6735ade0e9faf7bcdf2ed3`.

## Data structures

The native allocation/call patterns reduce to:

- `List<AStarNode> openSet`
- `HashSet<AStarNode> closedSet`

The generic operations are used with standard semantics: List Add/Remove/Contains/indexing and HashSet Add/Contains.

Null start or end returns null before allocating search state.

## Bed collision policy

Before the search loop, the native method checks whether `gameLocation` is a `DecoratableLocation` using the same class global already proven by `AStarNode.isBlockingBedTile`. If so, it sets an avoidance flag only when `endNode.isBlockingBedTile()` is false.

During neighbour expansion, when that flag is true, any neighbour for which `isBlockingBedTile()` is true is skipped. Therefore a path may target a blocking-bed tile, but otherwise will not traverse one inside decoratable locations.

## Open-set selection

Each iteration starts with `openSet[0]`, then scans remaining entries. A candidate replaces the current node when:

- `candidate.fCost < current.fCost`, or
- `candidate.fCost == current.fCost && candidate.hCost < current.hCost`.

The selected current node is removed from openSet and added to closedSet.

If it is `endNode`, the method returns `RetracePath(startNode,endNode)`.

## Neighbour relaxation

Neighbours come from `currentNode.GetNeighbouringNodeList(true)`.

For each neighbour:

1. skip if already in `closedSet`;
2. apply the blocking-bed rule above;
3. `newCost = currentNode.gCost + 1f`;
4. update when `newCost < neighbour.gCost || !openSet.Contains(neighbour)`;
5. on update:
   - `neighbour.gCost = newCost`;
   - `neighbour.hCost = Distance(neighbour.x,neighbour.y,endNode.x,endNode.y)`;
   - `neighbour.parentNode = currentNode`;
   - add to openSet if not already present.

`Distance` here is the already-proven **squared Euclidean float** helper, not the lowercase sqrt helper.

If openSet becomes empty, return null.

## Important shipped quirk: fCost is read but not written here

The ARM64 body reads AStarNode `fCost` at offset `+0x28` for open-set ordering. It writes `gCost` (`+0x2c`), `hCost` (`+0x30`) and `parentNode` (`+0x10`) during relaxation, but there is **no write to `fCost` in this method**.

This is not a decompiler omission: direct disassembly of the complete method range contains loads from node `+0x28` but no corresponding store to that node field. The reconstruction therefore does **not** replace the shipped behavior with an assumed `fCost = gCost + hCost` update.

The semantic origin/initialization of fCost can be investigated separately, but changing it here would cease to be a reconstruction.

## Validation

The recovered method compiles with .NET SDK `10.0.400` against minimal List/HashSet, AStarNode, path and DecoratableLocation stubs with **0 warnings, 0 errors**.
