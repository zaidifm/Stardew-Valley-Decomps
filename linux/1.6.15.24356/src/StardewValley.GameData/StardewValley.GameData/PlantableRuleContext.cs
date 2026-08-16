using System;

namespace StardewValley.GameData;

[Flags]
public enum PlantableRuleContext
{
	Ground = 1,
	GardenPot = 2,
	Any = Ground | GardenPot
}
