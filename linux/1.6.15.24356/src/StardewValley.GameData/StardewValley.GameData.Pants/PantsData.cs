using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Pants;

public class PantsData
{
	public string Name = "Pants";

	public string DisplayName = "[LocalizedText Strings\\Pants:Pants_Name]";

	public string Description = "[LocalizedText Strings\\Pants:Pants_Description]";

	[ContentSerializer(Optional = true)]
	public int Price = 50;

	[ContentSerializer(Optional = true)]
	public string Texture;

	public int SpriteIndex;

	[ContentSerializer(Optional = true)]
	public string DefaultColor = "255 235 203";

	[ContentSerializer(Optional = true)]
	public bool CanBeDyed;

	[ContentSerializer(Optional = true)]
	public bool IsPrismatic;

	[ContentSerializer(Optional = true)]
	public bool CanChooseDuringCharacterCustomization;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
