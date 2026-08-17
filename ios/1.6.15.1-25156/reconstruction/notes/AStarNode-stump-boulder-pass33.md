# AStarNode stump/boulder pass 33

Target: `ContainsStumpOrBoulder`, token `0x06006647`, native `0x101faacd4`, iOS `1.6.15.1` build `25156`.

Source commit: `26412623dbe8f043369ad6e672d669e518f3f31a`.

## Resource-clump field identity

The native body contains several location-class branches, but every branch reads the same object field at `gameLocation + 0x100` and enumerates that collection with the same `ResourceClump.occupiesTile(x,y)` call.

That field is independently proven as `GameLocation.resourceClumps` by iOS `GameLocation.addResourceClumpAndRemoveUnderlyingTerrain` (token `0x060039D3`, native `0x1018cda9c`): after removing underlying terrain, direct ARM64 executes `ldr x22,[x22,#0x100]`, constructs a `ResourceClump`, then invokes the generic collection Add helper on that field. The current Linux `1.6.15.24356` method is exactly:

`resourceClumps.Add(new ResourceClump(resourceClumpIndex,width,height,tile));`

and declares `public readonly NetCollection<ResourceClump> resourceClumps`.

Because all native class branches select the same collection and run the same occupancy predicate, the reconstructed C# collapses that duplicated branch structure into one enumeration without changing observable semantics.

## Resource clump test

For each `resourceClump` in `gameLocation.resourceClumps`, native calls mapped `ResourceClump.occupiesTile(x,y)` at `0x101a983a0`. The first true result returns true.

## Object fallback

If no resource clump occupies the tile, native uses the already-mapped `gameLocation.objects.TryGetValue(new Vector2(x,y), out object)` path.

When an object exists, its virtual ItemId getter is compared to scalar `0x1038ecef0`. The LLVM AOT decoder resolves that scalar exactly to `Boulder`. Therefore the fallback is `value.ItemId == "Boulder"`.

Missing object returns false.

## Validation

The simplified-but-native-equivalent method compiles with .NET SDK `10.0.400` against minimal resource-clump/game-location stubs with 0 errors. The sole harness warning is the expected uninitialized `_aStarGraph` private field.
