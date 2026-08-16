using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Tools;

public class ToolData
{
	public string ClassName;

	public string Name;

	[ContentSerializer(Optional = true)]
	public int AttachmentSlots = -1;

	[ContentSerializer(Optional = true)]
	public int SalePrice = -1;

	public string DisplayName;

	public string Description;

	public string Texture;

	public int SpriteIndex;

	[ContentSerializer(Optional = true)]
	public int MenuSpriteIndex = -1;

	[ContentSerializer(Optional = true)]
	public int UpgradeLevel = -1;

	[ContentSerializer(Optional = true)]
	public string ConventionalUpgradeFrom;

	[ContentSerializer(Optional = true)]
	public List<ToolUpgradeData> UpgradeFrom;

	[ContentSerializer(Optional = true)]
	public bool CanBeLostOnDeath;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> SetProperties;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> ModData;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
