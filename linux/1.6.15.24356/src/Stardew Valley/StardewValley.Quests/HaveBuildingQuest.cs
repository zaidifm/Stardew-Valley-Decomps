using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class HaveBuildingQuest : Quest
{
	[XmlElement("buildingType")]
	public readonly NetString buildingType = new NetString();

	public HaveBuildingQuest()
	{
		questType.Value = 8;
	}

	public HaveBuildingQuest(string buildingType)
		: this()
	{
		this.buildingType.Value = buildingType;
	}

	protected override void initNetFields()
	{
		base.initNetFields();
		base.NetFields.AddField(buildingType, "buildingType");
	}

	public override bool OnBuildingExists(string buildingType, bool probe = false)
	{
		bool result = base.OnBuildingExists(buildingType, probe);
		if (buildingType == this.buildingType.Value)
		{
			if (!probe)
			{
				questComplete();
			}
			return true;
		}
		return result;
	}
}
