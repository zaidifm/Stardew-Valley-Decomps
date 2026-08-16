# Mono virtual-call offset resolution

Target runtime: .NET 8.0.15 / Mono source commit `50c4cb9fc31c47f03eac865d7bc518af173b74b7`, the runtime embedded in the iOS 1.6.15.1 build.

This note records how to turn native calls such as `[object->vtable + 0x3d0]` into a managed MethodDef instead of guessing from surrounding semantics.

## Runtime layout

At the exact runtime commit, `src/mono/mono/metadata/class-internals.h` defines `MonoVTable` with the dynamically extended `gpointer vtable[]` array as its final member. On ARM64, that array begins at byte offset `0x50` from the `MonoVTable` base.

Therefore a function pointer load at `MonoVTable + B` has physical virtual slot:

`slot = (B - 0x50) / 8`

For `B = 0x3d0`:

`slot = (0x3d0 - 0x50) / 8 = 112`.

## Mono assignment order

The exact `class-setup-vtable.c` first seeds `cur_slot` with the parent vtable size, then calls `mono_class_setup_interface_offsets_internal`, which reserves packed-interface slots before new class slots.

The same function gathers the class virtual methods by repeatedly calling `mono_class_get_virtual_methods` and **prepending** each result with `g_slist_prepend`. It later walks that list to assign any unclaimed non-interface slots. The practical consequence is that non-final NEW_SLOT methods are assigned in reverse metadata order.

Final NEW_SLOT interface implementations can retain the interface slot already assigned during interface setup and are therefore excluded from the later non-interface sequence.

## GameLocation prefix

`StardewValley.GameLocation` directly derives from `System.Object`, whose inherited virtual prefix has 4 slots in this runtime.

GameLocation implements interfaces contributing 10 packed virtual-method slots:

- `INetObject<NetFields>`: 1
- `IEquatable<GameLocation>`: 1
- `IAnimalLocation`: 5
- `IHaveModData`: 3

Thus the first non-interface GameLocation slot is `14`.

## TileClear virtual call

`AStarNode.TileClear` performs a virtual call through `GameLocation` at native byte offset `0x3d0`.

- physical slot: `112`
- first non-interface GameLocation slot: `14`
- class assignment index: `98`

Filtering GameLocation metadata to non-final virtual NEW_SLOT methods, reversing metadata order per Mono's setup algorithm, and selecting assignment index 98 gives:

- token: `0x06003A5A`
- method: `StardewValley.GameLocation.isTileOccupiedIgnoreFloorsAndHorse(Vector2)`

This resolves the previously anonymous top-level TileClear predicate without relying on semantic inference.

The checked-in helper `scripts/resolve_mono_vtable_offset.py` reproduces the calculation:

```text
resolve_mono_vtable_offset.py methods.tsv StardewValley.GameLocation 0x3d0 --first-non-interface-slot 14
```

It reports slot 112 / token `0x06003A5A`.

## Reuse rule

For another class, do not blindly reuse `14`. Determine its parent vtable size and packed-interface prefix first. The runtime header offset `0x50` and reverse non-final NEW_SLOT assignment rule are specific to the exact runtime/ABI recorded above and should be revalidated if the target runtime changes.
