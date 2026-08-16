using System.Diagnostics.CodeAnalysis;
using StardewValley.ItemTypeDefinitions;

namespace StardewValley.Extensions;

public static class ItemExtensions
{
	public static bool HasTypeId([NotNullWhen(true)] this IHaveItemTypeId item, string typeId)
	{
		return item?.GetItemTypeId() == typeId;
	}

	public static bool HasTypeObject([NotNullWhen(true)] this IHaveItemTypeId item)
	{
		return item.HasTypeId("(O)");
	}

	public static bool HasTypeBigCraftable([NotNullWhen(true)] this IHaveItemTypeId item)
	{
		return item.HasTypeId("(BC)");
	}
}
