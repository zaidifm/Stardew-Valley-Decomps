using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.MakeoverOutfits;

public class MakeoverItem
{
	public string Id;

	public string ItemId;

	[ContentSerializer(Optional = true)]
	public string Color;

	[ContentSerializer(Optional = true)]
	public Gender? Gender;

	public bool MatchesGender(Gender gender)
	{
		Gender? gender2 = Gender;
		if (gender2.HasValue)
		{
			return Gender == gender;
		}
		return true;
	}
}
