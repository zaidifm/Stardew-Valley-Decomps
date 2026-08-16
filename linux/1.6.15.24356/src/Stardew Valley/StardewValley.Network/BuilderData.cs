using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Network;

public class BuilderData : INetObject<NetFields>
{
	public NetString buildingType = new NetString();

	public NetInt daysUntilBuilt = new NetInt();

	public NetString buildingLocation = new NetString();

	public NetPoint buildingTile = new NetPoint();

	public NetBool isUpgrade = new NetBool();

	public NetFields NetFields { get; } = new NetFields("BuilderData");

	public BuilderData()
	{
		NetFields.SetOwner(this).AddField(buildingType, "buildingType").AddField(daysUntilBuilt, "daysUntilBuilt")
			.AddField(buildingLocation, "buildingLocation")
			.AddField(buildingTile, "buildingTile")
			.AddField(isUpgrade, "isUpgrade");
	}

	public BuilderData(string buildingType, int daysUntilBuilt, string location, Point tile, bool isUpgrade)
		: this()
	{
		this.buildingType.Value = buildingType;
		this.daysUntilBuilt.Value = daysUntilBuilt;
		buildingLocation.Value = location;
		buildingTile.Value = tile;
		this.isUpgrade.Value = isUpgrade;
	}
}
