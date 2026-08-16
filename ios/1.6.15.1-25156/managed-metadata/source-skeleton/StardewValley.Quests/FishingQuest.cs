using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class FishingQuest : Quest
{
	[XmlElement("target")]
	public readonly NetString target;

	public string targetMessage;

	[XmlElement("numberToFish")]
	public readonly NetInt numberToFish;

	[XmlElement("reward")]
	public readonly NetInt reward;

	[XmlElement("numberFished")]
	public readonly NetInt numberFished;

	[XmlElement("whichFish")]
	public readonly NetString ItemId;

	public readonly NetDescriptionElementList parts;

	public readonly NetDescriptionElementList dialogueparts;

	[XmlElement("objective")]
	public readonly NetDescriptionElementRef objective;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishingQuest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishingQuest(string itemId, int numberToFish, string target, string questTitle, string questDescription, string returnDialogue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
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
	public override bool OnFishCaught(string fishId, int numberCaught, int size, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnNpcSocialized(NPC npc, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetGoldRewardPerItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
