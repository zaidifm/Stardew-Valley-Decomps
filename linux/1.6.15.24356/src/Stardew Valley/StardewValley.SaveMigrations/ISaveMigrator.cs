using System;

namespace StardewValley.SaveMigrations;

public interface ISaveMigrator
{
	Version GameVersion { get; }

	bool ApplySaveFix(SaveFixes saveFix);
}
