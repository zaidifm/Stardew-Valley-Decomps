using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using StardewValley.GameData.Locations;

namespace StardewValley.GameData.LocationContexts;

public class LocationContextData
{
	[ContentSerializer(Optional = true)]
	public Season? SeasonOverride;

	[ContentSerializer(Optional = true)]
	public string DefaultMusic;

	[ContentSerializer(Optional = true)]
	public string DefaultMusicCondition;

	[ContentSerializer(Optional = true)]
	public bool DefaultMusicDelayOneScreen = true;

	[ContentSerializer(Optional = true)]
	public List<LocationMusicData> Music = new List<LocationMusicData>();

	[ContentSerializer(Optional = true)]
	public string DayAmbience;

	[ContentSerializer(Optional = true)]
	public string NightAmbience;

	[ContentSerializer(Optional = true)]
	public bool PlayRandomAmbientSounds = true;

	[ContentSerializer(Optional = true)]
	public bool AllowRainTotem = true;

	[ContentSerializer(Optional = true)]
	public string RainTotemAffectsContext;

	[ContentSerializer(Optional = true)]
	public List<WeatherCondition> WeatherConditions = new List<WeatherCondition>();

	[ContentSerializer(Optional = true)]
	public string CopyWeatherFromLocation;

	[ContentSerializer(Optional = true)]
	public List<ReviveLocation> ReviveLocations;

	[ContentSerializer(Optional = true)]
	public int MaxPassOutCost = -1;

	[ContentSerializer(Optional = true)]
	public List<PassOutMailData> PassOutMail;

	[ContentSerializer(Optional = true)]
	public List<ReviveLocation> PassOutLocations;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
