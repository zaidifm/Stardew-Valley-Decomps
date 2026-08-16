using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Tools;

public class ToolUpgradeData
{
	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public int Price = -1;

	[ContentSerializer(Optional = true)]
	public string RequireToolId;

	[ContentSerializer(Optional = true)]
	public string TradeItemId;

	[ContentSerializer(Optional = true)]
	public int TradeItemAmount = 1;
}
