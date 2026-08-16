using System.Collections.Generic;
using StardewValley.ItemTypeDefinitions;

namespace StardewValley.Extensions;

public static class ItemRegistryExtensions
{
	public static IEnumerable<ParsedItemData> GetAllData(this IItemDataDefinition definition)
	{
		foreach (string allId in definition.GetAllIds())
		{
			yield return ItemRegistry.GetDataOrErrorItem(definition.Identifier + allId);
		}
	}
}
