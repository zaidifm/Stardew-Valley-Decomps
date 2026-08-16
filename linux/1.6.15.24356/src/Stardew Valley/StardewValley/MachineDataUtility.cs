using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewValley.Delegates;
using StardewValley.Extensions;
using StardewValley.GameData;
using StardewValley.GameData.Machines;
using StardewValley.Internal;
using StardewValley.Inventories;
using StardewValley.Objects;

namespace StardewValley;

public static class MachineDataUtility
{
	public delegate string GetOutputTokenValueDelegate(string key, Object machine, MachineItemOutput outputData, Item inputItem, Farmer who);

	public static readonly IDictionary<string, GetOutputTokenValueDelegate> OutputTokens = new Dictionary<string, GetOutputTokenValueDelegate>
	{
		["DROP_IN_ID"] = GetTokenValue,
		["DROP_IN_PRESERVE"] = GetTokenValue,
		["NEARBY_FLOWER_ID"] = GetTokenValue,
		["DROP_IN_QUALITY"] = GetTokenValue
	};

	public static bool HasAdditionalRequirements(IInventory inventory, IList<MachineItemAdditionalConsumedItems> requirements, out MachineItemAdditionalConsumedItems failedRequirement)
	{
		if (requirements != null && requirements.Count > 0)
		{
			foreach (MachineItemAdditionalConsumedItems requirement in requirements)
			{
				if (inventory.CountId(requirement.ItemId) < requirement.RequiredCount)
				{
					failedRequirement = requirement;
					return false;
				}
			}
		}
		failedRequirement = null;
		return true;
	}

	public static bool CanApplyOutput(Object machine, MachineOutputRule rule, MachineOutputTrigger trigger, Item inputItem, Farmer who, GameLocation location, out MachineOutputTriggerRule triggerRule, out bool matchesExceptCount)
	{
		matchesExceptCount = false;
		triggerRule = null;
		if (rule.Triggers == null)
		{
			return false;
		}
		foreach (MachineOutputTriggerRule trigger2 in rule.Triggers)
		{
			if (!trigger2.Trigger.HasFlag(trigger) || (trigger2.Condition != null && !GameStateQuery.CheckConditions(trigger2.Condition, location, who, null, inputItem)))
			{
				continue;
			}
			if (trigger.HasFlag(MachineOutputTrigger.ItemPlacedInMachine) || trigger.HasFlag(MachineOutputTrigger.OutputCollected))
			{
				if (trigger2.RequiredItemId != null && !ItemRegistry.HasItemId(inputItem, trigger2.RequiredItemId))
				{
					continue;
				}
				List<string> requiredTags = trigger2.RequiredTags;
				if (requiredTags != null && requiredTags.Count > 0 && !ItemContextTagManager.DoAllTagsMatch(trigger2.RequiredTags, inputItem.GetContextTags()))
				{
					continue;
				}
				if (trigger2.RequiredCount > inputItem.Stack)
				{
					triggerRule = trigger2;
					matchesExceptCount = true;
					continue;
				}
			}
			triggerRule = trigger2;
			matchesExceptCount = false;
			return true;
		}
		return false;
	}

	public static bool TryGetMachineOutputRule(Object machine, MachineData machineData, MachineOutputTrigger trigger, Item inputItem, Farmer who, GameLocation location, out MachineOutputRule rule, out MachineOutputTriggerRule triggerRule, out MachineOutputRule ruleIgnoringCount, out MachineOutputTriggerRule triggerIgnoringCount)
	{
		rule = null;
		triggerRule = null;
		ruleIgnoringCount = null;
		triggerIgnoringCount = null;
		if (machineData?.OutputRules == null)
		{
			return false;
		}
		foreach (MachineOutputRule outputRule in machineData.OutputRules)
		{
			if (CanApplyOutput(machine, outputRule, trigger, inputItem, who, location, out triggerRule, out var matchesExceptCount))
			{
				rule = outputRule;
				return true;
			}
			if (matchesExceptCount && (ruleIgnoringCount == null || (ruleIgnoringCount.InvalidCountMessage == null && outputRule.InvalidCountMessage != null)))
			{
				ruleIgnoringCount = outputRule;
				triggerIgnoringCount = triggerRule;
			}
		}
		return false;
	}

