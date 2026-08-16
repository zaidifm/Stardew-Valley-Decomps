using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Shirts;

public class ShirtData
{
	[ContentSerializer(Optional = true)]
	public string Name = "Shirt";

	[ContentSerializer(Optional = true)]
	public string DisplayName = "[LocalizedText Strings\\Shirts:Shirt_Name]";

	[ContentSerializer(Optional = true)]
	public string Description = "[LocalizedText Strings\\Shirts:Shirt_Description]";

	[ContentSerializer(Optional = true)]
	public int Price = 50;

	[ContentSerializer(Optional = true)]
	public string Texture;

	public int SpriteIndex;

	[ContentSerializer(Optional = true)]
	public string DefaultColor;

	[ContentSerializer(Optional = true)]
	public bool CanBeDyed;

	[ContentSerializer(Optional = true)]
	public bool IsPrismatic;

	[ContentSerializer(Optional = true)]
	public bool HasSleeves = true;

	[ContentSerializer(Optional = true)]
	public bool CanChooseDuringCharacterCustomization;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
