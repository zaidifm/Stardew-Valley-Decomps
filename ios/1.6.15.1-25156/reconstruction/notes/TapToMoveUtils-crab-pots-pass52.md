# TapToMoveUtils crab-pot helpers — pass 52

Target: iOS `1.6.15.1` build `25156`.

Source commit: `b07cfdcc83da83c51d1cbd51257f4bd60130f98e`.

## `CrabPotNeighbour` — `0x0600670C`, native `0x101FCE43C`

Calls `aStarNode.GetNeighbouringNodeListFull(false)` and scans the returned occupied/non-clear neighbours in list order. For each neighbour it calls `FetchObject()` and returns the first neighbour whose object has `ParentSheetIndex == 710`.

No CrabPot runtime-type test is performed in this helper; the shipped test is the numeric parent-sheet index only.

## `ClickedCrabPot` — `0x0600670D`, native `0x101FCE5A8`

First inspects the clicked node itself. If its object has ParentSheetIndex 710, the native code performs a CrabPot type check/cast and returns that pot without requiring `readyForHarvest`.

If the clicked node is not a crab pot, the method probes `(x,y+1)` and then `(x,y+2)`. A pot found in either lower tile is returned only when its inherited `Object.readyForHarvest.Value` is true. The lower-tile cast is the throwing cast form in native code; this distinction is preserved with `(CrabPot)obj` after the index check.

## `FetchMostAccessibleNodeToCrabPot` — `0x0600670B`, native `0x101FCE1D0`

Uses `Game1.currentLocation.IsWaterTile` and returns the AStar node for the first non-water neighbour in this exact order:

1. N `(x,y-1)`
2. S `(x,y+1)`
3. W `(x-1,y)`
4. E `(x+1,y)`
5. NW `(x-1,y-1)`
6. NE `(x+1,y-1)`
7. SW `(x-1,y+1)`
8. **SW `(x-1,y+1)` again**

If all eight tests report water, the original crab-pot node is returned.

The duplicated SW test is not a Ghidra artifact. Raw ARM64 at `0x101FCE2C0..0x101FCE304` contains two consecutive coordinate constructions with the same `x-1,y+1` arithmetic and two calls to mapped `GameLocation.IsWaterTile` (`0x06003AC5`, native `0x10191E0C4`). There is no SE test. The reconstruction deliberately preserves this shipped behavior.

## Validation

All three methods compile in a signature-compatible harness.

Result: **0 warnings, 0 errors**.
