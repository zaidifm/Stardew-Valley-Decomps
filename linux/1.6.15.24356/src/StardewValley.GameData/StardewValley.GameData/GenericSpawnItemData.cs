using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class GenericSpawnItemData : ISpawnItemData
{
	private string IdImpl;

	[ContentSerializer(Optional = true)]
	public string Id
	{
		get
		{
			if (IdImpl != null)
			{
				return IdImpl;
			}
			if (ItemId != null)
			{
				if (!IsRecipe)
				{
					return ItemId;
				}
				return ItemId + " (Recipe)";
			}
			List<string> randomItemId = RandomItemId;
			if (randomItemId != null && randomItemId.Count > 0)
			{
				if (!IsRecipe)
				{
					return string.Join("|", RandomItemId);
				}
				return string.Join("|", RandomItemId) + " (Recipe)";
			}
			return "???";
		}
		set
		{
			IdImpl = value;
		}
	}

	[ContentSerializer(Optional = true)]
	public string ItemId { get; set; }

	[ContentSerializer(Optional = true)]
	public List<string> RandomItemId { get; set; }

	[ContentSerializer(Optional = true)]
	public int? MaxItems { get; set; }

	[ContentSerializer(Optional = true)]
	public int MinStack { get; set; } = -1;

	[ContentSerializer(Optional = true)]
	public int MaxStack { get; set; } = -1;

	[ContentSerializer(Optional = true)]
	public int Quality { get; set; } = -1;

	[ContentSerializer(Optional = true)]
	public string ObjectInternalName { get; set; }

	[ContentSerializer(Optional = true)]
	public string ObjectDisplayName { get; set; }

	[ContentSerializer(Optional = true)]
	public string ObjectColor { get; set; }

	[ContentSerializer(Optional = true)]
	public int ToolUpgradeLevel { get; set; } = -1;

	[ContentSerializer(Optional = true)]
	public bool IsRecipe { get; set; }

	[ContentSerializer(Optional = true)]
	public List<QuantityModifier> StackModifiers { get; set; }

	[ContentSerializer(Optional = true)]
	public QuantityModifier.QuantityModifierMode StackModifierMode { get; set; }

	[ContentSerializer(Optional = true)]
	public List<QuantityModifier> QualityModifiers { get; set; }

	[ContentSerializer(Optional = true)]
	public QuantityModifier.QuantityModifierMode QualityModifierMode { get; set; }

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> ModData { get; set; }

	[ContentSerializer(Optional = true)]
	public string PerItemCondition { get; set; }
}
