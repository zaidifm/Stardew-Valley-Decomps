# AStarNode DebugIsTilePassable pass 36

Target: `StardewValley.Mobile.AStarNode.DebugIsTilePassable`, token `0x06006645`, native `0x101fa9a74` in iOS `1.6.15.1` build `25156`.

Source commit: `a408a6da456d2fa4d58ef4892aa6b2501bfd33d5`.

This is the final managed method in `AStarNode` to be reconstructed.

## Exact literal recovery

The checked-in LLVM AOT scalar decoder resolves all diagnostic and map-property strings used by this function. The relevant literals include:

- `Back`, `Buildings`
- `Passable`, `Shadow`, `Water`, `WaterSource`
- `AStarNode.DebugIsTilePassable (` and the A/B/C/D/E/F/G/H diagnostic fragments
- `Null`
- ` => `

No diagnostic text was guessed from control flow.

## xTile/API identities

The same-era owned Linux `xTile.dll` decompile and the iOS native call structure establish:

- `Map.GetLayer(string)`
- `Layer.PickTile(Location, Size)`
- `Tile.TileIndexProperties`
- inherited `Tile.Properties`
- `IPropertyCollection.TryGetValue`
- property enumeration as `KeyValuePair<string, PropertyValue>`

The node probes pixel position `(x << 6, y << 6)` with `Game1.viewport.Size`, matching the ARM64.

## Reconstructed control flow

1. Log the node coordinates and result of mobile `AStarNode.isTilePassable()`.
2. Pick the Back-layer tile.
   - null -> log A and return false.
   - Back TileIndexProperties `Passable` present -> log B and return false.
3. Pick the Buildings-layer tile.
   - if present, read its TileIndexProperties `Passable`, log C plus `IsBuildingPassable()`, dump both TileIndexProperties and direct Properties, and test TileIndexProperties `Shadow`.
   - return true iff Buildings TileIndexProperties contains `Passable` or `Shadow`.
4. If no Buildings tile, reject/log Back TileIndexProperties `Water` (D) and then `WaterSource` (E).
5. Compare mobile `isTilePassable()` with mapped `GameLocation.isTilePassable(Vector2)` token `0x060039E3`, native `0x1018d3064`.
   - if equal, return true.
6. If the two passability implementations disagree, re-pick Back and Buildings tiles, log G/H state, and use the shipped discrepancy fallback:
   - any Back `Passable` property or non-null Buildings tile -> false;
   - otherwise return whether the Back tile exists.

The discrepancy fallback is intentionally preserved rather than simplified to either passability result.

## Shared-reference cross-check

Current Linux `GameLocation.isTilePassable(Vector2)` is used only to name and understand the shared reference implementation. It checks:

- Back tile with TileIndexProperties `Passable` -> false;
- Buildings tile lacking both `Shadow` and `Passable` -> false;
- otherwise true.

The iOS diagnostic routine explicitly compares the mobile implementation against this location-level result but has its own additional diagnostic branches and return logic.

## Validation

The reconstructed method was compiled with .NET SDK `10.0.400` against the **actual owned Linux 1.6.15.24356 `xTile.dll` and `MonoGame.Framework.dll`**, with signature-compatible Stardew stubs.

Result: **0 warnings, 0 errors**.

## Result

`AStarNode` is now 64/64 managed methods reconstructed. The only remaining method in the AStar pilot is `AStarGraph.DiagonalWalkDirection`.
