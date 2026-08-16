using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class JukeboxTrackData
{
	public string Name;

	[ContentSerializer(Optional = true)]
	public bool? Available;

	[ContentSerializer(Optional = true)]
	public List<string> AlternativeTrackIds;
}
