using System;

namespace StardewValley.GameData.Machines;

[Flags]
public enum MachineOutputTrigger
{
	None = 0,
	ItemPlacedInMachine = 1,
	OutputCollected = 2,
	MachinePutDown = 4,
	DayUpdate = 8
}
