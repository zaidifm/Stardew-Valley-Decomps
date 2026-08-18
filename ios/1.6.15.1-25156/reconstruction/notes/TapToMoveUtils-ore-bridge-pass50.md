# TapToMoveUtils ore / suspension bridge — pass 50

Target: iOS `1.6.15.1` build `25156`.

Source commit: `594f8d925db8a1ffcdde7001d9d4265c185c95fb`.

## `IsOreAt` — token `0x060066E8`, native `0x101FCB4D4`

The native method reads `gameLocation +0x140`, whose object is a `NetPoint`. The same offset is used throughout iOS `GameLocation.updateOrePanAnimation` (`0x060039B4`) where the shared implementation operates on `orePanPoint`, establishing this field as `GameLocation.orePanPoint`.

Its LLVM scalar at `0x1038d7928` decodes to patch type `SFLDA`, image index 2, TypeDef `0x020001B3`, FieldDef `0x0400080A` in the matching iOS `MonoGame.Framework.dll`. Those tokens resolve to `Microsoft.Xna.Framework.Point` and private static readonly field `zeroPoint`, i.e. the backing static for `Point.Zero`.

The comparison helper is Point inequality: the method returns false when `orePanPoint.Value == Point.Zero`; otherwise it calls mapped `Utility.Distance(orePanPoint.X, orePanPoint.Y, (int)tile.X, (int)tile.Y)` and returns whether the distance is `<= 2.0`.

## `isOnOrNearSuspensionBridge` — token `0x060066E9`, native `0x101FCB604`

The method reads `Game1.player +0x438`, then reads the contained NetBool value at `+0x68`.

This field identity is proven by iOS `Farmer.SetOnBridge` (`0x0600368A`, native `0x101857F78`): that method loads Farmer `+0x438`, compares its NetBool value to the incoming boolean, writes the new value, and performs the same conditional follow-up as the current shared `SetOnBridge` source, whose field is explicitly `onBridge`.

Therefore the method is:

- if `player.onBridge.Value` is true, return true;
- otherwise y must be 39..41 inclusive;
- x below 26 returns false;
- x 26..38 returns true;
- x 39..42 returns false;
- x greater than 42 returns true.

The readable range form in the reconstruction is algebraically equivalent to the native unsigned comparisons.

## Validation

Both methods compile against a signature-compatible harness using the actual same-era MonoGame assembly.

Result: **0 warnings, 0 errors**.
