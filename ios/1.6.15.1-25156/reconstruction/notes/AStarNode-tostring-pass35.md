# AStarNode ToString pass 35

Target: `AStarNode.ToString`, token `0x0600665D`, native `0x101fadb24`, iOS `1.6.15.1` build `25156`.

Source commit: `6f338b4a310dc831d6ac4462ff428651a4222f82`.

## Exact literals

LLVM AOT scalar recovery supplies:

- `AStarNode -> x:`
- `, y:`
- newline
- `layer: `
- `, tile:`
- `, tile:null\n`
- `TileIndexProperties: `
- `Properties: `
- ` = `

## Map/layer traversal

The native object chain is `_aStarGraph.map`, then `Map.Layers`. The same-era owned Linux xTile assembly confirms the collection API and `Layer.Tiles` property.

The loop is `layerIndex = 0 .. map.Layers.Count-1`. For each layer, native obtains `layer.Tiles[x,y]` through the xTile `TileArray` two-index indexer.

Null tile appends:

`layer: <index>, tile:null\n`

Non-null tile appends:

`layer: <index>, tile:<tile.ToString()>\n`

The tile ToString call uses MonoVTable physical slot2 (`+0x60`), i.e. ordinary virtual `System.Object.ToString`, allowing StaticTile/AnimatedTile overrides.

## Property collections

The first enumeration is `tile.TileIndexProperties`; each key/value pair appends:

`TileIndexProperties: <key> = <PropertyValue.ToString()>\n`

The second enumeration is inherited `tile.Properties`; each pair appends:

`Properties: <key> = <PropertyValue.ToString()>\n`

This separation is independently confirmed by the same xTile dependency source:

- `Tile.TileIndexProperties => TileSheet.TileIndexProperties[TileIndex]`
- `Component.Properties => m_propertyCollection`

The key/value enumerator shape in ARM64 is the same `KeyValuePair<string,PropertyValue>` structure used elsewhere in recovered xTile-dependent methods.

## Validation

The staged method compiles under .NET SDK `10.0.400` while referencing the exact owned Linux `xTile.dll` and `MonoGame.Framework.dll`: 0 errors. The sole warning in the stripped harness is the expected uninitialized `_aStarGraph` field.
