using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Movies;

public class MovieData
{
	[ContentSerializer(Optional = true)]
	public string Id;

	[ContentSerializer(Optional = true)]
	public List<Season> Seasons;

	[ContentSerializer(Optional = true)]
	public int? YearModulus;

	[ContentSerializer(Optional = true)]
	public int? YearRemainder;

	[ContentSerializer(Optional = true)]
	public string Texture;

	public int SheetIndex;

	public string Title;

	public string Description;

	[ContentSerializer(Optional = true)]
	public List<string> Tags;

	[ContentSerializer(Optional = true)]
	public List<MovieCranePrizeData> CranePrizes = new List<MovieCranePrizeData>();

	[ContentSerializer(Optional = true)]
	public List<int> ClearDefaultCranePrizeGroups = new List<int>();

	public List<MovieScene> Scenes;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
