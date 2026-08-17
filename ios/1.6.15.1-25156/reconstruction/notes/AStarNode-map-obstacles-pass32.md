# AStarNode map-obstacle pass 32

Targets: `ContainsSomeKindOfWarp` and `ContainsBuilding`, iOS `1.6.15.1` build `25156`.

Source commit: `24f33954be51232cce5689e8b0bac6ff290d684a`.

## Same-era xTile calls

The owned Linux `1.6.15.24356` xTile dependency confirms the iOS framework call sequence as `Map.GetLayer("Buildings")`, `Layer.PickTile(Location,Game1.viewport.Size)`, `Tile.TileIndexProperties`, and inherited `Tile.Properties`.

## `ContainsSomeKindOfWarp`

Token `0x06006646`, native `0x101faa99c`.

The LLVM scalar decoder recovers the exact four warp strings:

- `LockedDoorWarp`
- `Warp`
- `WarpMensLocker`
- `WarpWomensLocker`

The method picks this node's Buildings-layer tile. Null tile returns false. Native then performs `tile.TileIndexProperties.TryGetValue("Passable", out ...)`; the resulting local is never consumed by the remaining native control flow, so the reconstruction retains the call while discarding its result.

The method then enumerates `tile.Properties` and converts each `PropertyValue` to string. The string comparison helper is ordinary equality, independently demonstrated by the same native helper in mobile tool/inventory name selection. Return true on the first property value exactly equal to any of the four strings above; otherwise false.

This is equality, not substring/StartsWith matching.

## `ContainsBuilding`

Token `0x06006651`, native `0x101fac0ec`.

The initial virtual call is the already-proven `GameLocation.IsBuildableLocation()`.

When true, native enumerates `gameLocation.buildings` and calls `Building.isTilePassable(new Vector2(x,y))`; return true on the first building for which that method is false, otherwise false.

When the location is not buildable, native falls back to the map rather than the building collection: pick the Buildings-layer tile at pixel `(x*64,y*64)` and return whether that tile is non-null.

This fallback is why `ContainsBuilding` cannot be replaced wholesale with `FetchBuilding() != null`; `FetchBuilding` only represents the buildable-location building collection semantics.

## Validation

Both methods compile together against the exact owned Linux `xTile.dll` / `MonoGame.Framework.dll` plus minimal Stardew stubs with .NET SDK `10.0.400`: **0 warnings, 0 errors**.
