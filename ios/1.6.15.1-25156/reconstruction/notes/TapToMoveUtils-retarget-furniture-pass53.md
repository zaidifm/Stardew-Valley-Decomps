# TapToMoveUtils retarget / furniture helpers — pass 53

Target: iOS `1.6.15.1` build `25156`.

Source commit: `fc8bc9895d1061826715d784d18ef91d2aba73f6`.

## `retargetToParrotExpressSpot` — `0x06006715`, native `0x101FCF268`

The class guard is `IslandLocation`, reusing the class identity already proven in the AStar Parrot Express pass. Outside an IslandLocation the original `tileClicked` is returned unchanged.

Inside an IslandLocation it enumerates `parrotPlatforms` and calls `ParrotPlatform.OccupiesTile(tileClicked)`. On the first matching platform it returns the platform tile position plus `(1,0)`:

`((int)(platform.position.X / 64f + 1f), (int)(platform.position.Y / 64f))`.

The external helper at `0x10035025C` is the same Vector2 addition helper independently established in the warp and AStar Parrot passes. If no platform matches while in an IslandLocation, the native method returns `Point.Zero`, not the original click.

## `retargetToBedSpot` — `0x06006716`, native `0x101FCF4B4`

The location class guard is `DecoratableLocation`. The method calls mapped `BedFurniture.GetBedAtTile(graph.gameLocation,x,y)`, then virtual `BedFurniture.GetBedSpot()`, fetches the clicked AStar node, and requires `node.isBlockingBedTile()`.

For non-single beds it returns the bed spot directly. For `BedType.Single` (`0`) it computes the player's standing tile from `StandingPixel / 64`, compares Vector2 distance from that player tile to the bed spot and to `(bedSpot.X-1,bedSpot.Y)`, and preserves an unusual native choice:

- if the normal bed spot distance is **strictly less** than the left-tile distance, it decrements `bedSpot.X` and returns the left tile;
- otherwise it keeps the normal bed spot.

Raw ARM64 at `0x101FCF644..0x101FCF64C` is `fcmp firstDistance, secondDistance; b.pl keep; mov bedX,leftX`, confirming the apparently inverted comparison.

Any failed guard/lookup returns the original `tileClicked`.

## `NodeContainsFurniture` — `0x060066E2`, native `0x101FCA9D8`

Null node => false. Otherwise construct the node's 64x64 pixel rectangle and scan effective `gameLocation.furniture`; return true for the first `furniture.GetBoundingBox().Intersects(nodeBounds)`.

The native body expands the same `Object.GetBoundingBox` / `Furniture.GetBoundingBoxAt` logic directly, including `isTemporarilyInvisible -> Rectangle.Empty`; using the public `GetBoundingBox()` preserves those semantics.

## `GetFurnitureClickedOn` — `0x060066E4`, native `0x101FCAD68`

Two passes over effective `gameLocation.furniture`:

1. first intersecting non-rug (`furniture_type != 12`) whose bounding box contains the click;
2. if none, first intersecting rug (`furniture_type == 12`).

This preserves the same non-rug-before-rug priority already recovered independently in `AStarNode.GetFurniture`.

## Validation

All four methods compile in a signature-compatible harness using the actual same-era MonoGame dependency.

Result: **0 warnings, 0 errors**.
