# TapToMoveUtils direction/geometry helpers pass 44

Targets:

- `ConvertWalkDirection` token `0x060066DC`, native `0x101fca120`
- `WalkDirectionForAngle` token `0x060066DD`, native `0x101fca144`
- `WalkDirectionForAngleJustDiagonals` token `0x060066DE`, native `0x101fca258`
- `FaceDirectionForAngle` token `0x060066DF`, native `0x101fca2c0`
- `WalkDirectionsAgree` token `0x060066E0`, native `0x101fca330`
- `GetWalkDirectionFacing` token `0x06006710`, native `0x101fce8f8`
- `GetDirectionFacing` token `0x06006711`, native `0x101fce9a4`
- `FetchNextPointOut` token `0x06006712`, native `0x101fcea50`

Source commit: `6e69f3c1f57bd475f78fa0968edea67c88df79ce`.

## ConvertWalkDirection

The native method indexes a four-int constant table at Mach-O VM `0x103333ef0`. Reading that table directly gives:

`[0, 2, 3, 1]`

for WalkDirection enum values Up/Down/Left/Right (1..4). Therefore:

- Up -> face direction 0
- Down -> 2
- Left -> 3
- Right -> 1
- None/diagonals/out-of-range -> -1

No direction mapping was inferred from names alone.

## Degree-based WalkDirection sectors

`WalkDirectionForAngle` uses exact 22.5-degree octants:

- [-22.5,22.5) Right
- [22.5,67.5) DownRight
- [67.5,112.5) Down
- [112.5,157.5) DownLeft
- [-157.5,-112.5) UpLeft
- [-112.5,-67.5) Up
- [-67.5,-22.5) UpRight
- otherwise Left

The native floating comparisons naturally send NaN to the final Left case; the readable if-chain preserves that outcome.

`WalkDirectionForAngleJustDiagonals` preserves its asymmetric boundaries:

- [0,90) DownRight
- [90,180] DownLeft
- [-180,-90] UpLeft
- all remaining values, including (-90,0), out-of-domain values, and NaN -> UpRight

## FaceDirectionForAngle

Exact degree sectors from ARM64/Ghidra conditions:

- (-135,-45] -> 0 (Up)
- (-45,45) -> 1 (Right)
- [45,135] -> 2 (Down)
- otherwise -> 3 (Left)

The exact boundary assignment at -45/45/135 is retained.

## WalkDirectionsAgree

Native bitmasks decode to shared-cardinal-component agreement:

- Up agrees with Up / UpLeft / UpRight
- Down with Down / DownLeft / DownRight
- Left with Left / UpLeft / DownLeft
- Right with Right / UpRight / DownRight
- UpLeft with Up / Left / UpLeft
- UpRight with Up / Right / UpRight
- DownLeft with Down / Left / DownLeft
- DownRight with Down / Right / DownRight
- None/default never agrees

The UpLeft native case is emitted as `param2 < 6 & param2`; evaluating the enum bits gives precisely Up(1), Left(3), UpLeft(5).

## Radian-based facing helpers

Both methods call the same external `atan2` helper with Y difference then X difference. The Mach-O constants were read directly as doubles:

- `0x103333c70` = -pi/4
- `0x103333c78` = +pi/4
- `0x103333c80` = +3pi/4
- `0x103333c88` = -3pi/4

`GetWalkDirectionFacing(monsterPosition,farmerPosition)` returns cardinal WalkDirection:

- [-pi/4,+pi/4] Right
- (+pi/4,+3pi/4] Down
- [-3pi/4,-pi/4) Up
- otherwise Left

`GetDirectionFacing(targetPosition,startPosition)` uses the same sectors but returns Stardew facing ints 1/2/0/3.

## FetchNextPointOut

The native arithmetic starts from `(endX,endY)` and independently moves each coordinate one unit toward `(startX,startY)`:

- if endX < startX, increment X
- if startX < endX, decrement X
- same for Y

The method name is slightly misleading; the shipped result is one component-wise step from the end point back toward the start point.

## Validation

All eight helpers compile together with .NET SDK 10.0.400 against the actual MonoGame.Framework.dll for Vector2/Point.

Result: **0 warnings, 0 errors**.

## Result

TapToMoveUtils semantic reconstruction reaches **40/84 methods**.

Next inventory choices should continue favoring low-body-size/high-locality groups before expensive warp/furniture/building integration helpers.
