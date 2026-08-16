# AStar neighbour enumeration / graph lookup pass 3

Targets:
- `StardewValley.Mobile.AStarNode.GetNeighbouringNodeList`
- `StardewValley.Mobile.AStarNode.GetNeighbouringNodeListFull`
- minimal `StardewValley.Mobile.AStarGraph` primitives required by that dependency edge.

Source commits:
- `5a8e108cb8c4303a18cb0008d9e9d6bddc162632` — `AStarGraph` lookup/list primitives.
- `cded72b8af1d54d806668e1a322d312b2f629bf8` — native-structure-preserving neighbour enumeration.

## AStarGraph primitives

### `FetchAStarNode(int x, int y)` — token `0x060065FC`, native `0x101fa170c`

The native method performs four bounds checks against the two-dimensional `_aStarNodeArray`:

1. `x >= 0`
2. `x < _aStarNodeArray.GetLength(0)`
3. `y >= 0`
4. `y < _aStarNodeArray.GetLength(1)`

It returns null when any check fails and otherwise returns `_aStarNodeArray[x, y]`.

### `Nodes` — token `0x06006600`, native `0x101fa1b40`

Directly returns `_nodes` at object offset `+0x28`.

### `AddNode` — token `0x06006601`, native `0x101fa1b64`

Equivalent to `_nodes.Add(node)`.

### `.ctor` — token `0x0600661D`, native `0x101fa7560`

Initializes `_nodes` to a new empty `List<AStarNode>`.

The observed object layout also places `_aStarNodeArray` at `+0x20`.

## Four-direction neighbours

`AStarNode.GetNeighbouringNodeList(bool canWalkOnTile = true)` — token `0x0600662D`, native `0x101fa7a78` — allocates a new list and probes exactly these coordinates, in this order:

1. `(x, y - 1)`
2. `(x, y + 1)`
3. `(x - 1, y)`
4. `(x + 1, y)`

For each coordinate it calls `AStarGraph.FetchAStarNode`. A non-null node is appended iff `node.TileClear == canWalkOnTile`.

## Eight-direction neighbours

`AStarNode.GetNeighbouringNodeListFull(bool canWalkOnTile = true)` — token `0x0600662E`, native `0x101fa7d94` — independently allocates a new list and repeats the four cardinal probes, then adds diagonals in this order:

5. `(x - 1, y - 1)`
6. `(x + 1, y - 1)`
7. `(x - 1, y + 1)`
8. `(x + 1, y + 1)`

It does **not** call `GetNeighbouringNodeList`; the cardinal logic is repeated in the shipped native implementation. The reconstruction preserves that structure.

An earlier intermediate source commit factored the repeated test into an invented private helper and had `Full` call the four-direction method. That was semantically equivalent but unnecessarily drifted from the managed metadata/native call structure. Commit `cded72b8...` removes that abstraction. The canonical reconstruction is the corrected version.

## Unresolved dependency boundary

This pass deliberately does not reconstruct `AStarNode.TileClear`. The two neighbour methods only require its public boolean result, whose property is already present in managed metadata. `TileClear` becomes the next dependency frontier rather than forcing unrelated tile/pathability logic into this semantic unit.

## Validation

The reconstructed graph primitives and both neighbour methods compile under the persisted .NET SDK `10.0.400` with signature-compatible stubs for unresolved types/properties. There are 0 errors. Two `CS0649` warnings are artifacts of the minimal compile harness leaving `_aStarGraph` and `_aStarNodeArray` uninitialized; the real constructors/`Init` path are outside that stripped harness.

## Next

Inspect and decompose `AStarNode.TileClear` (`0x06006635`) into its actual predicate dependencies. Pull in only the specific predicates needed to make `TileClear` readable and verified.
