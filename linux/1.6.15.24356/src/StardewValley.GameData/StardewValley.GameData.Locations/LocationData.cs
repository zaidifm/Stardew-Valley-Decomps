using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Locations;

public class LocationData
{
	[ContentSerializer(Optional = true)]
	public string DisplayName;

	[ContentSerializer(Optional = true)]
	public Point? DefaultArrivalTile;

	[ContentSerializer(Optional = true)]
	public bool ExcludeFromNpcPathfinding;

	[ContentSerializer(Optional = true)]
	public CreateLocationData CreateOnLoad;

	[ContentSerializer(Optional = true)]
	public List<string> FormerLocationNames = new List<string>();

	[ContentSerializer(Optional = true)]
	public bool? CanPlantHere;

	[ContentSerializer(Optional = true)]
	public bool CanHaveGreenRainSpawns = true;

	[ContentSerializer(Optional = true)]
	public List<ArtifactSpotDropData> ArtifactSpots = new List<ArtifactSpotDropData>();

	[ContentSerializer(Optional = true)]
	public Dictionary<string, FishAreaData> FishAreas = new Dictionary<string, FishAreaData>();

	[ContentSerializer(Optional = true)]
	public List<SpawnFishData> Fish = new List<SpawnFishData>();

	[ContentSerializer(Optional = true)]
	public List<SpawnForageData> Forage = new List<SpawnForageData>();

	[ContentSerializer(Optional = true)]
	public int MinDailyWeeds = 2;

	[ContentSerializer(Optional = true)]
	public int MaxDailyWeeds = 5;

	[ContentSerializer(Optional = true)]
	public int FirstDayWeedMultiplier = 15;

	[ContentSerializer(Optional = true)]
	public int MinDailyForageSpawn = 1;

	[ContentSerializer(Optional = true)]
	public int MaxDailyForageSpawn = 4;

	[ContentSerializer(Optional = true)]
	public int MaxSpawnedForageAtOnce = 6;

	[ContentSerializer(Optional = true)]
	public double ChanceForClay = 0.03;

	[ContentSerializer(Optional = true)]
	public List<LocationMusicData> Music = new List<LocationMusicData>();

	[ContentSerializer(Optional = true)]
	public string MusicDefault;

	[ContentSerializer(Optional = true)]
	public MusicContext MusicContext;

	[ContentSerializer(Optional = true)]
	public bool MusicIgnoredInRain;

	[ContentSerializer(Optional = true)]
	public bool MusicIgnoredInSpring;

	[ContentSerializer(Optional = true)]
	public bool MusicIgnoredInSummer;

	[ContentSerializer(Optional = true)]
	public bool MusicIgnoredInFall;

	[ContentSerializer(Optional = true)]
	public bool MusicIgnoredInFallDebris;

	[ContentSerializer(Optional = true)]
	public bool MusicIgnoredInWinter;

	[ContentSerializer(Optional = true)]
	public bool MusicIsTownTheme;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
