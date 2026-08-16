using System.Collections.Generic;

namespace StardewValley.GameData;

public interface ISpawnItemData
{
	string ItemId { get; set; }

	List<string> RandomItemId { get; set; }

	int? MaxItems { get; set; }

	int MinStack { get; set; }

	int MaxStack { get; set; }

	int Quality { get; set; }

	string ObjectInternalName { get; set; }

	string ObjectDisplayName { get; set; }

	string ObjectColor { get; set; }

	int ToolUpgradeLevel { get; set; }

	bool IsRecipe { get; set; }

	List<QuantityModifier> StackModifiers { get; set; }

	QuantityModifier.QuantityModifierMode StackModifierMode { get; set; }

	List<QuantityModifier> QualityModifiers { get; set; }

	QuantityModifier.QuantityModifierMode QualityModifierMode { get; set; }

	Dictionary<string, string> ModData { get; set; }

	string PerItemCondition { get; set; }
}
