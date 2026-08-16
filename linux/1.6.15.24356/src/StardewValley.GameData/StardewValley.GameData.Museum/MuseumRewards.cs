using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Museum;

public class MuseumRewards
{
	public List<MuseumDonationRequirement> TargetContextTags;

	[ContentSerializer(Optional = true)]
	public string RewardItemId;

	[ContentSerializer(Optional = true)]
	public int RewardItemCount = 1;

	[ContentSerializer(Optional = true)]
	public bool RewardItemIsSpecial;

	[ContentSerializer(Optional = true)]
	public bool RewardItemIsRecipe;

	[ContentSerializer(Optional = true)]
	public List<string> RewardActions;

	[ContentSerializer(Optional = true)]
	public bool FlagOnCompletion;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
