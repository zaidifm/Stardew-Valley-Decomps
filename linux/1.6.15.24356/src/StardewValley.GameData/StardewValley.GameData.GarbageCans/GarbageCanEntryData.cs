using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.GarbageCans;

public class GarbageCanEntryData
{
	[ContentSerializer(Optional = true)]
	public float BaseChance = -1f;

	public List<GarbageCanItemData> Items;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