	public static MachineItemOutput GetOutputData(Object machine, MachineData machineData, MachineOutputRule outputRule, Item inputItem, Farmer who, GameLocation location)
	{
		if (outputRule == null && !TryGetMachineOutputRule(machine, machineData, MachineOutputTrigger.ItemPlacedInMachine, inputItem, who, location, out outputRule, out var _, out var _, out var _))
		{
			return null;
		}
		return GetOutputData(outputRule.OutputItem, outputRule.UseFirstValidOutput, inputItem, who, location);
	}

	public static MachineItemOutput GetOutputData(List<MachineItemOutput> outputs, bool useFirstValidOutput, Item inputItem, Farmer who, GameLocation location)
	{
		if (outputs == null || outputs.Count <= 0)
		{
			return null;
		}
		List<MachineItemOutput> list = ((!useFirstValidOutput) ? new List<MachineItemOutput>() : null);
		foreach (MachineItemOutput output in outputs)
		{
			if (GameStateQuery.CheckConditions(output.Condition, location, who, null, inputItem))
			{
				if (useFirstValidOutput)
				{
					return output;
				}
				list.Add(output);
			}
		}
		if (useFirstValidOutput)
		{
			return null;
		}
		return Game1.random.ChooseFrom(list);
	}

	public static Item GetOutputItem(Object machine, MachineItemOutput outputData, Item inputItem, Farmer who, bool probe, out int? overrideMinutesUntilReady)
	{
		overrideMinutesUntilReady = null;
		if (outputData == null)
		{
			return null;
		}
		ItemQueryContext context = new ItemQueryContext(machine.Location, who, Game1.random, "machine '" + machine.QualifiedItemId + "' > output rules");
		Item item;
		if (outputData.OutputMethod != null)
		{
			if (!StaticDelegateBuilder.TryCreateDelegate<MachineOutputDelegate>(outputData.OutputMethod, out var createdDelegate, out var error))
			{
				Game1.log.Warn($"Machine {machine.QualifiedItemId} has invalid item output method '{outputData.OutputMethod}': {error}");
				return null;
			}
			item = createdDelegate(machine, inputItem, probe, outputData, who, out overrideMinutesUntilReady);
			item = (Item)ItemQueryResolver.ApplyItemFields(item, outputData, context, inputItem);
		}
		else if (outputData.ItemId == "DROP_IN")
		{
			item = inputItem?.getOne();
			item = (Item)ItemQueryResolver.ApplyItemFields(item, outputData, context, inputItem);
		}
		else
		{
			item = ItemQueryResolver.TryResolveRandomItem(outputData, context, avoidRepeat: false, null, (string id) => FormatOutputId(id, machine, outputData, inputItem, who), inputItem, delegate(string query, string value)
			{
				Game1.log.Error($"Machine '{machine.QualifiedItemId}' failed parsing item query '{query}' for output '{outputData.Id}': {value}.");
			});
		}
		if (item == null)
		{
			return null;
		}
		if (outputData.CopyColor)
		{
			ColoredObject obj = inputItem as ColoredObject;
			Color? color = ((obj != null) ? new Color?(obj.color.Value) : ItemContextTagManager.GetColorFromTags(inputItem));
			if (color.HasValue && ColoredObject.TrySetColor(item, color.Value, out var coloredItem))
			{
				item = coloredItem;
			}
		}
		if (outputData.CopyQuality && inputItem != null)
		{
			item.Quality = inputItem.Quality;
			List<QuantityModifier> qualityModifiers = outputData.QualityModifiers;
			if (qualityModifiers != null && qualityModifiers.Count > 0)
			{
				item.Quality = (int)Utility.ApplyQuantityModifiers(item.Quality, outputData.QualityModifiers, outputData.QualityModifierMode, machine.Location, who, item, inputItem);
			}
		}
		if (item is Object obj2 && outputData.ObjectInternalName != null)
		{
			obj2.Name = string.Format(outputData.ObjectInternalName, inputItem?.Name ?? "");
		}
		if (item is Object obj3)
		{
			Object obj4 = inputItem as Object;
			if (outputData.CopyPrice && obj4 != null)
			{
				obj3.Price = obj4.Price;
			}
			List<QuantityModifier> priceModifiers = outputData.PriceModifiers;
			if (priceModifiers != null && priceModifiers.Count > 0)
			{
				obj3.Price = (int)Utility.ApplyQuantityModifiers(obj3.Price, outputData.PriceModifiers, outputData.PriceModifierMode, machine.Location, who, item, inputItem);
			}
			if (!string.IsNullOrWhiteSpace(outputData.PreserveType))
			{
				obj3.preserve.Value = (Object.PreserveType)Enum.Parse(typeof(Object.PreserveType), outputData.PreserveType);
			}
			if (!string.IsNullOrWhiteSpace(outputData.PreserveId))
			{
				string preserveId = outputData.PreserveId;
				if (!(preserveId == "DROP_IN"))
				{
					if (preserveId == "DROP_IN_PRESERVE")
					{
						obj3.preservedParentSheetIndex.Value = obj4?.GetPreservedItemId();
					}
					else
					{
						obj3.preservedParentSheetIndex.Value = outputData.PreserveId;
					}
				}
				else
				{
					obj3.preservedParentSheetIndex.Value = inputItem?.ItemId;
				}
			}
		}
		return item;
	}

