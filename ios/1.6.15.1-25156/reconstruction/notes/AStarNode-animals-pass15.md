# AStarNode animal predicate pass 15

Target:

- `ContainsAnimals`, token `0x06006655`, native `0x101facfe8`

Source commit: `20fc29f8116953df29e4af33aa0ca6bc2f3fa793`.

## Location guards

The native method contains two optimized Mono class/supertype tests. These are subclass-friendly C# `is` checks, not exact runtime-type equality.

The first class global, `0x1038c64d0`, is proven to be `StardewValley.Locations.AnimalHouse`: iOS `GameLocation.isFarmBuildingInterior` (token `0x06003B4B`) implements shared source `return this is AnimalHouse;` using the same global and type-test sequence.

The second class global, `0x1038c69d0`, is proven to be `StardewValley.Locations.Farm`: iOS `GameLocation.GetDirtDecayChance` (token `0x06003A1F`, native `0x1018e6dec`) implements the shared ordered branch `if (this is Farm || this is IslandWest || isFarm.Value) return 0.1;`. Its first native class compare loads `0x1038c69d0`; the following compare loads the IslandWest class global.

`ContainsAnimals` returns false unless `gameLocation is AnimalHouse || gameLocation is Farm`.

## Animal collection

The method reads the location field at native offset `+0x28`. Managed metadata places `GameLocation.animals : NetLongDictionary<FarmAnimal, NetRef<FarmAnimal>>` immediately after `buildings`, and earlier native work already established `buildings` at `+0x20`. The enumerated values are therefore `gameLocation.animals.Values`.

## Tile comparison

For each `FarmAnimal`, the native code calls mapped `Character.get_StandingPixel` (token `0x06003255`). It compares each coordinate divided by 64 against this node's `x` / `y`.

For negative coordinates ARM64 adds 63 before arithmetic shift-right by 6. This is exactly signed C# integer division by 64, which truncates toward zero. The semantic reconstruction therefore keeps the readable expression:

`standingPixel.X / 64 == x && standingPixel.Y / 64 == y`.

The method returns true on the first matching animal, false otherwise.

## Validation

The staged source compiles with the persisted .NET SDK `10.0.400` against signature-compatible `AnimalHouse`, `Farm`, `GameLocation.animals`, `FarmAnimal`, and `Point` stubs: 0 errors. One `CS0649` warning is solely the stripped harness leaving `_aStarGraph` uninitialized.
