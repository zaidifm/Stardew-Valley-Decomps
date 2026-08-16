using System;
using System.Collections.Generic;

namespace StardewValley.SaveMigrations;

public static class SaveMigrator
{
	public static readonly SaveFixes LatestSaveFix = SaveFixes.FixDuplicateMissedMail;

	public static void ApplySaveFixes()
	{
		if (!Game1.hasApplied1_3_UpdateChanges)
		{
			SaveMigrator_1_3.ApplyLegacyChanges();
		}
		if (!Game1.hasApplied1_4_UpdateChanges)
		{
			SaveMigrator_1_4.ApplyLegacyChanges();
		}
		if (Game1.lastAppliedSaveFix >= LatestSaveFix)
		{
			return;
		}
		List<ISaveMigrator> allMigrators = GetAllMigrators(reverse: true);
		for (SaveFixes saveFixes = Game1.lastAppliedSaveFix + 1; saveFixes < SaveFixes.MAX; saveFixes++)
		{
			if (Enum.IsDefined(typeof(SaveFixes), saveFixes))
			{
				Game1.log.Debug("Applying save fix: " + saveFixes);
				using List<ISaveMigrator>.Enumerator enumerator = allMigrators.GetEnumerator();
				while (enumerator.MoveNext() && !enumerator.Current.ApplySaveFix(saveFixes))
				{
				}
			}
			Game1.lastAppliedSaveFix = saveFixes;
		}
	}

	public static void ApplySingleSaveFix(SaveFixes fix, List<Item> loadedItems)
	{
		using List<ISaveMigrator>.Enumerator enumerator = GetAllMigrators().GetEnumerator();
		while (enumerator.MoveNext() && !enumerator.Current.ApplySaveFix(fix))
		{
		}
	}

	public static List<ISaveMigrator> GetAllMigrators(bool reverse = false)
	{
		List<ISaveMigrator> list = new List<ISaveMigrator>();
		Type[] types = typeof(ISaveMigrator).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (type.IsClass && !type.IsAbstract && typeof(ISaveMigrator).IsAssignableFrom(type))
			{
				ISaveMigrator item = ((ISaveMigrator)Activator.CreateInstance(type)) ?? throw new InvalidOperationException("Failed to create instance of save migration '" + type.FullName + "'.");
				list.Add(item);
			}
		}
		if (reverse)
		{
			list.Sort((ISaveMigrator a, ISaveMigrator b) => -a.GameVersion.CompareTo(b.GameVersion));
		}
		else
		{
			list.Sort((ISaveMigrator a, ISaveMigrator b) => a.GameVersion.CompareTo(b.GameVersion));
		}
		return list;
	}
}
