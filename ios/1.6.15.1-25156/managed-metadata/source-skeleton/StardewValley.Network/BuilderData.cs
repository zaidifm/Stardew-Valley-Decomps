using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Network;

public class BuilderData : INetObject<NetFields>
{
	public NetString buildingType;

	public NetInt daysUntilBuilt;

	public NetString buildingLocation;

	public NetPoint buildingTile;

	public NetBool isUpgrade;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuilderData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuilderData(string buildingType, int daysUntilBuilt, string location, Point tile, bool isUpgrade)
	{
	}
}
