using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buildings;

public class BuildingSkin
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Name;

	[ContentSerializer(Optional = true)]
	public string NameForGeneralType;

	[ContentSerializer(Optional = true)]
	public string Description;

	public string Texture;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public int? BuildDays;

	[ContentSerializer(Optional = true)]
	public int? BuildCost;

	[ContentSerializer(Optional = true)]
	public List<BuildingMaterial> BuildMaterials;

	[ContentSerializer(Optional = true)]
	public bool ShowAsSeparateConstructionEntry;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> Metadata = new Dictionary<string, string>();
}
