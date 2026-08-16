using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Powers;

public class PowersData
{
	public string DisplayName;

	[ContentSerializer(Optional = true)]
	public string Description = "";

	public string TexturePath;

	public Point TexturePosition;

	public string UnlockedCondition;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, object> CustomFields;
}