	public static void UpdateStats(List<StatIncrement> stats, Item item, int amount)
	{
		if (stats == null)
		{
			return;
		}
		foreach (StatIncrement stat in stats)
		{
			if (stat.RequiredItemId == null || ItemRegistry.HasItemId(item, stat.RequiredItemId))
			{
				List<string> requiredTags = stat.RequiredTags;
				if (requiredTags == null || requiredTags.Count <= 0 || ItemContextTagManager.DoAllTagsMatch(stat.RequiredTags, item.GetContextTags()))
				{
					Game1.stats.Increment(stat.StatName, amount);
				}
			}
		}
	}

	public static bool PlayEffects(Object machine, MachineEffects effect, bool playSounds = true)
	{
		if (effect == null)
		{
			return false;
		}
		if (!GameStateQuery.CheckConditions(effect.Condition, machine.Location, null, inputItem: machine.lastInputItem.Value, targetItem: machine.heldObject.Value))
		{
			return false;
		}
		if (playSounds)
		{
			List<MachineSoundData> sounds = effect.Sounds;
			if (sounds != null && sounds.Count > 0)
			{
				foreach (MachineSoundData sound in effect.Sounds)
				{
					if (sound.Delay <= 0)
					{
						machine.Location.playSound(sound.Id, machine.TileLocation);
					}
					else
					{
						DelayedAction.playSoundAfterDelay(sound.Id, sound.Delay, machine.Location, machine.TileLocation);
					}
				}
			}
		}
		if (effect.ShakeDuration >= 0)
		{
			machine.shakeTimer = effect.ShakeDuration;
		}
		if (effect.TemporarySprites != null)
		{
			foreach (TemporaryAnimatedSpriteDefinition temporarySprite in effect.TemporarySprites)
			{
				if (GameStateQuery.CheckConditions(temporarySprite.Condition, machine.Location, null, inputItem: machine.lastInputItem.Value, targetItem: machine.heldObject.Value))
				{
					TemporaryAnimatedSprite temporaryAnimatedSprite = TemporaryAnimatedSprite.CreateFromData(temporarySprite, machine.tileLocation.X, machine.tileLocation.Y, (machine.tileLocation.Y + 1f) * 64f / 10000f);
					Game1.multiplayer.broadcastSprites(machine.Location, temporaryAnimatedSprite);
				}
			}
		}
		return true;
	}

	public static string FormatOutputId(string id, Object machine, MachineItemOutput outputData, Item inputItem, Farmer who)
	{
		if (string.IsNullOrWhiteSpace(id))
		{
			return id;
		}
		bool flag = false;
		string[] array = ArgUtility.SplitBySpace(id);
		for (int i = 0; i < array.Length; i++)
		{
			if (OutputTokens.TryGetValue(array[i], out var value))
			{
				string text = array[i];
				array[i] = value(array[i], machine, outputData, inputItem, who);
				flag = flag || array[i] != text;
			}
		}
		if (!flag)
		{
			return id;
		}
		return string.Join(" ", array);
	}

	private static string GetTokenValue(string key, Object machine, MachineItemOutput outputData, Item inputItem, Farmer who)
	{
		return key switch
		{
			"DROP_IN_ID" => inputItem?.QualifiedItemId ?? "0", 
			"DROP_IN_PRESERVE" => (inputItem as Object)?.GetPreservedItemId() ?? "0", 
			"NEARBY_FLOWER_ID" => GetNearbyFlowerItemId(machine) ?? "-1", 
			"DROP_IN_QUALITY" => (inputItem?.Quality).ToString() ?? "", 
			_ => key, 
		};
	}

	public static string GetNearbyFlowerItemId(Object machine)
	{
		return Utility.findCloseFlower(machine.Location, machine.tileLocation.Value, 5, (Crop curCrop) => !curCrop.forageCrop.Value)?.indexOfHarvest.Value;
	}
}
