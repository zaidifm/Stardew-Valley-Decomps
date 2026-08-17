# AStarGraph path-shaping pass 21

Target: `RetracePath` and `SmoothRightAngles` in iOS `1.6.15.1` build `25156`.

Source commit: `3ec8c26868acb7071ed1413c2d07838e6c650c11`.

## `RetracePath`

Token `0x06006604`, native `0x101fa2f4c`.

The native method constructs a new `AStarPath`, whose constructor provides a fresh `List<AStarNode>` for `nodes`, then walks from `endNode` toward `startNode` through `parentNode`:

```text
while (endNode != startNode):
    path.nodes.Add(endNode)
    endNode = endNode.parentNode
path.nodes.Reverse()
return path
```

The start node is not inserted. The original end node is inserted. If the parent chain reaches null before the start, the native null path raises the same managed failure naturally produced by dereferencing `endNode.parentNode` in C#.

## `SmoothRightAngles`

Token `0x06006605`, native `0x101fa3124`.

The high-level orchestration is fully recoverable even though its child `DiagonalWalkDirection` is not yet semantically reconstructed:

1. Allocate `List<int> removeIndexes`.
2. Iterate `i` while `i < path.nodes.Count - endNodesToLeave - 1`.
3. If `DiagonalWalkDirection(path,i) != WalkDirection.None`, record `i + 1`.
4. If no indices were recorded, return the original path unchanged.
5. Otherwise clone `path.nodes` into a new list.
6. Remove recorded indices from last to first so earlier indices remain stable.
7. Assign the cloned/trimmed list back to `path.nodes`.
8. Return the same `AStarPath` object.

The descending removal order is visible directly in native list access/removal operations and is preserved.

## Child boundary

`DiagonalWalkDirection` (`0x06006614`, native `0x101fa3e1c`) remains unresolved. Ghidra's high-level decompiler process died on that function; it spans a much larger native body than the surrounding direction helpers. This does not prevent the parent smoothing algorithm from being reconstructed and verified as an orchestration method.

The next options are:

- recover `DiagonalWalkDirection` from raw ARM64 in a dedicated pass; or
- proceed into core A*/Dijkstra first if they do not depend on this helper.

## Validation

Both staged methods compile with .NET SDK `10.0.400` against minimal path/node stubs with **0 warnings, 0 errors**.
