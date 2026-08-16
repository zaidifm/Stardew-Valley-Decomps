using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Objects;

public class ObjectData
{
	public string Name;

	public string DisplayName;

	public string Description;

	public string Type;

	public int Category;

	[ContentSerializer(Optional = true)]
	public int Price;

	[ContentSerializer(Optional = true)]
	public string Texture;

	public int SpriteIndex;

	[ContentSerializer(Optional = true)]
	public bool ColorOverlayFromNextIndex;

	[ContentSerializer(Optional = true)]
	public int Edibility = -300;

	[ContentSerializer(Optional = true)]
	public bool IsDrink;

	[ContentSerializer(Optional = true)]
	public List<ObjectBuffData> Buffs;

	[ContentSerializer(Optional = true)]
	public bool GeodeDropsDefaultItems;

	[ContentSerializer(Optional = true)]
	public List<ObjectGeodeDropData> GeodeDrops;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, float> ArtifactSpotChances;

	[ContentSerializer(Optional = true)]
	public bool CanBeGivenAsGift = true;

	[ContentSerializer(Optional = true)]
	public bool CanBeTrashed = true;

	[ContentSerializer(Optional = true)]
	public bool ExcludeFromFishingCollection;

	[ContentSerializer(Optional = true)]
	public bool ExcludeFromShippingCollection;

	[ContentSerializer(Optional = true)]
	public bool ExcludeFromRandomSale;

	[ContentSerializer(Optional = true)]
	public List<string> ContextTags;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
