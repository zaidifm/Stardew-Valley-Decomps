# AStarGraph Dijkstra pass 23

Target: `StardewValley.Mobile.AStarGraph.GetShortestPathDijkstra`, token `0x06006602`, native `0x101fa1c4c`, iOS `1.6.15.1` build `25156`.

Source commit: `cfca0085cddc038778a39bc0da7060fe5fa18cf0`.

## Null and trivial-path behavior

The native null path passes target-corelib type token `0x0200006A` to the exception helper. In the exact iOS `System.Private.CoreLib.dll`, that TypeDef is `System.ArgumentNullException`. No argument-name string is materialized, so the reconstruction throws `new ArgumentNullException()` when either start or end is null.

If `startNode == endNode`, the method adds the single start node to `path.nodes` and returns immediately. It does **not** call `Bake()` on this fast path.

## Compiler-generated ordering lambda

The nested display class metadata is intact:

- `StardewValley.Mobile.AStarGraph+<>c__DisplayClass14_0.distances` is `Dictionary<AStarNode,float>`.
- `<>9__0` is `Func<AStarNode,float>`.
- `<GetShortestPathDijkstra>b__0` has signature `float (AStarNode)`.

Its native body reads the captured `distances` field and returns `distances[node]`. This proves the queue ordering expression is equivalent to:

`unvisited.OrderBy(node => distances[node]).ToList()`.

The native code caches the delegate in the display class, matching ordinary compiler-generated lambda caching.

## Initialization

The nontrivial path allocates:

- `List<AStarNode> unvisited`
- `Dictionary<AStarNode,AStarNode> previous`
- `Dictionary<AStarNode,float> distances`

It iterates graph `_nodes`, adds every node to `unvisited`, and initializes `distances[node] = float.MaxValue` (`0x7f7fffff`). Then `distances[startNode] = 0f`.

## Main loop

While unvisited is nonempty:

1. replace it with a list ordered by `distances[node]`;
2. select index zero as current;
3. remove current from unvisited;
4. if current is end, reconstruct the path through `previous`;
5. otherwise enumerate `current.GetNeighbouringNodeList(true)`.

For each neighbour:

`alternate = distances[current] + (current.x-neighbour.x)^2 + (current.y-neighbour.y)^2`

If `alternate < distances[neighbour]`, update the distance and set `previous[neighbour] = current`.

The squared-distance edge expression is inlined in ARM64. With the four-direction neighbour list it is normally 1, but the reconstruction preserves the actual arithmetic rather than replacing it with a constant.

There is no explicit `unvisited.Contains(neighbour)` gate before relaxation. Positive edge costs make updates to already-finalized nodes non-improving in ordinary cases, but the shipped implementation simply performs the dictionary comparison.

## Path reconstruction and Bake

When current reaches the end:

- while `previous.ContainsKey(endNode)`, insert endNode at index zero and replace endNode with `previous[endNode]`;
- insert the final node at index zero.

The resulting Dijkstra path therefore includes both the original start and end nodes, unlike `RetracePath` used by core A*, which excludes start.

At the common return tail, native dispatches through AStarPath vtable offset `+0x70`. With MonoVTable header `0x50`, this is physical slot 4. AStarPath's non-final NEW_SLOT virtual methods are assigned in Mono's reverse metadata-order pass; slot 4 is `Bake` (metadata token `0x06006661`). Thus normal Dijkstra return calls `path.Bake()`.

If the unvisited queue exhausts without reaching the end, the empty/partial path is still baked and returned rather than returning null.

## Validation

The reconstructed method was compiled with .NET SDK `10.0.400` against minimal AStarPath/AStarNode stubs with LINQ enabled.

Result: **0 warnings, 0 errors**.
