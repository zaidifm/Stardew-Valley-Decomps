# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

This is the compact resume marker. Detailed per-method evidence belongs in `methods.tsv`, `ledger/*.tsv`, and `notes/`.

## Current checkpoint

The active pilot is the mobile-only AStar subsystem. The current Linux `1.6.15.24356` source has no `StardewValley.Mobile.AStar*`, `TapToMove*`, or `VirtualJoypad` counterpart, so this pilot is native-first rather than a Linux implementation transplant.

Native-verified reconstructed methods at this checkpoint: **47**.

One additional AStarPath method, `ToString`, is triaged but intentionally not emitted because exact AOT-managed string literals/punctuation remain unresolved.

## AStarPath

8 methods are verified/emitted.

Key result: `Distance` is squared Euclidean distance (`dx*dx + dy*dy`), not square-root distance.

Source commit: `46f602a33edf8fd6f6dea2d7cdda67d88e43ed1e`.
Evidence: `notes/AStarPath-pass1.md`.

## AStarNode

35 methods are verified/emitted so far, including:

- cost/parent/coordinate accessors and constructor;
- tile rectangle and center geometry;
- four-way and eight-way neighbour enumeration;
- gate/object lookup predicates;
- `TileClear` top-level obstacle orchestration;
- `isTilePassable` wrapper;
- travelling-cart and travelling-desert-shop predicates;
- `ContainsFestivalProp`.

Important preserved distinctions:

- lowercase `isGate()` excludes `Fence.isSoloGate`;
- `ContainsGate()` / `FetchGate()` do not;
- `ContainsTravellingCart()` performs an exact `Forest` type check;
- `ContainsTravellingDesertShop()` performs an exact `Desert` type check, so `DesertFestival : Desert` does not match;
- `ContainsFestivalProp()` scans `Game1.CurrentEvent.festivalProps` and uses the shipped `Prop.isColliding` semantics (`solid && rectangle.Intersects(boundingRect)`).

Canonical neighbour source: `cded72b8af1d54d806668e1a322d312b2f629bf8`.
TileClear orchestration source: `67918048f3993b4edce56328268d54b87e650b9a`.
Initial TileClear child predicates: `7f586bef60a509a7fc888127998c9c6a0fb995a0`.
Festival-prop predicate: `44667410d450dd5256763bf2d3b4fdbf6b55c375`.

Evidence notes:

- `notes/AStarNode-structural-pass1.md`
- `notes/AStarNode-gates-pass2.md`
- `notes/AStar-neighbours-pass3.md`
- `notes/AStarNode-TileClear-pass4.md`
- `notes/AStarNode-TilePredicates-pass5.md`

The festival-prop evidence is additionally recorded in `ledger/pass-06-festival-prop.tsv`; `Event + 0x90` was tied to `festivalProps` using the iOS native `Event.removeFestivalProps` implementation.

## AStarGraph

4 minimal graph primitives are verified/emitted:

- `FetchAStarNode`
- `Nodes`
- `AddNode`
- constructor

Source commit: `5a8e108cb8c4303a18cb0008d9e9d6bddc162632`.

## Reusable Mono virtual-call resolution

The exact embedded runtime is .NET 8.0.15 / Mono commit `50c4cb9fc31c47f03eac865d7bc518af173b74b7`.

A reusable resolver is checked in at:

`scripts/resolve_mono_vtable_offset.py`

It models the exact ARM64 MonoVTable header and class-vtable assignment order. For `GameLocation`, the native call through `MonoVTable + 0x3d0` in `AStarNode.TileClear` is proven to be:

`GameLocation.isTileOccupiedIgnoreFloorsAndHorse(Vector2)`

token `0x06003A5A`.

Evidence: `notes/Mono-vtable-resolution.md`.

## TileClear formula verified

`AStarNode.TileClear` (`0x06006635`, native `0x101fa8498`) is emitted with the observed short-circuit order:

1. `_fakeTileClear` => true.
2. Require `GameLocation.isTileOnMap(tile)`.
3. Reject `GameLocation.isTileOccupiedIgnoreFloorsAndHorse(tile)` unless `isGate()`.
4. Require `isTilePassable()`.
5. Reject stump/boulder.
6. Reject furniture.
7. Reject non-gate fence.
8. Reject impassable building.
9. Reject animals.
10. Reject NPC.
11. Reject festival prop.
12. Reject blocking bed tile.
13. Reject travelling cart.
14. Reject travelling desert shop.
15. Reject broken festival tile.
16. Reject cinema.
17. Require `!ContainsParrotExpress()`.

The child predicates can be reconstructed independently without reopening this top-level logic.

## Ledger/checkpoint structure

`methods.tsv` is the periodically consolidated base ledger. New small passes are appended under `ledger/*.tsv`; the logical ledger is the union of both. `scripts/check_reconstruction_ledger.py` validates the combined set and rejects duplicate method keys. This avoids rewriting the entire growing TSV for every one-method checkpoint through the GitHub contents API.

## Current dependency frontier

Prefer predicates whose native behavior can be completed without inventing managed string constants:

1. `isBlockingBedTile` (`0x0600663C`, native `0x101fa8f0c`): `BedFurniture.GetBedAtTile` is already mapped, but a BedFurniture virtual call at `MonoVTable + 0x660` still needs exact slot resolution.
2. `TapToMoveUtils.IsTilePassable` (`0x060066EE`): reconstruct once its own dependency fan-out is bounded.
3. Continue the remaining `TileClear` children with bounded, evidence-first passes (`ContainsStumpOrBoulder`, `ContainsFurniture`, building/animal/NPC predicates, etc.).

Defer these until string-literal recovery is mechanized:

- `ContainsCinema`
- `BrokenFestivalTile`
- `AStarPath.ToString`

## Validation state

All staged semantic slices have been compile-checked with the persisted .NET SDK `10.0.400` against minimal signature-compatible stubs. The reconstructed units produce 0 compile errors. Occasional `CS0649` warnings are solely artifacts of intentionally uninitialized fields in stripped test harnesses.

## Reconstruction discipline

Do not add helper methods or abstractions absent from the managed metadata merely to prettify recovered code when the shipped managed/native structure is known. Do not guess AOT-managed strings. Linux may resolve shared names and type semantics, but iOS native evidence remains implementation authority.
