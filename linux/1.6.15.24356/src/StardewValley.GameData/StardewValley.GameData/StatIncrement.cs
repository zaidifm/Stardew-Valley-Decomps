using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class StatIncrement
{
	private string IdImpl;

	[ContentSerializer(Optional = true)]
	public string Id
	{
		get
		{
			return IdImpl ?? StatName;
		}
		set
		{
			IdImpl = value;
		}
	}

	[ContentSerializer(Optional = true)]
	public string RequiredItemId { get; set; }

	[ContentSerializer(Optional = true)]
	public List<string> RequiredTags { get; set; }

	public string StatName { get; set; }
}
