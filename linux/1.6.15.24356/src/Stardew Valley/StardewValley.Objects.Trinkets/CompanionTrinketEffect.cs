using System;
using StardewValley.Companions;
using StardewValley.Extensions;
using StardewValley.TokenizableStrings;

namespace StardewValley.Objects.Trinkets;

public class CompanionTrinketEffect : TrinketEffect
{
	public int Variant;

	public CompanionTrinketEffect(Trinket trinket)
		: base(trinket)
	{
	}

	public override bool GenerateRandomStats(Trinket trinket)
	{
		Random random = Utility.CreateRandom(trinket.generationSeed.Value);
		if (random.NextBool(0.2))
		{
			Variant = 0;
		}
		else if (random.NextBool(0.8))
		{
			Variant = random.Next(3);
		}
		else if (random.NextBool(0.8))
		{
			Variant = random.Next(3) + 3;
		}
		else
		{
			Variant = random.Next(2) + 6;
		}
		trinket.displayNameOverrideTemplate.Value = TokenStringBuilder.LocalizedText("Strings\\1_6_Strings:frog_variant_" + Variant);
		return true;
	}

	public override void Apply(Farmer farmer)
	{
		Companion = new HungryFrogCompanion(Variant);
		if (Game1.gameMode == 3)
		{
			farmer.AddCompanion(Companion);
		}
	}

	public override void Unapply(Farmer farmer)
	{
		farmer.RemoveCompanion(Companion);
	}
}
