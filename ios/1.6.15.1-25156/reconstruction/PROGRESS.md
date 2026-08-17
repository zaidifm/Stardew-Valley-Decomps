# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

Compact resume marker. Detailed evidence lives in base `methods.tsv`, append-only `ledger/*.tsv`, and `notes/`.

## Current checkpoint

The bounded mobile AStar reconstruction pilot is **COMPLETE: 108/108 managed methods**.

- `AStarPath`: **9/9 complete**.
- `AStarNode`: **64/64 complete**.
- `AStarGraph`: **35/35 complete**.

The active reconstruction frontier has moved to **`TapToMoveUtils`**, beginning with `TapToMoveUtils.IsTilePassable`, which is already a direct dependency of the completed `AStarNode.isTilePassable()` wrapper.

## Method 108: `AStarGraph.DiagonalWalkDirection`

Token `0x06006614`, native `0x101fa3e1c`.

Source: `reconstruction/src/StardewValley.Mobile/AStarGraph.Diagonal.cs`, commit `c5d77351b3285291a4ba5afee50c71ad2164c3c6`.
Evidence: `reconstruction/notes/AStarGraph-DiagonalWalkDirection-pass37.md`.
Ledger: `reconstruction/ledger/pass-37-diagonal-walk.tsv`.

Ghidra's high-level decompiler died on this ~11 KB native method. Recovery therefore used the complete ARM64 body directly.

The large body reduces to four structurally equivalent right-angle cases over `path.nodes[i..i+2]`:

- DownLeft
- DownRight
- UpLeft
- UpRight

For a three-node cardinal L-turn whose endpoints are diagonally adjacent, the method scans the start node's passable cardinal neighbors and returns the matching diagonal only when **both orthogonal cells around the corner are passable**. Otherwise it returns `WalkDirection.None`.

Native structural checks:

- exactly 20 direct calls to `AStarNode.GetNeighbouringNodeList(true)`, five per diagonal block;
- four return blocks encode values 7/8/5/6 (`DownLeft`, `DownRight`, `UpLeft`, `UpRight`) only when a local match counter equals 2;
- common zero return is `None`.

The staged C# intentionally preserves repeated `path.nodes` / `GetNeighbouringNodeList(true)` access rather than introducing a cleaner helper that is absent from metadata/native structure.

Validation: .NET SDK 10.0.400 minimal signature-compatible harness, **0 warnings / 0 errors**.

## Method 107: `AStarNode.DebugIsTilePassable`

Source `a408a6da456d2fa4d58ef4892aa6b2501bfd33d5`.
Evidence `notes/AStarNode-DebugIsTilePassable-pass36.md`.
Ledger `ledger/pass-36-debug-passability.tsv`.

Canonical native address: `0x101fa9a74`.

This completed AStarNode 64/64. The recovered method preserves its verbose Back/Buildings/Passable/Shadow/Water/WaterSource diagnostic branches and the shipped discrepancy fallback between mobile `isTilePassable()` and `GameLocation.isTilePassable(Vector2)`.

Validation used the actual owned same-era Linux `xTile.dll` and `MonoGame.Framework.dll`: **0 warnings / 0 errors**.

## Pilot-level capabilities now established

### LLVM AOT scalar/string decoder

`scripts/decode_llvm_aotconst.py`

Mechanically resolves:

`LLVM scalar global -> llvm_init_aotconst slot -> LLVM_GOT_INFO_OFFSETS patch -> managed #US string`

A private ~19k-row LDSTR mapping is persisted in the Universal File Library.

### Same-era xTile dependency oracle

The owned Linux `1.6.15.24356` `xTile.dll` was decompiled with ILSpy 11.0.0.9375 and persisted privately under the Linux decompilation reference-dependencies area.

### Mono vtable resolver

`scripts/resolve_mono_vtable_offset.py` resolves opaque Mono virtual-call offsets against the exact .NET 8.0.15 / Mono runtime used by this iOS build.

### Reconstruction ledger/checkpoint discipline

- source only after investigation;
- append-only per-pass ledger fragments;
- concise evidence notes;
- compile/signature validation;
- semantic GitHub commits after bounded units;
- private Library checkpoints at important milestones.

## Important shipped quirks preserved

- `AStarPath.Distance` is squared Euclidean distance.
- `AStarGraph.Distance` is squared Euclidean while lowercase `distance` uses `sqrt`.
- core A* ranks by `fCost` but the shipped native body does not update `fCost` during relaxation.
- Dijkstra includes start and end nodes and bakes normal/unreachable paths; start==end returns early without Bake.
- diagonal-target fallback uses strict minima for NW/NE/SW but accepts SE if TileClear when none of those wins.
- `isGate()` excludes solo gates while `ContainsGate()` / `FetchGate()` do not.
- `ContainsNPC` ignores a pet sleeping on the farmer bed while `FetchNPC` does not.
- Mono AOT class-test sequences here correspond to subclass-friendly C# `is`, not exact runtime-type equality.

## New active frontier: TapToMoveUtils

Start with `TapToMoveUtils.IsTilePassable` and expand only through its actual dependencies.

The same workflow remains in force:

1. managed iOS metadata for signatures/fields;
2. iOS AOT/Ghidra or raw ARM64 for implementation authority;
3. Linux current source and same-era dependency assemblies for names/shared semantics;
4. LLVM AOT decoder for managed constants;
5. selective dependency drill-down only when ambiguity requires it;
6. compile-check, evidence note, ledger row, semantic commit;
7. periodic Library checkpoint.

After a bounded TapToMoveUtils slice is stable, expand into broader `TapToMove`, then `VirtualJoypad`.

## Validation / discipline

Every AStar semantic unit in the 108/108 pilot has been compile-checked or signature-checked against matching managed/dependency shapes. Preserve shipped quirks; do not invent helper methods, guess constants, or replace native mobile behavior with cleaner modern APIs. iOS native evidence remains implementation authority; current Linux source/dependencies are naming and semantic reference oracles.
