using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class SecretLostItemQuest : Quest
{
	[XmlElement("npcName")]
	public readonly NetString npcName = new NetString();

	[XmlElement("friendshipReward")]
	public readonly NetInt friendshipReward = new NetInt();

	[XmlElement("exclusiveQuestId")]
	public readonly NetString exclusiveQuestId = new NetString();

	[XmlElement("itemIndex")]
	public readonly NetString ItemId = new NetString();

	[XmlElement("itemFound")]
	public readonly NetBool itemFound = new NetBool();

	public SecretLostItemQuest()
	{
	}

	public SecretLostItemQuest(string npcName, string itemId, int friendshipReward, string exclusiveQuestId)
	{
		this.npcName.Value = npcName;
		ItemId.Value = ItemRegistry.QualifyItemId(itemId) ?? itemId;
		this.friendshipReward.Value = friendshipReward;
		this.exclusiveQuestId.Value = exclusiveQuestId;
		questType.Value = 9;
	}

	protected override void initNetFields()
	{
		base.initNetFields();
		base.NetFields.AddField(npcName, "npcName").AddField(friendshipReward, "friendshipReward").AddField(exclusiveQuestId, "exclusiveQuestId")
			.AddField(ItemId, "ItemId")
			.AddField(itemFound, "itemFound");
	}

	public override bool isSecretQuest()
	{
		return true;
	}

	public override bool OnItemReceived(Item item, int numberAdded, bool probe = false)
	{
		bool result = base.OnItemReceived(item, numberAdded, probe);
		if (!completed.Value && !itemFound.Value && item?.QualifiedItemId == ItemId.Value)
		{
			if (!probe)
			{
				itemFound.Value = true;
				Game1.playSound("jingle1");
			}
			return true;
		}
		return result;
	}

	public override bool OnNpcSocialized(NPC npc, bool probe = false)
	{
		bool result = base.OnNpcSocialized(npc, probe);
		if (!completed.Value && itemFound.Value && npc.IsVillager && npc.Name == npcName.Value && Game1.player.Items.ContainsId(ItemId.Value))
		{
			if (!probe)
			{
				questComplete();
				string[] rawQuestFields = Quest.GetRawQuestFields(id.Value);
				Dialogue dialogue = new Dialogue(npc, null, ArgUtility.Get(rawQuestFields, 9, "Data\\ExtraDialogue:LostItemQuest_DefaultThankYou", allowBlank: false));
				npc.setNewDialogue(dialogue);
				Game1.drawDialogue(npc);
				Game1.player.changeFriendship(friendshipReward.Value, npc);
				Game1.player.removeFirstOfThisItemFromInventory(ItemId.Value);
			}
			return true;
		}
		return result;
	}

	public override void questComplete()
	{
		if (completed.Value)
		{
			return;
		}
		completed.Value = true;
		Game1.player.questLog.Remove(this);
		foreach (Quest item in Game1.player.questLog)
		{
			if (item != null && item.id.Value == exclusiveQuestId.Value)
			{
				item.destroy.Value = true;
			}
		}
		Game1.playSound("questcomplete");
	}
}
