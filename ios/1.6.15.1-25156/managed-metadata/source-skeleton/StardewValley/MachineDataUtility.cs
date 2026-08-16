using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StardewValley.GameData;
using StardewValley.GameData.Machines;
using StardewValley.Inventories;

namespace StardewValley;

public static class MachineDataUtility
{
	public delegate string GetOutputTokenValueDelegate(string key, Object machine, MachineItemOutput outputData, Item inputItem, Farmer who);

	public static readonly IDictionary<string, GetOutputTokenValueDelegate> OutputTokens;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasAdditionalRequirements(IInventory inventory, IList<MachineItemAdditionalConsumedItems> requirements, out MachineItemAdditionalConsumedItems failedRequirement)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanApplyOutput(Object machine, MachineOutputRule rule, MachineOutputTrigger trigger, Item inputItem, Farmer who, GameLocation location, out MachineOutputTriggerRule triggerRule, out bool matchesExceptCount)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetMachineOutputRule(Object machine, MachineData machineData, MachineOutputTrigger trigger, Item inputItem, Farmer who, GameLocation location, out MachineOutputRule rule, out MachineOutputTriggerRule triggerRule, out MachineOutputRule ruleIgnoringCount, out MachineOutputTriggerRule triggerIgnoringCount)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MachineItemOutput GetOutputData(Object machine, MachineData machineData, MachineOutputRule outputRule, Item inputItem, Farmer who, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MachineItemOutput GetOutputData(List<MachineItemOutput> outputs, bool useFirstValidOutput, Item inputItem, Farmer who, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item GetOutputItem(Object machine, MachineItemOutput outputData, Item inputItem, Farmer who, bool probe, out int? overrideMinutesUntilReady)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateStats(List<StatIncrement> stats, Item item, int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool PlayEffects(Object machine, MachineEffects effect, bool playSounds = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string FormatOutputId(string id, Object machine, MachineItemOutput outputData, Item inputItem, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetTokenValue(string key, Object machine, MachineItemOutput outputData, Item inputItem, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetNearbyFlowerItemId(Object machine)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
