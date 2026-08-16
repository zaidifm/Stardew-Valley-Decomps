using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.BigCraftables;

public class BigCraftableData
{
	public string Name;

	public string DisplayName;

	public string Description;

	[ContentSerializer(Optional = true)]
	public int Price;

	[ContentSerializer(Optional = true)]
	public int Fragility;

	[ContentSerializer(Optional = true)]
	public bool CanBePlacedOutdoors = true;

	[ContentSerializer(Optional = true)]
	public bool CanBePlacedIndoors = true;

	[ContentSerializer(Optional = true)]
	public bool IsLamp;

	[ContentSerializer(Optional = true)]
	public string Texture;

	public int SpriteIndex;

	[ContentSerializer(Optional = true)]
	public List<string> ContextTags;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
