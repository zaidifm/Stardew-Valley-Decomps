using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Movies;

public class MovieCharacterReaction
{
	[ContentSerializerIgnore]
	public string Id => NPCName;

	public string NPCName { get; set; }

	[ContentSerializer(Optional = true)]
	public List<MovieReaction> Reactions { get; set; }
}
