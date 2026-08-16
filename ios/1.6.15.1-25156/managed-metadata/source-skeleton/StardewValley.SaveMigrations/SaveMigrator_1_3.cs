using System;
using System.Runtime.CompilerServices;

namespace StardewValley.SaveMigrations;

public class SaveMigrator_1_3 : ISaveMigrator
{
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
	public static void ApplyLegacyChanges()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MarkFloorChestAsCollectedIfNecessary(int floorNumber)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MigrateFriendshipData(Farmer player)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void MigrateHorseIds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveMigrator_1_3()
	{
	}
}
