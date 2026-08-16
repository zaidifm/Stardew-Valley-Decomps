using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Locations;

public class SpawnFishData : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public float Chance { get; set; } = 1f;

	[ContentSerializer(Optional = true)]
	public Season? Season { get; set; }

	[ContentSerializer(Optional = true)]
	public string FishAreaId { get; set; }

	[ContentSerializer(Optional = true)]
	public Rectangle? BobberPosition { get; set; }

	[ContentSerializer(Optional = true)]
	public Rectangle? PlayerPosition { get; set; }

	[ContentSerializer(Optional = true)]
	public int MinFishingLevel { get; set; }

	[ContentSerializer(Optional = true)]
	public int MinDistanceFromShore { get; set; }

	[ContentSerializer(Optional = true)]
	public int MaxDistanceFromShore { get; set; } = -1;

	[ContentSerializer(Optional = true)]
	public bool ApplyDailyLuck { get; set; }

	[ContentSerializer(Optional = true)]
	public float CuriosityLureBuff { get; set; } = -1f;

	[ContentSerializer(Optional = true)]
	public float SpecificBaitBuff { get; set; }

	[ContentSerializer(Optional = true)]
	public float SpecificBaitMultiplier { get; set; } = 1.66f;

	[ContentSerializer(Optional = true)]
	public int CatchLimit { get; set; } = -1;

	[ContentSerializer(Optional = true)]
	public bool? CanUseTrainingRod { get; set; }

	[ContentSerializer(Optional = true)]
	public bool IsBossFish { get; set; }

	[ContentSerializer(Optional = true)]
	public string SetFlagOnCatch { get; set; }

	[ContentSerializer(Optional = true)]
	public bool RequireMagicBait { get; set; }

	[ContentSerializer(Optional = true)]
	public int Precedence { get; set; }

	[ContentSerializer(Optional = true)]
	public bool IgnoreFishDataRequirements { get; set; }

	[ContentSerializer(Optional = true)]
	public bool CanBeInherited { get; set; } = true;

	[ContentSerializer(Optional = true)]
	public List<QuantityModifier> ChanceModifiers { get; set; }

	[ContentSerializer(Optional = true)]
	public QuantityModifier.QuantityModifierMode ChanceModifierMode { get; set; }

	[ContentSerializer(Optional = true)]
	public float ChanceBoostPerLuckLevel { get; set; }

	[ContentSerializer(Optional = true)]
	public bool UseFishCaughtSeededRandom { get; set; }

	public float GetChance(bool hasCuriosityLure, double dailyLuck, int luckLevel, Func<float, IList<QuantityModifier>, QuantityModifier.QuantityModifierMode, float> applyModifiers, bool isTargetedWithBait = false)
	{
		float num = Chance;
		if (hasCuriosityLure && CuriosityLureBuff > 0f)
		{
			num += CuriosityLureBuff;
		}
		if (ApplyDailyLuck)
		{
			num += (float)dailyLuck;
		}
		List<QuantityModifier> chanceModifiers = ChanceModifiers;
		if (chanceModifiers != null && chanceModifiers.Count > 0)
		{
			num = applyModifiers(num, ChanceModifiers, ChanceModifierMode);
		}
		if (isTargetedWithBait)
		{
			num = num * SpecificBaitMultiplier + SpecificBaitBuff;
		}
		return num + ChanceBoostPerLuckLevel * (float)luckLevel;
	}
}
