# AStarNode chest predicate pass 9

Targets:

- `ContainsChest`, token `0x0600664E`, native `0x101fabde4`
- `FetchChest`, token `0x0600664F`, native `0x101fabed8`

Source commit: `c2b0d53b9de7c7b117fc923e9af0a05f0e3b8faa`.

Both native methods read `gameLocation.objects` and call native `0x101b560e8`, which the all-AOT map resolves exactly to `StardewValley.Network.OverlaidDictionary.TryGetValue`, token `0x06004CE5`.

The key passed to the lookup is `new Vector2(x, y)`.

`ContainsChest` returns true iff the lookup succeeds and the returned object is a `StardewValley.Objects.Chest`.

`FetchChest` returns the looked-up object cast as `Chest`, or null if the key is absent or the object is a different type.

The reconstruction preserves the direct dictionary lookup rather than routing through the separately recovered `FetchObject`, because the shipped native methods call `TryGetValue` themselves.

## Validation

The two methods were compiled with the persisted .NET SDK `10.0.400` against signature-compatible `GameLocation.objects`, `Object`, `Chest`, and `Vector2` stubs.

Result: 0 errors. One `CS0649` warning is solely the stripped harness leaving `_aStarGraph` uninitialized.
