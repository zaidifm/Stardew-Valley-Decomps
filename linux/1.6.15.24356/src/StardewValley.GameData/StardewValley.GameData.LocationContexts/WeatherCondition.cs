using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.LocationContexts;

public class WeatherCondition
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	public string Weather;
}
