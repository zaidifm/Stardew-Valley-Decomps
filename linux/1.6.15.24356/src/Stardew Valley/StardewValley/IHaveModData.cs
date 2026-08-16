using StardewValley.Mods;

namespace StardewValley;

public interface IHaveModData
{
	ModDataDictionary modData { get; }

	ModDataDictionary modDataForSerialization { get; set; }
}
