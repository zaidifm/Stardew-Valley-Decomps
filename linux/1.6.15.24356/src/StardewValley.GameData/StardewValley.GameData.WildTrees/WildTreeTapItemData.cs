using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.WildTrees;

public class WildTreeTapItemData : WildTreeItemData
{
	[ContentSerializer(Optional = true)]
	public List<string> PreviousItemId { get; set; }

	public int DaysUntilReady { get; set; }

	[ContentSerializer(Optional = true)]
	public List<QuantityModifier> DaysUntilReadyModifiers { get; set; }

	[ContentSerializer(Optional = true)]
	public QuantityModifier.QuantityModifierMode DaysUntilReadyModifierMode { get; set; }
}
