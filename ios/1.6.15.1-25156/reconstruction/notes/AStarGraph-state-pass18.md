# AStarGraph state / bubble-grid pass 18

Target: five bounded `StardewValley.Mobile.AStarGraph` methods in iOS `1.6.15.1` build `25156`.

Source commit: `f440b04c41ab963ca84e5cefc47204fecb57e244`.

## `Init(GameLocation)`

Native address `0x101fa1424`, token `0x060065FB`.

The native method establishes the graph's core object layout and grid construction:

1. `this.gameLocation = gameLocation` (`+0x10`).
2. `map = gameLocation.map` (`+0x18`, shared `GameLocation.map` is at `+0x88`).
3. Read `map.Layers[0].LayerWidth` and `.LayerHeight`.
4. Allocate `_aStarNodeArray = new AStarNode[width,height]` at `+0x20`.
5. For every `(x,y)` instantiate `new AStarNode(this,x,y)` and store it into the array.

The iOS field offsets and the shared Linux/xTile naming agree on `map.Layers[0].LayerWidth/LayerHeight`; no public `_nodes` list insertion occurs in this method.

## `FarmerAStarNode`

Token `0x060065FD`, native `0x101fa1828`.

The method obtains `Game1.player`, reads the inherited public `Character.position : NetPosition` field, calls `NetPosition.get_X/get_Y`, divides each pixel coordinate by 64 via native multiply by `0.015625`, truncates to int, and returns `FetchAStarNode(tileX,tileY)`.

The two native callees are mapped exactly:

- `0x101b4d600` -> `StardewValley.Network.NetPosition.get_X`
- `0x101b4d714` -> `StardewValley.Network.NetPosition.get_Y`

## `FetchNeighbourNodeThatIsPassible(int x,int y)`

Token `0x060065FF`, native `0x101fa1a20`.

Probe order is exactly:

1. `(x+1,y)`
2. `(x-1,y)`
3. `(x,y+1)`
4. `(x,y-1)`

Return the first non-null node for which both `node.isTilePassable()` and `node.TileClear` are true; otherwise null.

The misspelling `Passible` is preserved from managed metadata.

## `ResetBubbles(bool one=true,bool two=false)`

Token `0x06006616`, native `0x101fa6a70`.

If `map` is null, return. Otherwise traverse `map.Layers[0]` width/height and for every `_aStarNodeArray[x,y]`:

- always set `bubbleChecked = false`;
- when `one`, set `bubbleID = -1`;
- when `two`, set `bubbleID2 = -1`.

## `mergeBubbleID2IntoBubbleID()`

Token `0x06006617`, native `0x101fa6d7c`.

Traverse the same map-sized grid. For each node:

- if `bubbleID2 == 0`, set `bubbleID = 0` and `bubbleID2 = -1`;
- always set `bubbleChecked = false`.

Unlike `ResetBubbles`, the shipped native method has no early `map == null` return; the reconstruction preserves that difference.

## Deferred nearby methods

`FarmerAStarNodeOffset` is not emitted yet because after the offset tile misses it only invokes `FetchNeighbourNodeThatIsPassible` for one specific `Game1.currentLocation` subclass. That class global still needs exact identification.

`RefreshBubbles` depends on `FarmerAStarNodeOffset`, so it remains deferred until that class guard is proven.

## Validation

The five-method staged partial class was compiled with the persisted .NET SDK `10.0.400` against minimal xTile, GameLocation, NetPosition and AStarNode stubs.

Result: **0 warnings, 0 errors**.
