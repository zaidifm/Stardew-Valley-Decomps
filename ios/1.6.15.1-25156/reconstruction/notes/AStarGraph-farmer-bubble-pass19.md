# AStarGraph farmer offset / bubble refresh pass 19

Target: `FarmerAStarNodeOffset` and `RefreshBubbles` in iOS `1.6.15.1` build `25156`.

Source commit: `394de850b060daf6f0991d81e5714f69a8866f07`.

## `FarmerAStarNodeOffset`

Token `0x060065FE`, native `0x101fa18e0`.

The method reads `Game1.player.position.X/Y` through the same mapped `NetPosition.get_X/get_Y` accessors as `FarmerAStarNode`, adds 32 pixels to each coordinate, multiplies by `1/64`, truncates to integer tile coordinates, and calls `FetchAStarNode(x,y)`.

If that node is non-null, it is returned directly.

If the node is null, the native method checks `Game1.currentLocation` against the class global stored at `0x1038c6c50`. That class is **proven to be `StardewValley.Locations.FarmHouse`**:

- iOS `DecoratableLocation.MakeMapModifications` (`0x060052B0`, native `0x101c47df0`) loads the exact same class global from `0x1038c6c50`.
- The matching shared Linux method has the explicit C# branch `if (!(this is FarmHouse))` around wallpaper/floor setup.
- The native class/supertype check pattern has already been independently established as ordinary subclass-friendly C# `is` semantics.

Therefore the fallback is exactly:

`if (node == null && Game1.currentLocation is FarmHouse) node = FetchNeighbourNodeThatIsPassible(x,y);`

This also naturally includes `Cabin : FarmHouse` if present through inheritance, matching the native class test.

## `RefreshBubbles`

Token `0x06006615`, native `0x101fa69b0`.

The shipped order is:

1. `ResetBubbles(true, true)`.
2. Evaluate `FarmerAStarNode`; if null, stop.
3. Evaluate `FarmerAStarNodeOffset`; if null, stop.
4. Evaluate `FarmerAStarNodeOffset` again for the call target and invoke `SetBubbleIDRecursively(0, false)`.

The staged C# uses the property naturally in the condition/call and preserves the semantic behavior. There is no secondary-bubble flag in this refresh call.

## Validation

Both methods compile under the persisted .NET SDK `10.0.400` against minimal `FarmHouse`, `Game1`, `NetPosition` and AStar stubs with **0 warnings, 0 errors**.
