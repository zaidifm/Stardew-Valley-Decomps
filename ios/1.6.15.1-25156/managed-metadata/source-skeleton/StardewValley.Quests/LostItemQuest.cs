using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class LostItemQuest : Quest
{
	[XmlElement("npcName")]
	public readonly NetString npcName;

	[XmlElement("locationOfItem")]
	public readonly NetString locationOfItem;

	[XmlElement("itemIndex")]
	public readonly NetString ItemId;

	[XmlElement("tileX")]
	public readonly NetInt tileX;

	[XmlElement("tileY")]
	public readonly NetInt tileY;

	[XmlElement("itemFound")]
	public readonly NetBool itemFound;

	[XmlElement("objective")]
	public readonly NetDescriptionElementRef objective;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LostItemQuest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LostItemQuest(string npcName, string locationOfItem, string itemId, int tileX, int tileY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnWarped(GameLocation location, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new void reloadObjective()
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
