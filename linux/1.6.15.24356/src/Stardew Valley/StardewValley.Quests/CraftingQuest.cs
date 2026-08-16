using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class CraftingQuest : Quest
{
	[XmlElement("isBigCraftable")]
	public bool? obsolete_isBigCraftable;

	[XmlElement("indexToCraft")]
	public readonly NetString ItemId = new NetString();

	public CraftingQuest()
	{
	}

	public CraftingQuest(string itemId)
	{
		ItemId.Value = ItemRegistry.QualifyItemId(itemId) ?? itemId;
	}

	protected override void initNetFields()
	{
		base.initNetFields();
		base.NetFields.AddField(ItemId, "ItemId");
	}

	public override bool OnRecipeCrafted(CraftingRecipe recipe, Item item, bool probe = false)
	{
		bool result = base.OnRecipeCrafted(recipe, item, probe);
		if (item.QualifiedItemId == ItemId.Value)
		{
			if (!probe)
			{
				questComplete();
			}
			return true;
		}
		return result;
	}
}
