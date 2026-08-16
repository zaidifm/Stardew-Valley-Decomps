using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using StardewValley.ItemTypeDefinitions;

namespace StardewValley.Extensions;

public static class ItemExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasTypeId([NotNullWhen(true)] this IHaveItemTypeId item, string typeId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasTypeObject([NotNullWhen(true)] this IHaveItemTypeId item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasTypeBigCraftable([NotNullWhen(true)] this IHaveItemTypeId item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
