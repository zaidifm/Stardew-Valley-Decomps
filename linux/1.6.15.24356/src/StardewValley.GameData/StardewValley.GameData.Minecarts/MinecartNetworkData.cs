using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Minecarts;

public class MinecartNetworkData
{
	[ContentSerializer(Optional = true)]
	public string UnlockCondition;

	[ContentSerializer(Optional = true)]
	public string LockedMessage;

	[ContentSerializer(Optional = true)]
	public string ChooseDestinationMessage;

	[ContentSerializer(Optional = true)]
	public string BuyTicketMessage;

	public List<MinecartDestinationData> Destinations;
}
