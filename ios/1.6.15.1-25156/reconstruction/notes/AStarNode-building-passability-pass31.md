# AStarNode building-passability pass 31

Target: `IsBuildingPassable`, token `0x06006644`, native `0x101fa9754`, iOS `1.6.15.1` build `25156`.

Source commit: `616bd1fa63c48ba6d43090ac90f9960b867c6a1b`.

## Same-era xTile dependency oracle

The owned Linux `1.6.15.24356` distribution was used to extract its matching `xTile.dll`, then decompiled with the persisted ILSpy 11.0.0.9375 toolchain. This resolves the framework methods used by the iOS AOT body without relying on older public xTile versions:

- `Map.GetLayer(string)`
- `Layer.PickTile(Location, Size)`
- `Tile.TileIndexProperties`
- inherited virtual `Component.Properties`
- `IPropertyCollection.TryGetValue(string,out PropertyValue)`
- `PropertyValue.ToString()`

The iOS native calls and virtual dispatches line up with those exact APIs.

## Recovered literals

LLVM AOT scalar decoding supplies:

- `Buildings`
- `Passable`
- `t`
- `true`
- `Shadow`

## Predicate

1. `map.GetLayer("Buildings").PickTile(new Location(x*64,y*64), Game1.viewport.Size)`.
2. Null tile -> false.
3. If `tile.TileIndexProperties["Passable"]` exists, convert its PropertyValue to string and lowercase it; `t` or `true` -> true.
4. Apply the same `t` / `true` test to `tile.Properties["Passable"]`.
5. Otherwise return whether `tile.TileIndexProperties` contains `Shadow`.

The tile-index property collection is the nonvirtual xTile `Tile.get_TileIndexProperties` helper; direct per-tile properties use the inherited virtual `Component.Properties` accessor. This distinction is visible in the AOT call structure and preserved.

## Validation

The staged method compiles with .NET SDK `10.0.400` while referencing the exact owned Linux `xTile.dll` and `MonoGame.Framework.dll` dependencies plus minimal Stardew stubs: **0 warnings, 0 errors**.
