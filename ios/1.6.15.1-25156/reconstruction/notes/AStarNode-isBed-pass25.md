# AStarNode isBed pass 25

Target: `StardewValley.Mobile.AStarNode.isBed`, token `0x06006650`, native `0x101fabfcc`, iOS `1.6.15.1` build `25156`.

Source commit: `4032d4774185c85add1ebe34bc4b88246d039c33`.

## Location and bed lookup

The native location-class global is the same `FarmHouse` identity already proven in `AStarGraph.FarmerAStarNodeOffset`. The class check uses the target's subclass-aware Mono test semantics, so non-FarmHouse locations return false.

The next native calls map exactly through the all-AOT map:

- `0x101a242f0` -> `StardewValley.Utility.getHomeOfFarmer`
- `0x101c66fe0` -> `StardewValley.Locations.FarmHouse.GetBed`

Arguments to `GetBed` are `-1, 0`. iOS/Linux metadata defines `BedFurniture.BedType.Any = -1`, so this is `home.GetBed(BedType.Any,0)`.

The returned BedFurniture is dispatched through its virtual `GetBedSpot()` method. iOS maps `BedFurniture.GetBedSpot` (token `0x0600480A`) to native `0x101ade984`; shared Linux semantics return the bed spot as a tile `Point`.

If there is no bed, the native method uses packed point `(-1000,-1000)`.

## Shipped coordinate comparison

The final ARM64 comparison converts each `Point` component to float and uses `fcvtzs ..., #6`, i.e. fixed-point conversion with six fractional bits, equivalent here to truncating `component * 64f` back to int.

It therefore returns:

`x == (int)(bedSpot.X * 64f) && y == (int)(bedSpot.Y * 64f)`

This is noteworthy because AStarNode `x/y` are otherwise tile coordinates. The reconstruction intentionally preserves this apparent tile-vs-pixel mismatch rather than replacing it with a guessed intent.

## Validation

The staged method compiles under .NET SDK `10.0.400` with 0 errors. The only warning in the stripped harness is the expected uninitialized `_aStarGraph` field stub.
