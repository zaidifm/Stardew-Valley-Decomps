using System.Collections.Generic;

namespace StardewValley.GameData.GarbageCans;

public class GarbageCanData
{
	public float DefaultBaseChance = 0.2f;

	public List<GarbageCanItemData> BeforeAll;

	public List<GarbageCanItemData> AfterAll;

	public Dictionary<string, GarbageCanEntryData> GarbageCans;
}
