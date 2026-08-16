using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class ItemHarvestQuest : Quest
{
	[XmlElement("itemIndex")]
	public readonly NetString ItemId;

	[XmlElement("number")]
	public readonly NetInt Number;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemHarvestQuest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemHarvestQuest(string itemId, int number = 1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnItemReceived(Item item, int numberAdded, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
