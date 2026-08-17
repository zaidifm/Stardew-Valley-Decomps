# TapToMoveUtils player/warp geometry pass 48

Targets:

- `get_PlayerOffsetPosition` token `0x060066D5`, native `0x101fc9448`
- `get_PlayerPositionOnScreen` token `0x060066D6`, native `0x101fc94e4`
- `get_WarpRange` token `0x060066DA`, native `0x101fc9e60`

Source commit: `a0c24242a9cf0fb574b2fff966b0295a2abbcb6e`.

## PlayerOffsetPosition

Raw ARM64 was inspected directly rather than relying on a truncated Ghidra expression. The method reads the player's NetPosition X and Y values, adds `32f` to **both** scalar lanes, constructs/returns a Vector2.

Therefore:

`new Vector2(Game1.player.Position.X + 32f, Game1.player.Position.Y + 32f)`.

The +32 offset is the tile-center half-width used throughout the mobile tap code.

## PlayerPositionOnScreen

Raw ARM64 independently establishes both coordinates:

- X = player Position.X + 32f - Game1.viewport.X
- Y = player Position.Y + 32f - Game1.viewport.Y

The viewport scalar is read as two 32-bit integer coordinates at offsets 0 and +4, matching xTile.Dimensions.Rectangle X/Y.

## WarpRange

The native method returns only two float constants:

- `128f` (`0x43000000`)
- `96f` (`0x42c00000`)

Control flow:

1. read `Game1.currentLocation`;
2. null -> 96f;
3. if location `isOutdoors.Value` -> 128f;
4. otherwise, if location is the decoded special location class -> 128f;
5. else -> 96f.

LLVM CLASS patch scalar for the special location decodes to iOS TypeDef token `0x020005DA`, `StardewValley.Locations.BathHousePool`.

The instance field read at native GameLocation offset `+0x1A0` corresponds to `isOutdoors : NetBool` in the matching iOS object layout.

Thus the readable result is:

`currentLocation != null && (currentLocation.isOutdoors.Value || currentLocation is BathHousePool) ? 128f : 96f`.

## Validation

All three accessors were compiled with .NET SDK 10.0.400 against the actual owned `MonoGame.Framework.dll` and `xTile.dll`, with signature-compatible Game1/Farmer/GameLocation/BathHousePool stubs.

Result: **0 warnings, 0 errors**.

## Result

TapToMoveUtils reaches **60/84 reconstructed methods**.

The next natural cluster is the warp vocabulary: `InWarpRange`, `NodeIsWarp`, `WarpIfInRange`, and `NpcAtWarpOrDoor`, now that PlayerOffsetPosition and WarpRange are no longer external dependencies.
