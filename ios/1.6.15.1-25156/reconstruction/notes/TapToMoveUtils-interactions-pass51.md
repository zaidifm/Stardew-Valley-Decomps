# TapToMoveUtils interaction helpers — pass 51

Target: iOS `1.6.15.1` build `25156`.

Source commit: `f681eb58d85acbfda00ca7f83451a8228177a8d3`.

## `FetchAccessibleTileNextToBuilding` — `0x0600671C`, native `0x101FD0E0C`

The method indexes the supplied `List<Vector2>`, truncates the selected X/Y to integers, and calls `AStarGraph.FetchAStarNode`.

If a node exists it sets `FakeTileClear = true` and calls `GetShortestPathAStarWithBubbleCheck(startNode,node)`. A non-null path with a non-null/nonempty nodes list returns `new Vector2(tileX,tileY)`. On failure the method resets `FakeTileClear = false`; on success it does **not** reset it. Missing/unreachable nodes return `Vector2.Zero`.

Raw ARM64 confirms the Vector2 return ABI explicitly: successful x/y ints are converted to `s0/s1`; fallback loads both floats from the runtime `Vector2.Zero` scalar.

## `HoeSelectedAndTileHoeable` — `0x060066E7`, native `0x101FCB350`

Requires `Game1.player.CurrentTool` to be `Hoe`, then uses the effective mobile `gameLocation`.

Exact GameLocation virtual-slot resolution for this iOS build:

- MonoVTable `+0x260` -> `GameLocation.doesTileHaveProperty` (`0x06003AC1`)
- MonoVTable `+0x3e8` -> `GameLocation.IsTileOccupiedBy` (`0x06003A53`)

The recovered strings are exact `"Diggable"` / `"Back"`. The method requires a Diggable Back-layer property, requires `!location.IsTileOccupiedBy(tile)`, then returns shared `location.isTilePassable(new Vector2((int)tile.X,(int)tile.Y))`.

## `TappedEggAtEggFestival` — `0x06006717`, native `0x101FCF6C0`

Requires a current event whose exact `FestivalName` is `"Egg Festival"`. It scans `CurrentEvent.festivalProps` and returns true when one prop contains the click point.

The native body invokes Rectangle.Contains directly on each prop's `boundingRect` at `Prop +0x38`. iOS `Prop.ContainsPoint(Vector2)` (`0x060034DF`, native `0x10181CC90`) is itself exactly that same operation, so the reconstruction uses the public `prop.ContainsPoint(clickPoint)` boundary rather than illegally naming the private rectangle field.

## `FetchFarmAnimal` — `0x06006718`, native `0x101FCF87C`

Scans the supplied location's `animals.Values` and tests `FarmAnimal.GetCursorPetBoundingBox().Contains(x,y)`.

FarmAnimal `+0x1f0` is `wasPet`. This identity is anchored by iOS `FarmAnimal.pet`: in the native sequence corresponding to the current shared `if (!wasPet.Value)` branch, the code reads the NetBool at `+0x1f0`. The nearby golden-animal-cracker branch uses the later `hasEatenAnimalCracker` field, keeping the identities distinct.

Selection behavior is intentionally asymmetric:

- the first matching petted animal is retained as a fallback;
- any matching unpetted animal is returned immediately, even if a petted match was found earlier.

## Validation

All four methods compile in a signature-compatible harness using the actual same-era MonoGame dependency.

Result: **0 warnings, 0 errors**.
