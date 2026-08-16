using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Triggers;

namespace StardewValley.Buffs;

public class BuffManager : INetObject<NetFields>
{
	protected Farmer Player;

	protected readonly BuffEffects CombinedEffects = new BuffEffects();

	public readonly IDictionary<string, Buff> AppliedBuffs = new Dictionary<string, Buff>();

	public readonly NetStringList AppliedBuffIds = new NetStringList();

	public bool Dirty = true;

	public NetFields NetFields { get; } = new NetFields("BuffManager");

	public int CombatLevel => (int)GetValues().CombatLevel.Value;

	public int FarmingLevel => (int)GetValues().FarmingLevel.Value;

	public int FishingLevel => (int)GetValues().FishingLevel.Value;

	public int MiningLevel => (int)GetValues().MiningLevel.Value;

	public int LuckLevel => (int)GetValues().LuckLevel.Value;

	public int ForagingLevel => (int)GetValues().ForagingLevel.Value;

	public int MaxStamina => (int)GetValues().MaxStamina.Value;

	public int MagneticRadius => (int)GetValues().MagneticRadius.Value;

	public float Speed => GetValues().Speed.Value;

	public int Defense => (int)GetValues().Defense.Value;

	public int Attack => (int)GetValues().Attack.Value;

	public int Immunity => (int)GetValues().Immunity.Value;

	public float AttackMultiplier => GetValues().AttackMultiplier.Value;

	public float KnockbackMultiplier => GetValues().KnockbackMultiplier.Value;

	public float WeaponSpeedMultiplier => GetValues().WeaponSpeedMultiplier.Value;

	public float CriticalChanceMultiplier => GetValues().CriticalChanceMultiplier.Value;

	public float CriticalPowerMultiplier => GetValues().CriticalPowerMultiplier.Value;

	public float WeaponPrecisionMultiplier => GetValues().WeaponPrecisionMultiplier.Value;

	public BuffManager()
	{
		NetFields.SetOwner(this).AddField(AppliedBuffIds, "AppliedBuffIds").AddField(CombinedEffects.NetFields, "CombinedEffects.NetFields");
	}

	public virtual BuffEffects GetValues()
	{
		if (!Dirty)
		{
			return CombinedEffects;
		}
		Farmer player = Player;
		CombinedEffects.Clear();
		player.stopGlowing();
		foreach (Buff value in AppliedBuffs.Values)
		{
			CombinedEffects.Add(value.effects);
			if (value.glow != Color.White && value.glow.A > 0)
			{
				player.startGlowing(value.glow, border: false, 0.05f);
			}
		}
		AppliedBuffIds.Clear();
		foreach (string key in AppliedBuffs.Keys)
		{
			AppliedBuffIds.Add(key);
		}
		foreach (Item equippedItem in player.GetEquippedItems())
		{
			equippedItem.AddEquipmentEffects(CombinedEffects);
		}
		if (IsLocallyControlled())
		{
			Game1.buffsDisplay.dirty = true;
		}
		Dirty = false;
		player.stamina = Math.Min(player.stamina, player.MaxStamina);
		return CombinedEffects;
	}

	public void SetOwner(Farmer player)
	{
		Player = player;
	}

	public bool IsApplied(string id)
	{
		return AppliedBuffIds.Contains(id);
	}

	public bool HasBuffWithNameContaining(string idSubstring)
	{
		foreach (string appliedBuffId in AppliedBuffIds)
		{
			if (appliedBuffId.Contains(idSubstring))
			{
				return true;
			}
		}
		return false;
	}

	public virtual bool IsLocallyControlled()
	{
		return Player.UniqueMultiplayerID == Game1.player.UniqueMultiplayerID;
	}

	public void Apply(Buff buff)
	{
		if (buff == null)
		{
			Game1.log.Warn("Ignored invalid null buff.");
		}
		else if (string.IsNullOrWhiteSpace(buff.id))
		{
			Game1.log.Warn("Ignored invalid buff with no ID.");
		}
		else if (buff.millisecondsDuration <= 0 && buff.millisecondsDuration != -2)
		{
			Game1.log.Warn($"Ignored invalid buff '{buff.id}' with {((buff.millisecondsDuration < 0) ? "negative" : "no")} duration.");
		}
		else
		{
			if (!IsLocallyControlled())
			{
				return;
			}
			Remove(buff.id);
			AppliedBuffs[buff.id] = buff;
			AppliedBuffIds.Add(buff.id);
			string[] actionsOnApply = buff.actionsOnApply;
			if (actionsOnApply != null && actionsOnApply.Length != 0)
			{
				string[] actionsOnApply2 = buff.actionsOnApply;
				foreach (string text in actionsOnApply2)
				{
					if (TriggerActionManager.TryRunAction(text, out var error, out var exception))
					{
						Game1.log.Verbose($"Applied action [{text}] from buff '{buff.id}'.");
					}
					else
					{
						Game1.log.Error($"Error applying Applied action [{text}] from buff '{buff.id}': {error}.", exception);
					}
				}
			}
			Game1.buffsDisplay.updatedIDs.Add(buff.id);
			Dirty = true;
			buff.OnAdded();
		}
	}

	public void Remove(string id)
	{
		if (IsLocallyControlled())
		{
			if (AppliedBuffs.TryGetValue(id, out var value))
			{
				value.OnRemoved();
			}
			if (AppliedBuffs.Remove(id) | AppliedBuffIds.Remove(id) | Game1.buffsDisplay.updatedIDs.Remove(id))
			{
				Dirty = true;
			}
		}
	}

	public void Clear()
	{
		if (IsLocallyControlled())
		{
			for (int num = AppliedBuffIds.Count - 1; num >= 0; num--)
			{
				Remove(AppliedBuffIds[num]);
			}
		}
	}

	public void Update(GameTime time)
	{
		if (!IsLocallyControlled())
		{
			return;
		}
		for (int num = AppliedBuffIds.Count - 1; num >= 0; num--)
		{
			string text = AppliedBuffIds[num];
			if (!AppliedBuffs.TryGetValue(text, out var value) || value.update(time))
			{
				Remove(text);
			}
		}
		if (Dirty)
		{
			GetValues();
		}
	}
}
