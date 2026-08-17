# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

This is the compact resume marker. Detailed per-method evidence belongs in `methods.tsv`, `ledger/*.tsv`, and `notes/`.

## Current checkpoint

The active pilot is the mobile-only AStar subsystem. The current Linux `1.6.15.24356` source has no `StardewValley.Mobile.AStar*`, `TapToMove*`, or `VirtualJoypad` counterpart, so this pilot is native-first rather than a Linux implementation transplant.

Native-verified reconstructed methods at this checkpoint: **56**.

- `AStarPath`: 8 verified/emitted; `ToString` remains triaged because exact AOT-managed string literals are unresolved.
- `AStarNode`: 44 verified/emitted.
- `AStarGraph`: 4 verified/emitted.

## Newly completed since the 47-method checkpoint

### Blocking bed tile

`AStarNode.isBlockingBedTile` is complete. The native method uses the mobile `DecoratableLocation` guard, calls mapped `BedFurniture.GetBedAtTile(location,x,y)`, constructs the node's 64x64 rectangle, and dispatches through BedFurniture virtual slot `+0x660`. Direct ARM64 at mapped `BedFurniture.IntersectsForCollision(Rectangle)` reproduces the shared Linux implementation exactly, establishing that virtual target.

Source: `ab3ae535c735de297a1f70d03f79a127e0583817`.
Evidence: `notes/AStarNode-blocking-bed-pass7.md`, `ledger/pass-07-blocking-bed.tsv`.

### Furniture

`ContainsFurniture` and `GetFurniture` are complete.

- `ContainsFurniture` skips rugs (`12`) and beds (`15`) and tests the remaining furniture bounding boxes against the node rectangle.
- `GetFurniture` makes two passes: intersecting non-rugs first, rugs second. Beds are not excluded from this retrieval method.

Source: `2a5a552ad941bfeb9adb7a8b111e260d0994f3c2`.
Evidence: `notes/AStarNode-furniture-pass8.md`, `ledger/pass-08-furniture.tsv`.

### Chests

`ContainsChest` / `FetchChest` are complete. Native helper `0x101b560e8` maps exactly to `OverlaidDictionary.TryGetValue`; the key is `new Vector2(x,y)`, followed by a `Chest` type test/cast.

Source: `c2b0d53b9de7c7b117fc923e9af0a05f0e3b8faa`.
Evidence: `notes/AStarNode-chest-pass9.md`, `ledger/pass-09-chest.tsv`.

### Resource clumps

Four methods are complete:

- `ContainsGiantWeed`: occupying `ResourceClump` with green-rain bush index `44` or `46`.
- `ContainsGiantCrop`: Farm-only occupying clump typed `GiantCrop`.
- `FetchGiantCrop`: Farm-only first occupying `GiantCrop`.
- `ContainsStumpOrHollowLog`: occupying clump with index `600` or `602`.

Native `0x101a983a0` maps exactly to `ResourceClump.occupiesTile(x,y)`. The opaque native bit tests decode directly against shared `ResourceClump` constants.

Source: `275ba546a794ca24d83eb9af49e5f70a90233f11`.
Evidence: `notes/AStarNode-resource-clumps-pass10.md`, `ledger/pass-10-resource-clumps.tsv`.

## Previously established anchors

- `AStarPath.Distance` is squared Euclidean distance, not square-root distance.
- Four-way and eight-way neighbour enumeration preserve the shipped direction order and repeated native structure.
- lowercase `isGate()` excludes `Fence.isSoloGate`; `ContainsGate()` / `FetchGate()` do not.
- `ContainsTravellingCart` uses an exact `Forest` type check.
- `ContainsTravellingDesertShop` uses an exact `Desert` type check, excluding `DesertFestival : Desert`.
- `ContainsFestivalProp` scans `Game1.CurrentEvent.festivalProps`; shipped `Prop.isColliding` is `solid && rectangle.Intersects(boundingRect)`.
- `TileClear` top-level short-circuit formula is verified and emitted.
- `GameLocation` virtual call at `MonoVTable + 0x3d0` is proven to be `isTileOccupiedIgnoreFloorsAndHorse(Vector2)`.
- reusable virtual-slot helper: `scripts/resolve_mono_vtable_offset.py`.

## Current dependency frontier

Keep shrinking `TileClear` before descending into the broad TapToMove helper graph. Strong next candidates:

1. `ContainsBuilding` / `FetchBuilding` and `IsBuildingPassable`.
2. `ContainsNPC` / `FetchNPC`, after naming their special-location branch and collection fields precisely.
3. `ContainsAnimals`, after naming the two location subclasses selected by its native type checks.
4. `ContainsStumpOrBoulder`, using the now-known resource-clump primitives plus its object fallback.
5. `TapToMoveUtils.IsTilePassable` once these leaf predicates no longer obscure its behavior.

Still defer methods whose semantics depend on unresolved AOT-managed string constants unless the string-recovery problem is solved first:

- `ContainsCinema`
- `BrokenFestivalTile`
- `AStarPath.ToString`

`ContainsParrotExpress` is also nontrivial and should be handled as a bounded location-specific pass rather than guessed.

## Validation

Every emitted semantic slice in this checkpoint has been compile-checked with the persisted .NET SDK `10.0.400` against signature-compatible minimal stubs. Current checks produce 0 compile errors; occasional `CS0649` warnings are only stripped-harness uninitialized-field artifacts.

## Resume discipline

`methods.tsv` is the consolidated base ledger. New passes live in append-only `ledger/*.tsv`; the logical ledger is their union. `scripts/check_reconstruction_ledger.py` validates the combined set and rejects duplicate keys.

Do not guess AOT-managed strings or invent helper methods absent from managed metadata. Linux may resolve shared type/member semantics, but iOS native evidence is implementation authority.
