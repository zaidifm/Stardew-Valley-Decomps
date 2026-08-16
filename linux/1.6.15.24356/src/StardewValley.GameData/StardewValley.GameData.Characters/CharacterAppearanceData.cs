using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Characters;

public class CharacterAppearanceData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public Season? Season;

	[ContentSerializer(Optional = true)]
	public bool Indoors = true;

	[ContentSerializer(Optional = true)]
	public bool Outdoors = true;

	[ContentSerializer(Optional = true)]
	public string Portrait;

	[ContentSerializer(Optional = true)]
	public string Sprite;

	[ContentSerializer(Optional = true)]
	public bool IsIslandAttire;

	[ContentSerializer(Optional = true)]
	public int Precedence;

	[ContentSerializer(Optional = true)]
	public int Weight = 1;
}
