# AStarNode event-prop predicate pass 13

Target:

- `ContainsProp`, token `0x06006656`, native `0x101fad38c`

Source commit: `ecb2b33c1797e7d4a924777ab8f2f82b214a29b0`.

## Event field identity

The native method reads `Game1.CurrentEvent`, then indexes the list at Event object offset `+0x88`.

Managed metadata places:

- `Event.props : List<StardewValley.Object>`
- `Event.festivalProps : List<Prop>`

in that order. The separately recovered `ContainsFestivalProp` and native `Event.removeFestivalProps` establish `festivalProps` at `+0x90`, so `+0x88` is the immediately preceding `props` list.

## Prop location virtual call

For each `StardewValley.Object` in `CurrentEvent.props`, the native method invokes a virtual getter at `MonoVTable + 0x5f8` twice, comparing the returned floating-point X and Y lanes against node `x` and `y`.

Managed metadata contains virtual `Object.TileLocation : Vector2` (getter token `0x06003DF2`, native `0x10199a38c`). Under the exact Mono vtable assignment model, `get_TileLocation` is class assignment index 84; with Object's inherited/interface prefix this lands at the observed physical slot 181 / byte offset `0x5f8`.

The same `+0x5f8` dispatch is used on Fence/Object instances in `TapToMove.CheckToOpenClosedGate` to obtain the tile position used for distance logic, providing an independent behavioral cross-check.

## Recovered behavior

`ContainsProp` returns false with no current event. Otherwise it scans `Game1.CurrentEvent.props` and returns true on the first object whose `TileLocation.X == x` and `TileLocation.Y == y`; false otherwise.

This is deliberately distinct from `ContainsFestivalProp`, which uses `festivalProps` plus solid rectangle collision rather than exact tile-location equality.

## Validation

The reconstructed method compiles with the persisted .NET SDK `10.0.400` against minimal `Event`, `Object.TileLocation`, and `Vector2` stubs: 0 warnings, 0 errors.
