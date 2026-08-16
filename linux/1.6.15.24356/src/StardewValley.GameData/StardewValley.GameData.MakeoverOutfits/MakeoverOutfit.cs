using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.MakeoverOutfits;

public class MakeoverOutfit
{
	public string Id;

	public List<MakeoverItem> OutfitParts;

	[ContentSerializer(Optional = true)]
	public Gender? Gender;
}
