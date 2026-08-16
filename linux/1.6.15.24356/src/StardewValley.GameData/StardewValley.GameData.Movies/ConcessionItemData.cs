using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Movies;

public class ConcessionItemData
{
	public string Id;

	public string Name;

	public string DisplayName;

	public string Description;

	public int Price;

	public string Texture;

	public int SpriteIndex;

	[ContentSerializer(Optional = true)]
	public List<string> ItemTags;
}
