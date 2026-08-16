using System;
using Microsoft.Xna.Framework;
using StardewValley.Companions;
using StardewValley.Monsters;
using StardewValley.TokenizableStrings;

namespace StardewValley.Objects.Trinkets;

public class TrinketEffect
{
	public Trinket Trinket;

	public int GeneralStat;

	public Companion Companion;

	public TrinketEffect(Trinket trinket)
	{
		Trinket = trinket;
	}

	public virtual void OnUse(Farmer farmer)
	{
	}

	public virtual void Apply(Farmer farmer)
	{
		if (Trinket.ItemId == "ParrotEgg")
		{
			Companion = new FlyingCompanion(1);
			if (Game1.gameMode == 3)
			{
				farmer.AddCompanion(Companion);
			}
		}
	}

	public virtual void Unapply(Farmer farmer)
	{
		farmer.RemoveCompanion(Companion);
	}

	public virtual void OnFootstep(Farmer farmer)
	{
	}

	public virtual void OnReceiveDamage(Farmer farmer, int damageAmount)
	{
	}

	public virtual void OnDamageMonster(Farmer farmer, Monster monster, int damageAmount, bool isBomb, bool isCriticalHit)
	{
		if (Trinket.ItemId == "ParrotEgg" && monster != null && monster.Health <= 0)
		{
			double num = (double)(GeneralStat + 1) * 0.1;
			while (Game1.random.NextDouble() <= num)
			{
				monster.objectsToDrop.Add("GoldCoin");
			}
		}
	}

	public virtual bool GenerateRandomStats(Trinket trinket)
	{
		Random random = Utility.CreateRandom(trinket.generationSeed.Value);
		string itemId = trinket.ItemId;
		if (!(itemId == "IridiumSpur"))
		{
			if (itemId == "ParrotEgg")
			{
				int num = Math.Min(4, (int)(1 + Game1.player.totalMoneyEarned / 750000));
				int generalStat = GeneralStat;
				GeneralStat = random.Next(0, num);
				trinket.descriptionSubstitutionTemplates.Clear();
				trinket.descriptionSubstitutionTemplates.Add((GeneralStat + 1).ToString());
				trinket.descriptionSubstitutionTemplates.Add(TokenStringBuilder.LocalizedText("Strings\\1_6_Strings:ParrotEgg_Chance_" + GeneralStat));
				if (num <= 1)
				{
					return GeneralStat != generalStat;
				}
				return true;
			}
			return false;
		}
		GeneralStat = random.Next(5, 11);
		trinket.descriptionSubstitutionTemplates.Clear();
		trinket.descriptionSubstitutionTemplates.Add(GeneralStat.ToString());
		return true;
	}

	public virtual void Update(Farmer farmer, GameTime time, GameLocation location)
	{
	}
}
