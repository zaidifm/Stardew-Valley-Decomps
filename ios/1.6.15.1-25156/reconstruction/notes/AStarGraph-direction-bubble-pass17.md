# AStarGraph direction / bubble helper pass 17

Target: 16 bounded `StardewValley.Mobile.AStarGraph` methods in iOS `1.6.15.1` build `25156`.

Source commit: `0de7f431a06d1c1f1787c80319281451953e094d`.

All methods in this pass are reconstructed directly from their mapped ARM64 implementations. No Linux implementation counterpart exists for this mobile-only class.

## Distance distinction

The class contains two similarly named methods with different behavior:

- `0x06006606 Distance(int x1,int y1,int x2,int y2)` at `0x101fa33c4` returns **squared Euclidean distance** as `float`: `(x1-x2)^2 + (y1-y2)^2`. Direct ARM64 uses SIMD subtraction, integer-to-double conversion, square/multiply, horizontal add, then converts the sum to `float`. There is no square root.
- `0x06006619 distance(int x1,int x2,int y1,int y2)` at `0x101fa7310` returns **true Euclidean distance** as `double`: `sqrt((x1-x2)^2 + (y1-y2)^2)`.

The argument order difference is preserved from managed metadata.

## Adjacency / equality

- `IsNeighbouringNode`: accepts any of the 8 surrounding cells, excludes the same coordinate, null-safe false.
- `IsNeighbouringNodeNoDiagonals`: exact N/S/E/W adjacency, null-safe false.
- `IsNeighbouringNodeOnDiagonal`: exact four diagonal neighbours, null-safe false.
- `IsSameNode`: coordinate equality, null-safe false.

## Direction lookup and geometry

`OppositeWalkDirection` is backed by the native lookup table at `0x103333500`. Its 1..8 values are exactly:

`2, 1, 4, 3, 8, 7, 6, 5`

Thus Up/Down, Left/Right, UpLeft/DownRight and UpRight/DownLeft are pairs; invalid/None returns None.

`walkingDirectionToStardewDirection` is valid only for cardinal directions 1..4. The native table at `0x103333ef0` begins `0,2,3,1`; the native bounds condition returns `-1` outside 1..4. Therefore:

- Up -> 0
- Down -> 2
- Left -> 3
- Right -> 1
- None/diagonals/other -> -1

## Direction methods

Recovered and emitted without abstraction changes:

- `WalkDirectionToNextNode`
- `WalkDirectionBetweenNodes`
- `WalkDirectionBetweenTwoPoints`
- `WalkDirectionBetweenTwoPointsNoDiagonals`
- `WalkDirectionBetweenTwoNodes`
- `WalkDirectionBetweenTwoTiles`

Notable shipped behavior: `WalkDirectionBetweenTwoTiles` falls through to its vertical/horizontal dominance rule when both points are within the 32-pixel dead-zone; identical points therefore return `Down`, because `abs(dx) <= abs(dy)` and `dy < 0` is false. The reconstruction preserves this native result instead of replacing it with a more intuitive None.

`WalkDirectionBetweenTwoNodes` intentionally has no explicit null guard; dereferencing a null input produces the same managed failure behavior represented by the AOT null path.

## Bubble-aware path checks

### `PathBetweenNodesExists`

- Same `bubbleID` -> true.
- Otherwise end must have `bubbleID == -1` and `fakeTileClear == true`.
- Then inspect end's four cardinal neighbours in order west, east, north, south; true if any has the start node's `bubbleID`.

### `GetShortestPathAStarWithBubbleCheck`

- null start/end -> null.
- If end bubble is nonzero, set start bubble to zero.
- If end bubble is already assigned (`!= -1`) **or** `PathBetweenNodesExists` is false, reset secondary bubbles, flood from end with secondary bubble IDs, reject when start/end `bubbleID2` differ, then merge bubble2 into bubble1.
- Finally call `GetShortestPathAStar(start,end)`.

The wrapper is emitted now even though `ResetBubbles`, `mergeBubbleID2IntoBubbleID`, and core A* are separate reconstruction units; their managed method boundaries are already known and remain explicit dependencies.

## Deferred neighbours in the same method region

This pass deliberately does not emit:

- `AreOppositeWalkDirection` (`0x0600660C`), whose compiled switch/bitmask shape should be reduced to an exact truth table first.
- `WalkDirectionBetweenTwoPointsWithLastDirection` (`0x06006613`), which uses several direction-allowance masks and a lookup table.
- `DiagonalWalkDirection` (`0x06006614`), whose high-level Ghidra decompile failed.

## Validation

The staged 16-method partial class was compiled under the persisted .NET SDK `10.0.400` against minimal signature-compatible stubs for unresolved AStar methods/types.

Result: **0 warnings, 0 errors**.
