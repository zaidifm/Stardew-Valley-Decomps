# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

This is the compact resume marker. Detailed evidence lives in `methods.tsv`, `ledger/*.tsv`, and `notes/`.

## Current checkpoint

Native-verified reconstructed methods: **63**.

- `AStarPath`: 8 emitted; `ToString` remains triaged pending exact AOT string recovery.
- `AStarNode`: 51 emitted.
- `AStarGraph`: 4 emitted.

The initial mobile pilot is native-first: current Linux `1.6.15.24356` has no `StardewValley.Mobile.AStar*`, `TapToMove*`, or `VirtualJoypad` implementation counterpart.

## Important correction: Mono class-test semantics

An earlier pass incorrectly interpreted the optimized Mono AOT class/supertype comparison sequence as exact runtime-type equality. iOS `GameLocation.isFarmBuildingInterior`, whose shared C# is `return this is AnimalHouse;`, uses the same sequence. The correct reconstruction is subclass-friendly C# `is` semantics.

Corrected source: `ae80ac2cb6c9da7d42cd1ae6a2f409174ed89bd4`.
Corrected note: `notes/AStarNode-TilePredicates-pass5.md` at `11c6b61ee39d3d7d674f9308c4ef0b488083600f`.

Therefore:
- `ContainsTravellingCart`: `gameLocation is Forest`.
- `ContainsTravellingDesertShop`: `gameLocation is Desert`, including `DesertFestival : Desert`.

Any older ledger prose saying those tests are exact runtime-type equality is superseded and must be corrected at the next base-ledger consolidation.

## New since the 60-method checkpoint

### `ContainsAnimals`

Recovered the full animal-location guard and tile test:
- only `AnimalHouse` or `Farm` locations participate;
- iterate `gameLocation.animals.Values`;
- compare `FarmAnimal.StandingPixel.X / 64` and `.Y / 64` to this node's `(x,y)`.

The class globals were independently pinned from iOS `GameLocation.isFarmBuildingInterior` (`AnimalHouse`) and `GameLocation.GetDirtDecayChance` (`Farm`).

Source: `20fc29f8116953df29e4af33aa0ca6bc2f3fa793`.
Evidence: `notes/AStarNode-animals-pass15.md`, ledger `ledger/pass-15-animals.tsv`.

### `ContainsNPC` / `FetchNPC`

Recovered both NPC tile scans and their special Beach path.

The special subclass at the AStar native class guard is proven to be `Beach`: the same class global is used in `TapToMove.OnTap`, where native field `+0x2f8` aligns with `Beach.oldMariner` and following field `+0x300` is dereferenced as `Beach.bridgeFixed : NetBool`. The AdventureGuild alternative is incompatible with that layout.

The normal location collections are also pinned:
- `GameLocation.characters` at `+0xa0`;
- `GameLocation.currentEvent` at `+0x1f0`;
- `Event.actors` at `+0x80`.

iOS `GameLocation.isCharacterAtTile` independently uses the same offsets and switches between `currentEvent.actors` and `characters`, matching shared C# semantics.

Preserved shipped asymmetry:
- `ContainsNPC` skips a `Pet` while `pet.isSleepingOnFarmerBed.Value` is true;
- `FetchNPC` does not apply that sleeping-pet skip.

Source: `8649b73a6fe52c7ec6dc5fc180a4bb2a4b5c556a`.
Evidence: `notes/AStarNode-npc-pass16.md`, ledger `ledger/pass-16-npc.tsv`.

## Previously completed after the 56-method checkpoint

- `FetchBuilding`: buildable-location branch returns first building not passable at `(x,y)`.
- `SetBubbleIDRecursively`: exact N,S,W,E bubble flood fill.
- `ContainsProp`: scans `CurrentEvent.props` by exact `Object.TileLocation` tile equality.
- `ContainsScarecrow`: hardcoded shipped ID set `8,110,113,126,136,137,138,139,140,167`.

## Established TileClear anchors

`TileClear` top-level short-circuit logic is emitted. Verified child behavior now includes gate/fence handling, furniture, blocking beds, travelling cart/desert shop, animals, NPCs, festival props, event props, chest lookup, scarecrows, resource-clump predicates, and building retrieval primitives.

Important retained distinctions include:
- lowercase `isGate()` excludes `Fence.isSoloGate`; `ContainsGate()` / `FetchGate()` do not;
- furniture collision excludes rugs and beds, while `GetFurniture` prioritizes non-rugs then rugs;
- travelling-cart and desert-shop guards use subclass-friendly `is Forest` / `is Desert`;
- giant-weed indices are 44/46; stump/hollow-log indices are 600/602;
- `ContainsNPC` ignores a pet sleeping on the farmer bed but `FetchNPC` does not;
- `AStarPath.Distance` is squared Euclidean distance, no square root.

## Reusable tooling

- `scripts/resolve_mono_vtable_offset.py`: exact .NET 8.0.15 / Mono `50c4cb9f...` ARM64 vtable layout/assignment resolver.
- `scripts/check_reconstruction_ledger.py`: validates the logical union of `methods.tsv` and append-only `ledger/*.tsv` fragments.

## Next frontier

Proceed evidence-first:

1. Finish `ContainsBuilding` by naming its non-buildable xTile `Buildings`-layer fallback exactly.
2. Recover `ContainsStumpOrBoulder` after resolving its final object ItemId literal.
3. Reconstruct `IsBuildingPassable` once its Buildings-layer property strings are recovered.
4. Attack AOT managed-string recovery as reusable tooling. This should unlock `ObjectParentSheetIndexOnTile` default value, `ContainsCinema`, `BrokenFestivalTile`, `ContainsSomeKindOfWarp`, and `AStarPath.ToString`.
5. Reconstruct `ContainsParrotExpress` as a bounded location-specific pass.
6. Then descend into `TapToMoveUtils.IsTilePassable` with a substantially smaller unknown leaf set.

## Validation / discipline

Every emitted slice has been compiled with the persisted .NET SDK `10.0.400` against signature-compatible minimal stubs and currently has 0 compile errors. Harness-only `CS0649` warnings are ignored only when caused by deliberately uninitialized private fields.

Do not guess AOT strings, collapse observable distinctions, or replace shipped mobile behavior with newer shared APIs merely because they look cleaner. iOS native evidence remains implementation authority; Linux source is a semantic naming/reference oracle.
