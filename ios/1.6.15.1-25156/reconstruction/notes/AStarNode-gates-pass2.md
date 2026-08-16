# AStarNode gate/object reconstruction pass 2

Target: tile geometry aliases plus the object/fence/gate predicate chain in `StardewValley.Mobile.AStarNode`, iOS `1.6.15.1` build `25156`.

Source commits:
- `a61cf67b52dbe551419ce69f9c0b3cc75c4b06a6` — geometry/alias methods.
- `13f9ec78a04195a5e6b05db7c4f7d619f468aec5` — object/fence/gate methods.

## Geometry aliases

`GetBoundingBox`, lowercase `rect`, and the earlier `rectangle` property all independently construct the same 64x64 tile rectangle at `(x << 6, y << 6)`. Lowercase `fakeTileClear` is a direct read of the same `_fakeTileClear` byte used by `FakeTileClear`.

## Resolved native callees

The global managed-to-native AOT map identifies two repeated anonymous callees in this slice:

- `0x101b55e1c` -> `StardewValley.Network.OverlaidDictionary.ContainsKey`
- `0x101b547f0` -> `StardewValley.Network.OverlaidDictionary.get_Item`

The map also identifies:

- `0x101995778` -> `StardewValley.Fence.get_isSoloGate`

This turns the apparent native helper chain into ordinary managed tile-object lookup semantics. The reconstructed lookup key is `new Vector2(x, y)`.

## Verified methods

### `isFence`

Returns true exactly when `gameLocation.objects` contains this tile and the object at that key is a `Fence`.

### `isGate`

Returns true when the tile object is a `Fence`, `fence.isGate.Value` is true, and `fence.isSoloGate` is false.

The `isSoloGate` exclusion is observable in the native method as an actual call to `Fence.get_isSoloGate`; it is not a readability invention.

### `isGateOpen`

Uses the same non-solo gate predicate, then tests the underlying `gatePosition` value against `0x58` / `88`, which is the iOS `Fence.gateOpenedPosition` constant.

### `FetchObject`

If `gameLocation.objects.ContainsKey(tile)` is true, returns the dictionary indexer value; otherwise null.

### `ContainsGate`

Returns true for any tile object that is a `Fence` with `fence.isGate.Value == true`. Unlike lowercase `isGate()`, this method does **not** exclude `isSoloGate`.

### `FetchGate`

Returns the tile `Fence` when its `isGate.Value` is true; otherwise null. As with `ContainsGate`, there is no `isSoloGate` exclusion.

That distinction is important and is preserved deliberately in the staged C#.

## Cross-checks

The current Linux `1.6.15.24356` source confirms the relevant shared infrastructure names and shapes:

- `GameLocation.objects` is a `StardewValley.Network.OverlaidDictionary` keyed by `Vector2`.
- `Fence.isGate` is a `NetBool`.
- `Fence.gatePosition` is a `NetInt`.
- `Fence.gateOpenedPosition` is the constant `88`.

Linux is used here only to resolve shared type/member semantics; the mobile predicate behavior is established from the iOS native implementations.

## Validation

The current staged `AStarNode.cs`, including this pass, was compiled with the persisted .NET SDK `10.0.400` against minimal signature-compatible stubs for `GameLocation`, `OverlaidDictionary`, `Fence`, `AStarGraph`, `Rectangle`, and `Vector2`.

Result: 0 warnings, 0 errors.

## Next

The next bounded slice should tackle `GetNeighbouringNodeList` / `GetNeighbouringNodeListFull` and only the `AStarGraph` primitives those methods actually require. That is the first place where the pilot expands from local predicates into a real dependency neighborhood.
