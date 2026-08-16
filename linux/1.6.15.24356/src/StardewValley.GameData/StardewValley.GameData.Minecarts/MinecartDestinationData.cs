using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Minecarts;

public class MinecartDestinationData
{
	public string Id;

	public string DisplayName;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public int Price;

	[ContentSerializer(Optional = true)]
	public string BuyTicketMessage;

	public string TargetLocation;

	public Point TargetTile;

	[ContentSerializer(Optional = true)]
	public string TargetDirection;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
