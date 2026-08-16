# iOS C# reconstruction progress

Canonical branch: `ios-csharp-reconstruction`

This file is a compact resume marker. Detailed per-method evidence belongs in `methods.tsv` and `notes/`.

## Current checkpoint

Reconstruction has started with the mobile-only AStar subsystem after the initial correspondence survey showed that the current Linux `1.6.15.24356` source has no `StardewValley.Mobile.AStar*`, `TapToMove*`, or `VirtualJoypad` counterpart.

Native-verified reconstructed methods at this checkpoint: **42**.

### AStarPath

- 8 methods verified and emitted.
- `ToString` is triaged but intentionally not emitted because exact AOT-managed string literals/punctuation remain unresolved.
- Key discovery: `Distance` is squared Euclidean distance, not square-root distance.

Semantic source commit: `46f602a33edf8fd6f6dea2d7cdda67d88e43ed1e`.
Evidence note: `notes/AStarPath-pass1.md`.

### AStarNode

30 methods verified/emitted across four slices:

- backing fields/properties, constructor, tile geometry, node-center geometry;
- geometry aliases and bounding box;
- object/fence/gate predicates;
- four-direction and eight-direction neighbour enumeration.

Important preserved distinction:
- lowercase `isGate()` excludes `Fence.isSoloGate`;
- `ContainsGate()` / `FetchGate()` do not.

Canonical neighbour source after removing an over-cleaned intermediate abstraction: `cded72b8af1d54d806668e1a322d312b2f629bf8`.

Evidence notes:
- `notes/AStarNode-structural-pass1.md`
- `notes/AStarNode-gates-pass2.md`
- `notes/AStar-neighbours-pass3.md`

### AStarGraph

4 minimal graph primitives verified/emitted:

- `FetchAStarNode`
- `Nodes`
- `AddNode`
- constructor

Semantic source commit: `5a8e108cb8c4303a18cb0008d9e9d6bddc162632`.

## Current dependency frontier

`AStarNode.TileClear` (`0x06006635`, native `0x101fa8498`).

The native method is already structurally recovered. Its top-level shape is:

1. `_fakeTileClear` short-circuits to true.
2. Require `gameLocation.isTileOnMap(new Vector2(x, y))`.
3. Evaluate a virtual one-`Vector2` location predicate, with gates receiving special treatment.
4. Require the node's `isTilePassable()`.
5. Reject stump/boulder, furniture, non-gate fence, impassable building, animals, NPC, festival prop, blocking bed tile, travelling cart, travelling desert shop, broken festival tile, cinema, and parrot express conditions.

The direct native call at `0x1018d3404` is resolved by the AOT map as `GameLocation.isTileOnMap`.

The one remaining unnamed virtual call in the top-level formula is invoked from the `GameLocation` vtable at `+0x3d0` with the tile `Vector2`. Do not guess its managed name. Resolve that virtual slot before emitting `TileClear`.

## Next actions

1. Resolve the `GameLocation` vtable `+0x3d0` call used by `TileClear`.
2. Classify `TileClear`'s directly called AStarNode predicates into trivial/shared-reference vs genuinely mobile-specific dependencies.
3. Reconstruct the smallest predicate cluster needed for a faithful `TileClear` implementation.
4. Update `methods.tsv`, compile-check the staged slice, and checkpoint again before expanding to AStar search algorithms.

## Validation state

- `AStarPath` staged slice: compiled with .NET SDK 10.0.400 against minimal signature stubs, 0 errors / 0 warnings.
- Gate/object-expanded `AStarNode`: 0 errors / 0 warnings under minimal signature stubs.
- Neighbour + graph-primitives harness: 0 errors; 2 `CS0649` warnings caused solely by intentionally uninitialized private fields in the stripped compile harness.

## Reconstruction discipline

Do not add helper methods or abstractions that are absent from managed metadata merely to prettify repetitive recovered code. An intermediate neighbour commit did this and was immediately corrected. Prefer observed method boundaries and call structure when native evidence is clear.
