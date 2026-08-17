# AStarNode building retrieval pass 11

Target completed:

- `FetchBuilding`, token `0x06006652`, native `0x101fac468`

Source commit: `e9ef95e77c17cb44e69883376579bd3b4528f35e`.

## GameLocation virtual guard

The native method dispatches through `GameLocation`'s Mono vtable at byte offset `0x510` with no managed arguments and a boolean result.

Using the checked-in exact-runtime vtable model:

- ARM64 `MonoVTable.vtable[]` header = `0x50`
- physical slot = `(0x510 - 0x50) / 8 = 152`
- GameLocation first non-interface slot = 14
- class assignment index = 138

Reverse metadata assignment resolves this exactly to token `0x060039E0`:

`GameLocation.IsBuildableLocation()`

## Building virtual call

For buildable locations the method iterates `GameLocation.buildings` and invokes each building through vtable offset `0x100`, passing the node tile as two floating-point lanes.

`Building` directly implements `INetObject<NetFields>` and `IHaveModData`; together with the four inherited `System.Object` slots its first non-interface slot is 8. Under the same Mono assignment model, byte offset `0x100` resolves to token `0x06005B86`:

`Building.isTilePassable(Vector2)`

This is cross-checked by direct ARM64:

- `Building.occupiesTile(Vector2,bool)` at `0x101da1d48` dispatches the integer overload at vtable `+0x108`;
- the adjacent `isTilePassable(Vector2)` implementation is mapped at `0x101da1ef8`, consistent with `+0x100` being the preceding virtual slot.

## Recovered method

`FetchBuilding` therefore:

1. returns null when `!gameLocation.IsBuildableLocation()`;
2. iterates `gameLocation.buildings`;
3. returns the first building for which `!building.isTilePassable(new Vector2(x,y))`;
4. returns null if no building blocks the tile.

The mobile method uses passability rather than a raw footprint test, so passable building tiles deliberately do not count.

## Related methods deliberately not emitted yet

`ContainsBuilding` has the same buildable-location loop, but on non-buildable locations it falls back to the map's `Buildings` layer using xTile layer/pixel lookup helpers. That fallback is retained as unresolved until the generic xTile calls and layer string are pinned exactly.

`IsBuildingPassable` also depends on xTile layer properties and several AOT-managed strings. It remains triaged rather than guessed.

## Validation

The emitted `FetchBuilding` method compiles under the persisted .NET SDK `10.0.400` with signature-compatible minimal stubs: 0 errors. One `CS0649` warning is solely the stripped harness leaving `_aStarGraph` uninitialized.
