using System;
using System.Runtime.CompilerServices;

namespace StardewValley.SaveMigrations;

public interface ISaveMigrator
{
	Version GameVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ApplySaveFix(SaveFixes saveFix);
}
