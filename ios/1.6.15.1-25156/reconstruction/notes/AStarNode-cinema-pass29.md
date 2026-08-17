# AStarNode cinema pass 29

Target: `ContainsCinema`, token `0x0600663B`, native `0x101fa8df4`, iOS `1.6.15.1` build `25156`.

Source commit: `cdae95d2b45a9c6a2d5e08c6602b70bd467ff4a5`.

## Town class identity

The native class global used by this method is `0x1038c6e88`.

That identity is proven by iOS `GameLocation.performGreenRainUpdate` (token `0x06003A3F`, native `0x1018ec9cc`), which loads the exact same class global at `0x1018eccd4`. The matching current shared C# at that point follows the Paths/GreenRain tile loop with:

`if (this is Town) return;`

The native class/supertype comparison sequence is the already-established subclass-friendly C# `is` test. Therefore `ContainsCinema` requires `_aStarGraph.gameLocation is Town`.

## Mail flag

The LLVM AOT string decoder resolves scalar `0x1038e79a0` to exact literal `ccMovieTheater`.

The native call is mapped `Utility.doesMasterPlayerHaveMailReceivedButNotMailForTomorrow(string)`. The cinema footprint is disabled until that flag is received.

## Tile footprint

The unsigned range tests reduce exactly to:

- x 47 through 58 inclusive and y 17 through 19 inclusive; or
- y 20 with x 47; or
- y 20 with x 55 through 58 inclusive.

No other Town tile is reported as cinema collision by this method.

## Validation

The reconstructed method compiles with .NET SDK `10.0.400` against minimal Town/Utility/AStar stubs with **0 warnings, 0 errors**.
