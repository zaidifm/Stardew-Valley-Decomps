# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

Compact resume marker. Detailed evidence lives in base `methods.tsv`, append-only `ledger/*.tsv`, and `notes/`.

## Current checkpoint

Native-verified reconstructed methods: **105**.

- `AStarPath`: **9/9 complete**.
- `AStarNode`: **62/64 emitted**.
- `AStarGraph`: **34/35 emitted**; only private `DiagonalWalkDirection` remains.

Only two AStarNode methods remain: `DebugIsTilePassable` and `AStarNode.ToString`.

## Methods 101-105

### 101: `IsBuildingPassable`

Source `616bd1fa63c48ba6d43090ac90f9960b867c6a1b`.

Using the owned same-era Linux `xTile.dll` as the dependency oracle, the iOS AOT call sequence resolves to `map.GetLayer("Buildings").PickTile(...)`, `TileIndexProperties`, inherited `Properties`, and `PropertyValue.ToString()`.

Recovered property literals are `Buildings`, `Passable`, `t`, `true`, `Shadow`. The method accepts explicit Passable values `t`/`true` (case-normalized) from tile-index or direct tile properties, otherwise accepts a `Shadow` tile-index property.

### 102: `ContainsSomeKindOfWarp`

Source `24f33954be51232cce5689e8b0bac6ff290d684a`.

Buildings-layer PickTile; retains the shipped unused TileIndexProperties `Passable` lookup; then scans direct tile Properties for exact values `LockedDoorWarp`, `Warp`, `WarpMensLocker`, or `WarpWomensLocker`.

### 103: `ContainsBuilding`

Same source commit `24f33954be51232cce5689e8b0bac6ff290d684a`.

Buildable locations scan `gameLocation.buildings` and return true for the first building where `!building.isTilePassable(new Vector2(x,y))`. Non-buildable locations instead return whether the Buildings-layer PickTile is non-null.

### 104: `ContainsStumpOrBoulder`

Source `26412623dbe8f043369ad6e672d669e518f3f31a`.

The native body has redundant location-class branches, but every one enumerates the same `GameLocation +0x100` field. That field is independently proven `resourceClumps` by iOS `GameLocation.addResourceClumpAndRemoveUnderlyingTerrain`, which loads `this+0x100` immediately before adding a newly constructed ResourceClump, exactly matching current Linux source. Reconstruction therefore collapses the duplicate branches to one `resourceClumps` scan using mapped `ResourceClump.occupiesTile(x,y)`. Fallback is tile object `ItemId == "Boulder"`.

### 105: `DebugObjectParentSheetIndexOnTile`

Source `beee4b954359a267fddf752051ffb4892c9011c2`.

Tile object lookup, then log:

`"obj.parentSheetIndex:" + value.parentSheetIndex?.ToString() + ", " + value.ToString()`

Item `+0x58` is independently proven the `parentSheetIndex : NetInt` field by direct ARM64 for `Item.get_ParentSheetIndex`. MonoVTable `+0x60` is physical slot2 and resolves to `System.Object.ToString`, explaining both virtual calls. The exact prefix/comma-space literals come from the LLVM scalar decoder.

## Major capabilities now available

### LLVM AOT scalar / string decoder

`scripts/decode_llvm_aotconst.py`

Mechanically resolves Apple LLVM scalar globals through generated `llvm_init_aotconst`, `LLVM_GOT_INFO_OFFSETS`, and Mono patch metadata to exact managed `#US` strings. A private 19,185-row LDSTR map is persisted in the Universal File Library.

SFLDA/static-field patch decoding has also been demonstrated, including proof that the date scalar in `BrokenFestivalTile` is `Game1.dayOfMonth`.

### Same-era xTile dependency oracle

The owned Linux `1.6.15.24356` distribution's `xTile.dll` was decompiled with persisted ILSpy 11.0.0.9375. The exact dependency source is available privately under `/mnt/data/sdv-recon/xtile-decomp/source/` and is used to name/verify iOS xTile AOT calls rather than relying on older public xTile code.

## Remaining methods

### AStarNode (2)

- `DebugIsTilePassable` token `0x06006645`, native `0x101faa698`: large diagnostic/logging method around mobile passability and map properties.
- `ToString` token `0x0600665D`, native `0x101fadb10`: large formatter; exact LLVM literals are now recoverable, so this is a finite field/method-mapping task rather than a string blocker.

### AStarGraph (1)

- `DiagonalWalkDirection(AStarPath,int)` token `0x06006614`, native `0x101fa3e1c`, ~11 KB. High-level Ghidra decompile crashed; raw ARM64 is persisted privately. `SmoothRightAngles` is already reconstructed around it.

## Next direction

1. Finish `AStarNode.ToString` using the full scalar map plus method/field mappings.
2. Recover `DebugIsTilePassable`, ideally leveraging exact same-era xTile APIs and the now-known string constants.
3. Then tackle `DiagonalWalkDirection` from raw ARM64 to complete AStarGraph.
4. With the AStar pilot nearly complete, expand outward into `TapToMoveUtils.IsTilePassable` and then broader TapToMove/VirtualJoypad dependencies.

## Canonical correction

Mono class/supertype tests in this target use subclass-friendly C# `is`, not exact `GetType()` equality. `ContainsTravellingCart` is `is Forest`; `ContainsTravellingDesertShop` is `is Desert` and includes `DesertFestival`. Older base-ledger prose saying exact type is superseded until ledger consolidation.

## Validation / discipline

All emitted semantic units through method 105 have been compile-checked or signature-checked against the matching managed/dependency shapes; current units have zero compile errors. Preserve shipped quirks and do not guess constants or replace native behavior with cleaner modern APIs.
