using StardewValley.GameData.Machines;

namespace StardewValley.Delegates;

public delegate Item MachineOutputDelegate(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady);
