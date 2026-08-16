using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using StardewValley.Buildings;
using StardewValley.Quests;

namespace StardewValley.SaveMigrations;

public class SaveMigrator_1_6 : ISaveMigrator
{
	public class LegacyDescriptionElement
	{
		public string xmlKey;

		public List<object> param;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LegacyDescriptionElement()
		{
		}
	}

	public Version GameVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ApplySaveFix(SaveFixes saveFix)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ConvertBuildingsToData(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TransferValuesToDataBuilding(Building oldBuilding, Building newBuilding)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MigrateFarmhands(List<GameLocation> locations)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StandardizeBundleFields(Dictionary<string, string> bundleData)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string InferBuildingUpgradingTo(string fromBuildingType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InferMachineInputOutputFields(Object machine)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MigrateLegacyDescriptionElement(Lazy<XmlSerializer> serializer, DescriptionElement element)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveMigrator_1_6()
	{
	}
}
