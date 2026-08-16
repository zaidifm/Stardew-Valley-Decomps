using System;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Extensions;

namespace StardewValley.Quests;

public class LostItemQuest : Quest
{
	[XmlElement("npcName")]
	public readonly NetString npcName = new NetString();

	[XmlElement("locationOfItem")]
	public readonly NetString locationOfItem = new NetString();

	[XmlElement("itemIndex")]
	public readonly NetString ItemId = new NetString();

	[XmlElement("tileX")]
	public readonly NetInt tileX = new NetInt();

	[XmlElement("tileY")]
	public readonly NetInt tileY = new NetInt();

	[XmlElement("itemFound")]
	public readonly NetBool itemFound = new NetBool();

	[XmlElement("objective")]
	public readonly NetDescriptionElementRef objective = new NetDescriptionElementRef();

	public LostItemQuest()
	{
	}

	public LostItemQuest(string npcName, string locationOfItem, string itemId, int tileX, int tileY)
	{
		this.npcName.Value = npcName;
		this.locationOfItem.Value = locationOfItem;
		ItemId.Value = ItemRegistry.QualifyItemId(itemId) ?? itemId;
		this.tileX.Value = tileX;
		this.tileY.Value = tileY;
		questType.Value = 9;
		if (!ItemRegistry.GetDataOrErrorItem(ItemId.Value).HasTypeObject())
		{
			throw new InvalidOperationException($"Can't create {GetType().Name} #{id.Value} because the lost item ({ItemId.Value}) isn't an object-type item.");
		}
	}

	protected override void initNetFields()
	{
		base.initNetFields();
		base.NetFields.AddField(objective, "objective").AddField(npcName, "npcName").AddField(locationOfItem, "locationOfItem")
			.AddField(ItemId, "ItemId")
			.AddField(tileX, "tileX")
			.AddField(tileY, "tileY")
			.AddField(itemFound, "itemFound");
	}

	public override bool OnWarped(GameLocation location, bool probe = false)
	{
		bool result = base.OnWarped(location, probe);
		if (!itemFound.Value && location.name.Equals(locationOfItem.Value))
		{
			Vector2 vector = new Vector2(tileX.Value, tileY.Value);
			location.overlayObjects.Remove(vector);
			Object obj = ItemRegistry.Create<Object>(ItemId.Value);
			obj.TileLocation = vector;
			obj.questItem.Value = true;
			obj.questId.Value = id.Value;
			obj.IsSpawnedObject = true;
			location.overlayObjects.Add(vector, obj);
			return true;
		}
		return result;
	}

	public new void reloadObjective()
	{
		if (objective.Value != null)
		{
			base.currentObjective = objective.Value.loadDescriptionElement();
		}
	}

	public override bool OnItemReceived(Item item, int numberAdded, bool probe = false)
	{
		bool result = base.OnItemReceived(item, numberAdded, probe);
		if (!completed.Value && !itemFound.Value && item != null && item.QualifiedItemId == ItemId.Value)
		{
			if (!probe)
			{
				itemFound.Value = true;
				string sub = npcName.Value;
				NPC characterFromName = Game1.getCharacterFromName(npcName.Value);
				if (characterFromName != null)
				{
					sub = characterFromName.displayName;
				}
				Game1.player.completelyStopAnimatingOrDoingAction();
				Game1.drawObjectDialogue(Game1.content.LoadString("Strings\\Quests:MessageFoundLostItem", item.DisplayName, sub));
				objective.Value = new DescriptionElement("Strings\\Quests:ObjectiveReturnToNPC", characterFromName);
				Game1.playSound("jingle1");
			}
			return true;
		}
		return result;
	}

	public override bool OnNpcSocialized(NPC npc, bool probe = false)
	{
		bool result = base.OnNpcSocialized(npc, probe);
		if (!completed.Value && itemFound.Value && npc.Name == npcName.Value && npc.IsVillager && Game1.player.Items.ContainsId(ItemId.Value))
		{
			if (!probe)
			{
				questComplete();
				string[] rawQuestFields = Quest.GetRawQuestFields(id.Value);
				Dialogue dialogue = new Dialogue(npc, null, ArgUtility.Get(rawQuestFields, 9, "Data\\ExtraDialogue:LostItemQuest_DefaultThankYou", allowBlank: false));
				npc.setNewDialogue(dialogue);
				Game1.drawDialogue(npc);
				Game1.player.changeFriendship(250, npc);
				Game1.player.removeFirstOfThisItemFromInventory(ItemId.Value);
			}
			return true;
		}
		return result;
	}
}
