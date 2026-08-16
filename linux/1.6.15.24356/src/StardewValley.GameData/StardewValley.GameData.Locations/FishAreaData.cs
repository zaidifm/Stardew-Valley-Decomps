using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Locations;

public class FishAreaData
{
	[ContentSerializer(Optional = true)]
	public string DisplayName { get; set; }

	[ContentSerializer(Optional = true)]
	public Rectangle? Position { get; set; }

	[ContentSerializer(Optional = true)]
	public List<string> CrabPotFishTypes { get; set; } = new List<string>();

	[ContentSerializer(Optional = true)]
	public float CrabPotJunkChance { get; set; } = 0.2f;
}
