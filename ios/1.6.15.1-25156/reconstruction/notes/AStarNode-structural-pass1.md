# AStarNode structural reconstruction pass 1

Target: structural/property slice of `StardewValley.Mobile.AStarNode` in iOS `1.6.15.1` build `25156`.

Reconstruction source commit: `d86bd8859b8e7238552e88fc5371f609f4a6bab2`.

As with the rest of the initial mobile pilot, no current Linux `1.6.15.24356` counterpart exists. This slice is reconstructed directly from managed metadata plus ARM64/AOT evidence.

## Verified object layout and accessors

The native accessors establish the following relevant instance layout:

- `parentNode` reference: `+0x10`
- `_aStarGraph` reference: `+0x18`
- `fCost`: `+0x28`
- `gCost`: `+0x2c`
- `hCost`: `+0x30`
- `x`: `+0x34`
- `y`: `+0x38`
- `bubbleID`: `+0x3c`
- `bubbleID2`: `+0x40`
- `bubbleChecked`: `+0x44`
- `_fakeTileClear`: `+0x45`

The six auto-properties `fCost`, `gCost`, `hCost`, `parentNode`, `x`, and `y` are direct backing-field loads/stores. The `parentNode` setter includes the expected Mono GC write barrier.

## Constructor

`0x0600662A AStarNode..ctor @ 0x101fa77ec` stores `0xffffffffffffffff` across offsets `+0x3c..+0x43`, establishing `bubbleID = -1` and `bubbleID2 = -1`, then stores the supplied graph reference at `+0x18` and coordinates at `+0x34/+0x38`.

## Geometry

`rectangle` at `0x101fa7838` constructs a 64x64 rectangle at `(x << 6, y << 6)`.

`NodeCenterOnMap` at `0x101fa8398` loads `x` and `y`, shifts each left by 6, converts both to floats, and adds `32f` to both lanes. The reconstructed value is therefore:

`new Vector2((x << 6) + 32f, (y << 6) + 32f)`.

## Neighbour-list views

- `NeighbouringNodeList` calls `GetNeighbouringNodeList(true)`.
- `OccupiedNeighbouringNodeList` calls `GetNeighbouringNodeList(false)`.

The implementation of `GetNeighbouringNodeList` itself is intentionally deferred to the next behavioral slice; these two property wrappers are independently verified.

## FakeTileClear

The public `FakeTileClear` getter/setter are direct reads/writes of `_fakeTileClear` at `+0x45`.

## Validation

The staged source was compiled with the persisted .NET SDK `10.0.400` against minimal `AStarGraph`, `Rectangle`, `Vector2`, and unreconstructed-neighbour-method stubs. Result: 0 warnings, 0 errors.

## Next

Reconstruct `GetBoundingBox`, the lowercase `rect`/`fakeTileClear` aliases, then the bounded gate/object predicate chain needed by `AStarPath.containsClosedGate` and `ContainsGate`. `GetNeighbouringNodeList` follows once its AStarGraph dependencies are mapped into readable primitives.
