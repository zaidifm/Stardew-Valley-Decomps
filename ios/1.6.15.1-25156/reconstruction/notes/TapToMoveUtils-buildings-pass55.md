# TapToMoveUtils building geometry/accessibility — pass 55

Target: iOS `1.6.15.1` build `25156`.

Source commit: `fd6b277fc46f080b2df87a7d89f797b92cbe7477`.

## Building field identities

The iOS managed metadata order and native object layout line up exactly:

- `Building +0x40` -> `tileX : NetInt`
- `Building +0x48` -> `tileY : NetInt`
- `Building +0x50` -> `tilesWide : NetInt`
- `Building +0x58` -> `tilesHigh : NetInt`

Every native read in these two methods dereferences the NetInt value at `+0x68`.

## `ListOfTilesSurroundingBuilding` — `0x0600671D`, native `0x101FD0F9C`

Returns the building perimeter in this exact traversal order:

1. top edge: `(tileX + 0..tilesWide-1, tileY)`, left to right, including both top corners;
2. right edge: `(tileX+tilesWide-1, tileY+1..tilesHigh-1)`, excluding top-right and including bottom-right;
3. bottom edge: `tileX+tilesWide-2` down through `tileX`, at `tileY+tilesHigh-1`, excluding bottom-right and including bottom-left;
4. left edge: `tileY+tilesHigh-2` down through `tileY+1`, excluding both left corners.

The slightly odd decrementing `xOffset=-2` / `yOffset=-2` structure in the C# mirrors the native loop arithmetic instead of inventing a new perimeter helper.

## `GetTileNextToBuildingNearestFarmer` — `0x0600671B`, native `0x101FD065C`

The method converts `who.StandingPixel` to tile coordinates using signed integer `/64` semantics and determines a preliminary nearest perimeter coordinate with four distance accumulators and a `(0,0)` sentinel.

The reconstructed branches preserve two important off-by-one/sentinel behaviors:

- the lower-outside test is `tileY + tilesHigh < farmerY`, not `bottom < farmerY`. Therefore a farmer at exactly `tileY + tilesHigh` is handled by the vertically-inside branch even though that Y is one tile below the generated bottom perimeter (`tileY + tilesHigh - 1`);
- the preliminary nearest coordinate uses `(0,0)` as its unset sentinel, so legitimate zero coordinates follow the native sentinel/corner-selection path rather than a sanitized clamp implementation.

When both coordinates are within the building's tested interior band, the native method chooses the **right edge**, not the geometrically closest edge. The reconstruction preserves this by following the original branch structure rather than replacing it with a clamp-to-rectangle shortcut.

After computing the preliminary coordinate:

1. call `ListOfTilesSurroundingBuilding`;
2. linearly locate the first matching perimeter index, defaulting to index 0 if none matches;
3. use `aStarGraph.FarmerAStarNodeOffset` as the path start;
4. call already-reconstructed `FetchAccessibleTileNextToBuilding` for that offset;
5. return immediately if the Vector2 result is not `Vector2.Zero`.

If the first attempt returns zero and perimeter Count > 3, raw ARM64 shows an unusual retry loop. For increasing positive/negative distances, it calls `FetchAccessibleTileNextToBuilding` **only when the index would wrap past an end of the list**:

- negative side only when `offset + negativeOffset < 0`, using `offset + Count + negativeOffset`;
- positive side only when `offset + positiveOffset > Count-1`, using `offset + positiveOffset - Count`.

Ordinary in-range neighboring offsets are not tested. The loop increments/decrements offsets until `positiveOffset < Count/2` fails.

If no accessible perimeter tile is returned, fallback is the farmer's current standing tile `(StandingPixel.X/64, StandingPixel.Y/64)`.

The external Vector2 helper used after each accessibility call is the same Vector2 inequality operation already proven in the AStar Parrot Express work; here it tests `result != Vector2.Zero`.

## Validation

Both methods compile in a signature-compatible .NET 10 harness.

Result: **0 warnings, 0 errors**.
