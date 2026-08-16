using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.SaveMigrations;

public static class SaveMigrator
{
	public static readonly SaveFixes LatestSaveFix;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ApplySaveFixes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ApplySingleSaveFix(SaveFixes fix, List<Item> loadedItems)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<ISaveMigrator> GetAllMigrators(bool reverse = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
