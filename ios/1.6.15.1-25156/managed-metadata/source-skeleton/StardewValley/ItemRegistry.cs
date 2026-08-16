using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StardewValley.ItemTypeDefinitions;

namespace StardewValley;

public static class ItemRegistry
{
	private static readonly Dictionary<string, IItemDataDefinition> IdentifierLookup;

	private static readonly Dictionary<string, ItemMetadata> CachedItems;

	[NonInstancedStatic]
	public static readonly List<IItemDataDefinition> ItemTypes;

	public const string type_object = "(O)";

	public const string type_bigCraftable = "(BC)";

	public const string type_boots = "(B)";

	public const string type_floorpaper = "(FL)";

	public const string type_furniture = "(F)";

	public const string type_hat = "(H)";

	public const string type_mannequin = "(M)";

	public const string type_pants = "(P)";

	public const string type_shirt = "(S)";

	public const string type_tool = "(T)";

	public const string type_trinket = "(TR)";

	public const string type_wallpaper = "(WP)";

	public const string type_weapon = "(W)";

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterItemTypes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddTypeDefinition(IItemDataDefinition definition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IItemDataDefinition GetTypeDefinition(string identifier)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IItemDataDefinition RequireTypeDefinition(string identifier)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TItemDataDefinition RequireTypeDefinition<TItemDataDefinition>(string identifier) where TItemDataDefinition : class, IItemDataDefinition
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ObjectDataDefinition GetObjectTypeDefinition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetCache()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasItemId(Item item, string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsQualifiedItemId(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string QualifyItemId(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ManuallyQualifyItemId(string itemId, string typeDefinitionId, bool overrideIfQualified = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ItemMetadata GetMetadata(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Exists(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ItemMetadata ResolveMetadata(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IItemDataDefinition GetTypeDefinitionFor(ItemMetadata metadata)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ParsedItemData GetData(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ParsedItemData GetDataOrErrorItem(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item Create(string itemId, int amount = 1, int quality = 0, bool allowNull = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TItem Create<TItem>(string itemId, int amount = 1, int quality = 0, bool allowNull = false) where TItem : Item
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetErrorItemName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetErrorItemName(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetUnnamedItemName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetUnnamedItemName(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RebuildCache()
	{
	}
}
