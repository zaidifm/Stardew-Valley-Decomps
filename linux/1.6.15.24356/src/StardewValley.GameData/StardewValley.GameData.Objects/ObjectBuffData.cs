using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using StardewValley.GameData.Buffs;

namespace StardewValley.GameData.Objects;

public class ObjectBuffData
{
	private string IdImpl;

	[ContentSerializer(Optional = true)]
	public string Id
	{
		get
		{
			return IdImpl ?? BuffId;
		}
		set
		{
			IdImpl = value;
		}
	}

	[ContentSerializer(Optional = true)]
	public string BuffId { get; set; }

	[ContentSerializer(Optional = true)]
	public string IconTexture { get; set; }

	[ContentSerializer(Optional = true)]
	public int IconSpriteIndex { get; set; }

	[ContentSerializer(Optional = true)]
	public int Duration { get; set; }

	[ContentSerializer(Optional = true)]
	public bool IsDebuff { get; set; }

	[ContentSerializer(Optional = true)]
	public string GlowColor { get; set; }

	[ContentSerializer(Optional = true)]
	public BuffAttributesData CustomAttributes { get; set; }

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields { get; set; }
}
