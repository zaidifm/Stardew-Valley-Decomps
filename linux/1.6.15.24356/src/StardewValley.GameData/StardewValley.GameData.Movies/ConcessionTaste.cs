using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Movies;

public class ConcessionTaste
{
	[ContentSerializerIgnore]
	public string Id => Name;

	public string Name { get; set; }

	[ContentSerializer(Optional = true)]
	public List<string> LovedTags { get; set; }

	[ContentSerializer(Optional = true)]
	public List<string> LikedTags { get; set; }

	[ContentSerializer(Optional = true)]
	public List<string> DislikedTags { get; set; }
}
