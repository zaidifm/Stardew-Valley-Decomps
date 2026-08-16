using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class AudioCueData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public List<string> FilePaths;

	[ContentSerializer(Optional = true)]
	public string Category;

	[ContentSerializer(Optional = true)]
	public bool StreamedVorbis;

	[ContentSerializer(Optional = true)]
	public bool Looped;

	[ContentSerializer(Optional = true)]
	public bool UseReverb;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
