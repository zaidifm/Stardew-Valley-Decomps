using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class SocializeQuest : Quest
{
	public readonly NetStringList whoToGreet;

	[XmlElement("total")]
	public readonly NetInt total;

	public readonly NetDescriptionElementList parts;

	[XmlElement("objective")]
	public readonly NetDescriptionElementRef objective;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SocializeQuest()
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
	public override bool OnNpcSocialized(NPC npc, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
