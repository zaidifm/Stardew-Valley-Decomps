# TapToMoveUtils object/terrain microcluster pass 46

Targets:

- `NodeContainsMusicBlock(AStarNode)` token `0x060066E3`, native `0x101fcac14`
- `NodeContainsHousePlant(AStarNode)` token `0x060066E5`, native `0x101fcb184`
- `GetHousePlant(AStarNode)` token `0x060066E6`, native `0x101fcb268`
- `IsTerrainFeatureAt(AStarNode)` token `0x06006700`, native `0x101fcd754`
- `FetchGate(GameLocation,AStarNode)` token `0x06006719`, native `0x101fcfa80`

Source commit: `c9c391ba24f07dfbfc89c3f590e5dfe3c8a63270`.

## Music blocks

The location class scalar is the same `DecoratableLocation` constant already proven in AStarNode bed/path work. Outside DecoratableLocation the method returns false.

At the node tile, it probes the location objects dictionary and reads `Item.ParentSheetIndex`. Native range test `ParentSheetIndex - 463 < 2` accepts exactly 463 or 464. These are preserved as the shipped numeric IDs rather than being rewritten through newer data APIs.

A null node is only dereferenced after the DecoratableLocation guard, matching native short-circuit behavior.

## House plants

These two methods deliberately use `Game1.currentLocation`, **not** TapToMoveUtils.gameLocation. This means the fishing-minigame location override used by other utilities is not applied here.

Both probe the current location objects dictionary at node `(x,y)` and compare the virtual ItemId getter against exact LLVM literal `House Plant` (`0x1038ed7b8`).

- `NodeContainsHousePlant` returns the boolean ItemId match.
- `GetHousePlant` returns the Object only on that match, otherwise null.

## IsTerrainFeatureAt

Probes `gameLocation.terrainFeatures` at the node tile. The native return is based on whether the out terrain-feature reference is non-null.

When present, native builds and logs exactly:

`TapToMoveUtils.IsTerrainFeatureAt(<x>, <y>) terrainFeature:<terrainFeature.ToString()>`

Recovered LLVM literals:

- `TapToMoveUtils.IsTerrainFeatureAt(`
- `, `
- `) terrainFeature:`

The logging side effect is preserved rather than reducing the method to a dictionary ContainsKey.

## FetchGate

This is the explicit-GameLocation counterpart of the already reconstructed AStar gate lookup:

1. node coordinates form the Vector2 key;
2. require the location objects dictionary to contain the tile;
3. require the object to be a `Fence`;
4. require `fence.isGate.Value`;
5. return the Fence, otherwise null.

Fence class/field identities were already proven in the AStar pilot.

## Validation

All five methods compile together with .NET SDK 10.0.400 against MonoGame.Framework plus signature-compatible location/object/terrain-feature stubs.

Result with nullable analysis disabled for the intentionally sparse test harness: **0 warnings, 0 errors**.

## Deliberate deferral

`IsOreAt(Vector2)` was analyzed but not emitted in this pass because its comparison against an external-assembly SFLDA static field should be named exactly before source is committed. The surrounding field is strongly associated with `GameLocation.orePanPoint`, but the project does not convert that into a source claim until the referenced static field is mechanically resolved.

## Result

TapToMoveUtils reaches **53/84 reconstructed methods**.
