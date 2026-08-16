using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buffs;

public class BuffData
{
	public string DisplayName;

	[ContentSerializer(Optional = true)]
	public string Description;

	[ContentSerializer(Optional = true)]
	public bool IsDebuff;

	[ContentSerializer(Optional = true)]
	public string GlowColor;

	public int Duration;

	[ContentSerializer(Optional = true)]
	public int MaxDuration = -1;

	public string IconTexture;

	public int IconSpriteIndex;

	[ContentSerializer(Optional = true)]
	public BuffAttributesData Effects;

	[ContentSerializer(Optional = true)]
	public List<string> ActionsOnApply;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
