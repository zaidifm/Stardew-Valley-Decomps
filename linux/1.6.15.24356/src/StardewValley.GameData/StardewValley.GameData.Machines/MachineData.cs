using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Machines;

public class MachineData
{
	[ContentSerializer(Optional = true)]
	public bool HasInput;

	[ContentSerializer(Optional = true)]
	public bool HasOutput;

	[ContentSerializer(Optional = true)]
	public string InteractMethod;

	[ContentSerializer(Optional = true)]
	public List<MachineOutputRule> OutputRules;

	[ContentSerializer(Optional = true)]
	public List<MachineItemAdditionalConsumedItems> AdditionalConsumedItems;

	[ContentSerializer(Optional = true)]
	public List<MachineTimeBlockers> PreventTimePass;

	[ContentSerializer(Optional = true)]
	public List<QuantityModifier> ReadyTimeModifiers;

	[ContentSerializer(Optional = true)]
	public QuantityModifier.QuantityModifierMode ReadyTimeModifierMode;

	[ContentSerializer(Optional = true)]
	public string InvalidItemMessage;

	[ContentSerializer(Optional = true)]
	public string InvalidItemMessageCondition;

	[ContentSerializer(Optional = true)]
	public string InvalidCountMessage;

	[ContentSerializer(Optional = true)]
	public List<MachineEffects> LoadEffects;

	[ContentSerializer(Optional = true)]
	public List<MachineEffects> WorkingEffects;

	[ContentSerializer(Optional = true)]
	public float WorkingEffectChance = 0.33f;

	[ContentSerializer(Optional = true)]
	public bool AllowLoadWhenFull;

	[ContentSerializer(Optional = true)]
	public bool WobbleWhileWorking = true;

	[ContentSerializer(Optional = true)]
	public MachineLight LightWhileWorking;

	[ContentSerializer(Optional = true)]
	public bool ShowNextIndexWhileWorking;

	[ContentSerializer(Optional = true)]
	public bool ShowNextIndexWhenReady;

	[ContentSerializer(Optional = true)]
	public bool AllowFairyDust = true;

	[ContentSerializer(Optional = true)]
	public bool IsIncubator;

	[ContentSerializer(Optional = true)]
	public bool OnlyCompleteOvernight;

	[ContentSerializer(Optional = true)]
	public string ClearContentsOvernightCondition;

	[ContentSerializer(Optional = true)]
	public List<StatIncrement> StatsToIncrementWhenLoaded;

	[ContentSerializer(Optional = true)]
	public List<StatIncrement> StatsToIncrementWhenHarvested;

	[ContentSerializer(Optional = true)]
	public string ExperienceGainOnHarvest;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
