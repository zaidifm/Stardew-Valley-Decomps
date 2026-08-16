using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class PlantableRule
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public PlantableRuleContext PlantedIn = PlantableRuleContext.Any;

	public PlantableResult Result;

	[ContentSerializer(Optional = true)]
	public string DeniedMessage;

	public bool ShouldApplyWhen(bool isGardenPot)
	{
		return PlantedIn.HasFlag((!isGardenPot) ? PlantableRuleContext.Ground : PlantableRuleContext.GardenPot);
	}
}
