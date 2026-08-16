using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;
using StardewValley.Monsters;

namespace StardewValley.Quests;

public class SlayMonsterQuest : Quest
{
	public string targetMessage;

	[XmlElement("monsterName")]
	public readonly NetString monsterName;

	[XmlElement("target")]
	public readonly NetString target;

	[XmlElement("monster")]
	public readonly NetRef<Monster> monster;

	[XmlElement("numberToKill")]
	public readonly NetInt numberToKill;

	[XmlElement("reward")]
	public readonly NetInt reward;

	[XmlElement("numberKilled")]
	public readonly NetInt numberKilled;

	public readonly NetDescriptionElementList parts;

	public readonly NetDescriptionElementList dialogueparts;

	[XmlElement("objective")]
	public readonly NetDescriptionElementRef objective;

	[XmlElement("ignoreFarmMonsters")]
	public readonly NetBool ignoreFarmMonsters;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SlayMonsterQuest()
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
	private bool isSlimeName(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnMonsterSlain(GameLocation location, Monster monster, bool killedByBomb, bool isTameMonster, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnNpcSocialized(NPC npc, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
