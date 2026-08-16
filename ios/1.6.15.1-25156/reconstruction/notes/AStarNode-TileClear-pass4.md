# AStarNode TileClear orchestration pass 4

Target: `StardewValley.Mobile.AStarNode.TileClear` (`get_TileClear`, token `0x06006635`, native `0x101fa8498`).

Source commit: `67918048f3993b4edce56328268d54b87e650b9a`.

## Top-level control flow

The recovered ARM64/Ghidra control flow establishes the following short-circuit order:

1. `_fakeTileClear` -> immediately true.
2. Require `gameLocation.isTileOnMap(new Vector2(x, y))`.
3. Reject `gameLocation.isTileOccupiedIgnoreFloorsAndHorse(tile)` unless this node is a gate.
4. Require `isTilePassable()`.
5. Reject `ContainsStumpOrBoulder()`.
6. Reject `ContainsFurniture()`.
7. Reject a fence unless it is a gate: `isFence() && !isGate()`.
8. Reject a building unless `IsBuildingPassable()`.
9. Reject `ContainsAnimals()`.
10. Reject `ContainsNPC()`.
11. Reject `ContainsFestivalProp()`.
12. Reject `isBlockingBedTile()`.
13. Reject `ContainsTravellingCart()`.
14. Reject `ContainsTravellingDesertShop()`.
15. Reject `BrokenFestivalTile`.
16. Reject `ContainsCinema()`.
17. Finally require `!ContainsParrotExpress()`.

The staged C# preserves this order instead of collapsing the formula into a large boolean expression, because the shipped code is short-circuiting and some child predicates are nontrivial.

## Resolved virtual GameLocation call

The previously anonymous virtual call in step 3 loads a function pointer from `GameLocation`'s Mono vtable at byte offset `0x3d0`.

Using the exact embedded Mono runtime source (`50c4cb9fc31c47f03eac865d7bc518af173b74b7`):

- `MonoVTable.vtable[]` begins at ARM64 byte offset `0x50`.
- `0x3d0` therefore addresses physical slot 112.
- GameLocation's first non-interface slot is 14: 4 inherited `System.Object` virtual slots plus 10 packed interface slots.
- Mono gathers the class virtuals and prepends them to a GSList, so later non-final NEW_SLOT assignment walks reverse metadata order.
- GameLocation class-assignment index `112 - 14 = 98` resolves to token `0x06003A5A`, `GameLocation.isTileOccupiedIgnoreFloorsAndHorse(Vector2)`.

This result is reproducible with `scripts/resolve_mono_vtable_offset.py` and is separately documented in `notes/Mono-vtable-resolution.md`.

## Other call identity

The direct native call at `0x1018d3404` maps to token `0x060039E7`, `GameLocation.isTileOnMap(Vector2)`.

Every other top-level call in the recovered `TileClear` body is already a named AStarNode MethodDef in the checked-in native pseudocode.

## Validation

The reconstructed orchestration was compiled under the persisted .NET SDK `10.0.400` against signature-compatible stubs for the child predicates and shared GameLocation methods.

Result: 0 errors. Two `CS0649` warnings arise only because the stripped compile harness intentionally leaves `_aStarGraph` and `_fakeTileClear` uninitialized; their real class initialization exists outside that temporary harness.

## Dependency policy from here

`TileClear` is now a verified orchestration method even though several of its child predicates still need semantic source bodies. Those predicates can be reconstructed independently without reopening the top-level logic. The next passes should prefer the smallest children first, beginning with `isTilePassable` and bounded location-specific obstacle predicates.
