using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class ResourceCollectionQuest : Quest
{
	[XmlElement("target")]
	public readonly NetString target;

	[XmlElement("targetMessage")]
	public readonly NetString targetMessage;

	[XmlElement("numberCollected")]
	public readonly NetInt numberCollected;

	[XmlElement("number")]
	public readonly NetInt number;

	[XmlElement("reward")]
	public readonly NetInt reward;

	[XmlElement("resource")]
	public readonly NetString ItemId;

	public readonly NetDescriptionElementList parts;

	public readonly NetDescriptionElementList dialogueparts;

	[XmlElement("objective")]
	public readonly NetDescriptionElementRef objective;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceCollectionQuest()
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
	public override bool OnItemReceived(Item item, int numberAdded, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnNpcSocialized(NPC npc, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
