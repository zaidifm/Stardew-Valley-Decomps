using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buildings;

public class BuildingItemConversion
{
	public string Id;

	public List<string> RequiredTags;

	[ContentSerializer(Optional = true)]
	public int RequiredCount = 1;

	[ContentSerializer(Optional = true)]
	public int MaxDailyConversions = 1;

	public string SourceChest;

	public string DestinationChest;

	public List<GenericSpawnItemDataWithCondition> ProducedItems;
}
