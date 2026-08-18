# TapToMoveUtils Island North / water path helpers — pass 54

Target: iOS `1.6.15.1` build `25156`.

Source commit: `91ed92b92bf73d206cd717271458ecf47b02298e`.

## `getPathOnIslandNorthBridge` — `0x060066EB`, native `0x101FCB6CC`

Signature: `AStarPath getPathOnIslandNorthBridge(AStarGraph graph, Vector2 start, Vector2 end)`.

Only `start.X`, `start.Y`, and `end.X` are used by the native implementation.

The method creates a new `AStarPath` and adds fixed bridge-entry nodes based on exact starting Y:

- `start.Y == 41f`: add `(37,40)` and `(37,39)`;
- `start.Y == 40f`: add `(37,39)`;
- otherwise add no fixed entry nodes.

It then computes integer `horizontalDistance = (int)(end.X - start.X)`.

- Positive distance: add `(int)start.X + 1 ... +horizontalDistance`, all at Y 39.
- Negative distance: decrement from `(int)start.X - 1` for `Math.Abs(horizontalDistance)` steps, all at Y 39.
- Zero distance: no horizontal nodes.

No TileClear/null filtering is performed on nodes returned by `FetchAStarNode`; they are added directly.

## `FetchAStarNodeNearestWaterSource` — `0x06006713`, native `0x101FCEA78`

The method searches outward from `node` for a clear tile that is not itself a watering-can filling source.

At each radius it probes in this exact order:

1. `(+r,0)`
2. `(-r,0)`
3. `(0,+r)`
4. `(0,-r)`

A candidate requires non-null, `TileClear`, and `!IsWateringCanFillingSource(new Vector2(x,y))`.

Search begins at radius 1 and probes through radius **29 inclusive**, stopping after the first radius that yields at least one candidate.

No candidates => null. One candidate => index 0.

For two or more candidates, native code initializes `bestIndex = 0` and `bestDistance = float.MaxValue`, but starts its distance loop at **index 1**. Each tested candidate distance is:

`Vector2.Distance(PlayerOffsetPosition, candidate.NodeCenterOnMap)`.

Raw ARM64 proves the candidate-center construction directly: candidate x/y are shifted by 6, converted to float, `32f` is added to each coordinate, and those values are passed as the second Vector2 to the common Vector2-distance helper. Since index 0 is never distance-tested, candidate 1 necessarily becomes the first selected candidate unless its distance is NaN. This shipped asymmetry is preserved.

The selected clear land node is then converted back to the adjacent node one tile **toward the original source node**:

- if X matches source X, move selected Y one step toward source Y;
- otherwise move selected X one step toward source X and use source Y.

The resulting coordinate is passed through `aStarGraph.FetchAStarNode`.

## `FetchNearestAStarLandNodePerpendicularToWaterSource` — `0x06006714`, native `0x101FCEF58`

Signature: `(AStarGraph aStarGraph, AStarNode farmerNode, AStarNode nodeClicked)`.

Axis selection is exact:

- same X => vertical scan;
- otherwise, if Y differs, compute `abs(dx)` / `abs(dy)` and choose vertical iff `abs(dy) < abs(dx)`;
- same Y => horizontal scan.

The scan begins **at `nodeClicked` itself** and moves one tile at a time toward `farmerNode`, inclusive. A fetched node qualifies when non-null, TileClear, and not a watering-can filling source. On the first qualifying node, the method returns the **previous node**, not the qualifying node. `previous` initially equals `nodeClicked` and is replaced by each fetched node after a failed qualification test, including null.

If no scan branch returns, fallback order is:

1. `FetchAStarNodeNearestWaterSource(aStarGraph, nodeClicked)`
2. if null, `FetchAStarNodeNearestWaterSource(aStarGraph, farmerNode)`.

The `Math.Abs` use preserves the native checked overflow behavior for `int.MinValue` deltas.

## Validation

All three reconstructed methods compile in a signature-compatible .NET 10 harness.

Result: **0 warnings, 0 errors**.
