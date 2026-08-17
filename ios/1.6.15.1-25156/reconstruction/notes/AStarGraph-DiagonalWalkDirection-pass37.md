# AStarGraph DiagonalWalkDirection pass 37

Target: `StardewValley.Mobile.AStarGraph.DiagonalWalkDirection(AStarPath,int)`, token `0x06006614`, native `0x101fa3e1c`, iOS `1.6.15.1` build `25156`.

Source commit: `c5d77351b3285291a4ba5afee50c71ad2164c3c6`.

This was the final unreconstructed managed method in the AStarPath/AStarNode/AStarGraph pilot. Ghidra's high-level decompiler died on the method; recovery therefore used the complete persisted ARM64 body directly.

## Native body shape

Raw ARM64 range: approximately `0x101fa3e1c..0x101fa69b0`, 2,795 disassembly lines / ~11 KB code.

The apparent size is mostly generated overhead:

- repeated virtual `path.nodes` getter calls;
- repeated `List<AStarNode>` bounds checks and array element loads;
- repeated `AStarNode.GetNeighbouringNodeList(true)` calls, each of which constructs a fresh list;
- safepoint checks;
- shared exception/throw stubs for list bounds/null failures.

There are exactly **20 direct calls** to native `AStarNode.GetNeighbouringNodeList(true)` at `0x101fa7a78`: five calls in each of four structurally equivalent diagonal blocks.

## Managed signature / enum

Managed metadata gives:

`private WalkDirection DiagonalWalkDirection(AStarPath path, int i)`

The target enum values are:

- `None = 0`
- `Up = 1`
- `Down = 2`
- `Left = 3`
- `Right = 4`
- `UpLeft = 5`
- `UpRight = 6`
- `DownLeft = 7`
- `DownRight = 8`

The four native return blocks independently encode these diagonal values:

- `0x101fa5680`: if match count == 2, return 7 (`DownLeft`), else 0.
- `0x101fa5690`: if match count == 2, return 8 (`DownRight`), else 0.
- `0x101fa56a0`: if match count == 2, return 5 (`UpLeft`), else 0.
- `0x101fa56b0`: if match count == 2, return 6 (`UpRight`), else 0.

The common default at `0x101fa5660` returns zero / `WalkDirection.None`.

## Reduced semantics

Let:

- `A = path.nodes[i]`
- `B = path.nodes[i + 1]`
- `C = path.nodes[i + 2]`

The function recognizes four possible right-angle path triples.

### DownLeft

Geometry gate:

- B is either `(A.x - 1, A.y)` or `(A.x, A.y + 1)`; and
- C is `(A.x - 1, A.y + 1)`.

Then scan `A.GetNeighbouringNodeList(true)`. Increment the local counter for a neighbour at either orthogonal corner cell:

- `(A.x - 1, A.y)`; or
- `(A.x, A.y + 1)`.

Return `DownLeft` iff the counter reaches exactly 2.

### DownRight

- B is right or down from A;
- C is `(A.x + 1, A.y + 1)`;
- count passable neighbours right and down;
- return `DownRight` iff count == 2.

### UpLeft

- B is left or up from A;
- C is `(A.x - 1, A.y - 1)`;
- count passable neighbours left and up;
- return `UpLeft` iff count == 2.

### UpRight

- B is right or up from A;
- C is `(A.x + 1, A.y - 1)`;
- count passable neighbours right and up;
- return `UpRight` iff count == 2.

Otherwise return `None`.

In plain terms, the method permits `SmoothRightAngles` to remove the middle node of a cardinal L-turn only when the start/end nodes are diagonally adjacent **and both orthogonal cells around that corner are passable**. It returns which diagonal the smoothed segment represents.

## Why the staged C# intentionally looks repetitive

The native code repeatedly invokes both the virtual `path.nodes` getter and `GetNeighbouringNodeList(true)` rather than caching either result. The staged reconstruction preserves that repeated access structure instead of introducing a helper or precomputing the neighbour list. This follows the project's reconstruction discipline and matches the observable call structure of the shipped method.

## Validation

A minimal signature-compatible C# harness containing the exact reduced source was compiled with the persisted .NET SDK `10.0.400`.

Result: **0 warnings, 0 errors**.

The reduction was also cross-checked structurally against the full raw ARM64:

- four geometry blocks;
- four neighbour-scan loops;
- five direct `GetNeighbouringNodeList(true)` calls per loop body/control cycle pattern;
- four match-count return blocks with enum values 7, 8, 5, 6;
- common zero return.

## Result

With this method emitted, the bounded AStar pilot is **108/108 managed methods reconstructed**:

- AStarPath 9/9
- AStarNode 64/64
- AStarGraph 35/35

The next subsystem frontier is `TapToMoveUtils`, beginning with `TapToMoveUtils.IsTilePassable`, which is already a direct dependency of the completed AStarNode `isTilePassable()` wrapper.
