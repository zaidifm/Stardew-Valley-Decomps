using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class GoSomewhereQuest : Quest
{
	[XmlElement("whereToGo")]
	public readonly NetString whereToGo;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GoSomewhereQuest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GoSomewhereQuest(string where)
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
}
