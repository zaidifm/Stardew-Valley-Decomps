using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class ItemDeliveryQuest : Quest
{
	public string targetMessage;

	[XmlElement("target")]
	public readonly NetString target;

	[XmlElement("item")]
	public readonly NetString ItemId;

	[XmlElement("number")]
	public readonly NetInt number;

	public readonly NetDescriptionElementList parts;

	public readonly NetDescriptionElementList dialogueparts;

	[XmlElement("objective")]
	public readonly NetDescriptionElementRef objective;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemDeliveryQuest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemDeliveryQuest(string target, string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemDeliveryQuest(string target, string itemId, string questTitle, string questDescription, string objective, string returnDialogue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<NPC> GetValidTargetList()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadQuestInfo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadDescription()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadObjective()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnItemOfferedToNpc(NPC npc, Item item, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetGoldRewardPerItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
