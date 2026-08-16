using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Machines;

public class MachineItemOutput : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomData;

	[ContentSerializer(Optional = true)]
	public string OutputMethod { get; set; }

	[ContentSerializer(Optional = true)]
	public bool CopyColor { get; set; }

	[ContentSerializer(Optional = true)]
	public bool CopyPrice { get; set; }

	[ContentSerializer(Optional = true)]
	public bool CopyQuality { get; set; }

	[ContentSerializer(Optional = true)]
	public string PreserveType { get; set; }

	[ContentSerializer(Optional = true)]
	public string PreserveId { get; set; }

	[ContentSerializer(Optional = true)]
	public int IncrementMachineParentSheetIndex { get; set; }

	[ContentSerializer(Optional = true)]
	public List<QuantityModifier> PriceModifiers { get; set; }

	[ContentSerializer(Optional = true)]
	public QuantityModifier.QuantityModifierMode PriceModifierMode { get; set; }
}
