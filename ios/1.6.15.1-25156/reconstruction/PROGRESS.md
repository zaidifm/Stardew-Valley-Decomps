# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

This is the compact resume marker. Detailed evidence lives in `methods.tsv`, `ledger/*.tsv`, and `notes/`.

## Current checkpoint

Native-verified reconstructed methods: **60**.

- `AStarPath`: 8 emitted; `ToString` remains triaged pending exact AOT string recovery.
- `AStarNode`: 48 emitted.
- `AStarGraph`: 4 emitted.

The initial mobile pilot is native-first: current Linux `1.6.15.24356` has no `StardewValley.Mobile.AStar*`, `TapToMove*`, or `VirtualJoypad` implementation counterpart.

## New since the 56-method checkpoint

### `FetchBuilding`

Native `GameLocation` vtable `+0x510` resolves exactly to `IsBuildableLocation()`. Building vtable `+0x100` resolves to `Building.isTilePassable(Vector2)`. The recovered method returns the first `gameLocation.buildings` entry that is not passable at `(x,y)`, or null.

Source `e9ef95e77c17cb44e69883376579bd3b4528f35e`; evidence `notes/AStarNode-building-pass11.md`, ledger `pass-11-building.tsv`.

`ContainsBuilding` remains triaged because its non-buildable-location branch probes the map `Buildings` layer through xTile generic helpers. `IsBuildingPassable` likewise still contains unresolved layer-property strings.

### `SetBubbleIDRecursively`

Recovered the exact N,S,W,E recursive bubble flood fill, including `bubbleChecked`, `_searchAStarNode`, the primary `bubbleID != 0 && !TileClear` rejection, and primary/secondary bubble assignment.

Source `f120c5bf97c117817025688f6884e513146d4778`; evidence `notes/AStarNode-bubble-pass12.md`, ledger `pass-12-bubble.tsv`.

### `ContainsProp`

`Event +0x88` is `CurrentEvent.props`; Object vtable `+0x5f8` resolves to `Object.TileLocation`. The method scans event objects for exact `(TileLocation.X, TileLocation.Y) == (x,y)` equality. This is distinct from `ContainsFestivalProp`, which uses `festivalProps` and solid rectangle collision.

Source `ecb2b33c1797e7d4a924777ab8f2f82b214a29b0`; evidence `notes/AStarNode-event-props-pass13.md`, ledger `pass-13-event-props.tsv`.

### `ContainsScarecrow`

Direct ARM64 for `Item.get_ParentSheetIndex` proves the field access used by the native method. The shipped hardcoded scarecrow set is exactly:

`8, 110, 113, 126, 136, 137, 138, 139, 140, 167`.

Source `f625023e8a71335f02f43f2a3b335c001f5c63a5`; evidence `notes/AStarNode-scarecrow-pass14.md`, ledger `pass-14-scarecrow.tsv`.

## Established TileClear anchors

`TileClear` top-level short-circuit logic is already emitted. Verified child behavior now includes gate/fence handling, furniture, blocking beds, travelling cart/desert shop, festival props, event props, chest lookup, resource-clump predicates, and building retrieval primitives.

Important retained distinctions include:

- lowercase `isGate()` excludes `Fence.isSoloGate`; `ContainsGate()` / `FetchGate()` do not;
- furniture collision excludes rugs and beds, while `GetFurniture` prioritizes non-rugs then rugs;
- cart and desert-shop checks use exact `Forest` and exact `Desert` runtime types;
- giant-weed indices are 44/46; stump/hollow-log indices are 600/602;
- `AStarPath.Distance` is squared Euclidean distance, no square root.

## Reusable tooling

`scripts/resolve_mono_vtable_offset.py` models the exact .NET 8.0.15 / Mono `50c4cb9f...` ARM64 vtable layout and reverse metadata assignment used by this build.

`scripts/check_reconstruction_ledger.py` validates the logical union of the consolidated `methods.tsv` plus append-only `ledger/*.tsv` fragments.

## Next frontier

Proceed evidence-first:

1. Prove and reconstruct `ContainsAnimals` (native class guards are strongly localized to Farm + one other animal location; field `GameLocation +0x28` is the shared `animals` dictionary).
2. Resolve `ContainsNPC` / `FetchNPC` special-location and secondary-character collection identities.
3. Finish `ContainsBuilding` once xTile `Buildings`-layer fallback is named exactly.
4. Recover `ContainsStumpOrBoulder` after resolving its final object ItemId literal.
5. Attack AOT managed-string recovery as a reusable capability; this should unlock `ObjectParentSheetIndexOnTile` default value, `IsBuildingPassable`, `ContainsCinema`, `BrokenFestivalTile`, `ContainsSomeKindOfWarp`, and `AStarPath.ToString`.
6. Then descend into `TapToMoveUtils.IsTilePassable` with a substantially smaller unknown leaf set.

`ContainsParrotExpress` remains a separate location-specific dependency pass.

## Validation / discipline

Every emitted slice has been compiled with the persisted .NET SDK `10.0.400` against signature-compatible minimal stubs and currently has 0 compile errors. Harness-only `CS0649` warnings are ignored only when caused by deliberately uninitialized private fields.

Do not guess AOT strings, collapse observable distinctions, or replace shipped mobile behavior with newer shared APIs merely because they look cleaner. iOS native evidence remains implementation authority; Linux source is a semantic naming/reference oracle.
