using System.Runtime.CompilerServices;
using StardewValley.Mods;

namespace StardewValley;

public interface IHaveModData
{
	ModDataDictionary modData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	ModDataDictionary modDataForSerialization
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}
}
