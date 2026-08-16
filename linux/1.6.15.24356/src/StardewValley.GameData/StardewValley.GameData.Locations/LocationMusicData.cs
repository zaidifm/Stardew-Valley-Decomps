using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Locations;

public class LocationMusicData
{
	private string IdImpl;

	[ContentSerializer(Optional = true)]
	public string Id
	{
		get
		{
			return IdImpl ?? Track;
		}
		set
		{
			IdImpl = value;
		}
	}

	public string Track { get; set; }

	[ContentSerializer(Optional = true)]
	public string Condition { get; set; }
}
