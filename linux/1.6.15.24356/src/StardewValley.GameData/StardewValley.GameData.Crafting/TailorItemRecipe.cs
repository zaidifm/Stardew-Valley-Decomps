using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Crafting;

public class TailorItemRecipe
{
	private string IdImpl;

	[ContentSerializer(Optional = true)]
	public List<string> FirstItemTags;

	[ContentSerializer(Optional = true)]
	public List<string> SecondItemTags;

	[ContentSerializer(Optional = true)]
	public bool SpendRightItem = true;

	[ContentSerializer(Optional = true)]
	public string CraftedItemId;

	[ContentSerializer(Optional = true)]
	public List<string> CraftedItemIds;

	[ContentSerializer(Optional = true)]
	public string CraftedItemIdFeminine;

	[ContentSerializer(Optional = true)]
	public string Id
	{
		get
		{
			if (IdImpl != null)
			{
				return IdImpl;
			}
			List<string> craftedItemIds = CraftedItemIds;
			if (craftedItemIds != null && craftedItemIds.Any())
			{
				return string.Join(",", CraftedItemIds);
			}
			return CraftedItemId;
		}
		set
		{
			IdImpl = value;
		}
	}
}
