using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class ItemHarvestQuest : Quest
{
	[XmlElement("itemIndex")]
	public readonly NetString ItemId = new NetString();

	[XmlElement("number")]
	public readonly NetInt Number = new NetInt();

	public ItemHarvestQuest()
	{
	}

	public ItemHarvestQuest(string itemId, int number = 1)
	{
		ItemId.Value = ItemRegistry.QualifyItemId(itemId) ?? itemId;
		Number.Value = number;
		questType.Value = 9;
	}

	protected override void initNetFields()
	{
		base.initNetFields();
		base.NetFields.AddField(ItemId, "ItemId").AddField(Number, "Number");
	}

	public override bool OnItemReceived(Item item, int numberAdded, bool probe = false)
	{
		bool result = base.OnItemReceived(item, numberAdded, probe);
		if (!completed.Value && (item.QualifiedItemId == ItemId.Value || (ItemId.Value.StartsWith('-') && item.Category.ToString() == ItemId.Value)))
		{
			int num = Number.Value - numberAdded;
			bool flag = num <= 0;
			if (!probe)
			{
				Number.Value = num;
				if (flag)
				{
					questComplete();
				}
			}
			return true;
		}
		return result;
	}
}
