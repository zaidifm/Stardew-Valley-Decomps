# AStarGraph direction-mask pass 20

Target: `AreOppositeWalkDirection` and `WalkDirectionBetweenTwoPointsWithLastDirection` in iOS `1.6.15.1` build `25156`.

Source commit: `80bbb4c6e440dcda15242496ddec608c25eabe0b`.

## `AreOppositeWalkDirection`

Token `0x0600660C`, native `0x101fa35c0`.

The shipped ARM64 uses two byte jump tables, three bit masks (`0x184`, `0x150`, `0xA8`), and a packed byte constant. Rather than preserve decompiler goto noise, the native function was reduced to its exact enum truth table.

True sets for each first argument are:

- Up -> Down, DownLeft, DownRight
- Down -> Up, UpLeft, UpRight
- Left -> Right, UpRight, DownRight
- Right -> Left, UpLeft, DownLeft
- UpLeft -> Down, Right, UpRight, DownLeft, DownRight
- UpRight -> Down, Left, UpLeft, DownLeft, DownRight
- DownLeft -> Up, Right, UpLeft, UpRight, DownRight
- DownRight -> Up, Left, UpLeft, UpRight, DownLeft

None/out-of-range first arguments return false. Out-of-range second arguments also resolve false.

The readable switch checked in for this pass was exhaustively compared against a direct translation of the ARM64 jump-table/mask flow for all enum values 0..9; the truth tables match exactly.

The broader diagonal sets are intentional: for example UpLeft treats any direction outside its compatible set `{Up, Left, UpLeft}` as opposite.

## `WalkDirectionBetweenTwoPointsWithLastDirection`

Token `0x06006613`, native `0x101fa3c84`.

The native masks decode to compatibility sets for the previous direction:

- UpLeft geometry -> last in `{None, Up, Left, UpLeft}` (`0x2B`)
- UpRight -> `{None, Up, Right, UpRight}` (`0x53`)
- DownLeft -> `{None, Down, Left, DownLeft}` (`0x8D`)
- DownRight -> `{None, Down, Right, DownRight}` (`0x115`)
- Up -> `{None, Up, UpLeft, UpRight}` (`0x63`)
- Down -> `{None, Down, DownLeft, DownRight}` (`0x185`)
- Left -> `{None, Left, UpLeft, DownLeft}` (`0xA9`)
- Right -> native table at `0x1033334DC`, values by last enum `0..8`: `4,0,0,0,4,0,4,0,4`, i.e. `{None, Right, UpRight, DownRight}`.

Diagonal candidates are evaluated first and require both axis deltas to meet `threshold`. Up/Down require only the vertical delta to meet threshold. Left/Right have no threshold check once earlier branches fail. The readable C# preserves this native ordering instead of normalizing it to the non-last-direction helper.

## Validation

Both methods compile under .NET SDK `10.0.400` with **0 warnings, 0 errors**.
