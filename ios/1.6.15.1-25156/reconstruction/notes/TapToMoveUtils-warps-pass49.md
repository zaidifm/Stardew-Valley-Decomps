# TapToMoveUtils warp cluster — pass 49

Target: iOS `1.6.15.1` build `25156`.

Source commit: `ac62fb1b8218523eedcb54ae46c274931ff2d224`.

## `InWarpRange` — `0x060066D7`, native `0x101FC95FC`

The raw ARM64 preserves the incoming `Vector2 clickPoint` in `s0/s1`, rejects immediately when `gameLocation.ignoreWarps` is set, then scans `gameLocation.warps`.

For each warp it computes `warpPosition = (warp.X*64, warp.Y*64)`. The first distance is from `warpPosition + (32,32)` to `clickPoint`; the second is from `warpPosition` to `Game1.player.Position`. Both must be strictly less than `WarpRange`.

## `NodeIsWarp` — `0x060066D8`, native `0x101FC9850`

Null node or `ignoreWarps` => false. The node center is `(x*64+32, y*64+32)`. The method returns true when any warp's top-left pixel position `(warp.X*64, warp.Y*64)` is within `WarpRange` of that node center.

## `WarpIfInRange` — `0x060066D9`, native `0x101FC9A6C`

The method requires `!gameLocation.ignoreWarps` and `Game1.player.CanMove`.

`Farmer +0x76c` is proven to be `CanMove`: native `Farmer.get_CanMove` (`0x06003598`, `0x10183912C`) is a direct byte load from `+0x76c`.

For each source warp:

- source target `"VolcanoEntrance"` constructs a temporary warp with the same source/target coordinates but exact target `"VolcanoDungeon0"`, `flipFarmer=false`, `npcOnly=false`;
- click distance is from the candidate warp center to the incoming click point;
- player distance is from the candidate warp top-left to `Game1.player.Position`;
- source target `"IslandSouthEast"` has an IslandSouth guard: if the current location is `IslandSouth`, `westernTurtleMoved.Value` is false, and player distance is greater than `125f`, the method returns false immediately;
- if current location is `BusStop` and source target is `"Desert"`, that warp is skipped;
- otherwise both distances must be `< WarpRange`, after which `Game1.player.warpFarmer(candidateWarp, -1)` is called and true is returned.

The two opaque class globals were decoded through the LLVM AOT patch domain:

- `0x1038c6d20` -> TypeDef `0x020005F9` -> `StardewValley.Locations.IslandSouth`;
- `0x1038c6ba8` -> TypeDef `0x020005DF` -> `StardewValley.Locations.BusStop`.

`IslandSouth +0x358` is `westernTurtleMoved`. The same offset is read by iOS `IslandSouth.isCollidingPosition`, matching the shared source branch `!westernTurtleMoved.Value && position.Intersects(turtle2Spot)`.

## `NpcAtWarpOrDoor` — `0x060066DB`, native `0x101FC9F28`

First checks mapped `GameLocation.isCollidingWithWarp(npc.GetBoundingBox(), npc)` and returns true on a warp collision.

Otherwise it gets the `"Buildings"` layer, offsets `npc.StandingPixel` exactly one 64-pixel tile in `npc.getDirection()` (0 up, 1 right, 2 down, 3 left; invalid direction falls back to zero), uses `Layer.PickTile(..., Game1.viewport.Size)`, then tests the picked tile's direct `Properties` for exact key `"Action"`. The return value is whether the out `PropertyValue` is non-null.

Mapped anchors include `GameLocation.isCollidingWithWarp` at `0x1018CBF34` and `Character.getDirection` at `0x101795614`. `"Buildings"` and `"Action"` are exact recovered LLVM LDSTR literals.

## Validation

The staged four-method source was compiled against a signature-compatible harness plus the actual owned same-era `xTile.dll` and `MonoGame.Framework.dll`.

Result: **0 warnings, 0 errors**.
