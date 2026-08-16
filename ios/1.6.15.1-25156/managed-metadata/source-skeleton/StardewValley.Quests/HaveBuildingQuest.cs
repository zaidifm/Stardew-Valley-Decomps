using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class HaveBuildingQuest : Quest
{
	[XmlElement("buildingType")]
	public readonly NetString buildingType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HaveBuildingQuest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HaveBuildingQuest(string buildingType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnBuildingExists(string buildingType, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
