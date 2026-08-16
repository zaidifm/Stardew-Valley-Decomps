using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class SecretLostItemQuest : Quest
{
	[XmlElement("npcName")]
	public readonly NetString npcName;

	[XmlElement("friendshipReward")]
	public readonly NetInt friendshipReward;

	[XmlElement("exclusiveQuestId")]
	public readonly NetString exclusiveQuestId;

	[XmlElement("itemIndex")]
	public readonly NetString ItemId;

	[XmlElement("itemFound")]
	public readonly NetBool itemFound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SecretLostItemQuest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SecretLostItemQuest(string npcName, string itemId, int friendshipReward, string exclusiveQuestId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isSecretQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void questComplete()
	{
	}
}
