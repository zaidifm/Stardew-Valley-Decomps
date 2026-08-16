using System;
using System.Collections.Generic;
using StardewValley.ItemTypeDefinitions;

namespace StardewValley;

public static class ItemRegistry
{
	private static readonly Dictionary<string, IItemDataDefinition> IdentifierLookup = new Dictionary<string, IItemDataDefinition>();

	private static readonly Dictionary<string, ItemMetadata> CachedItems = new Dictionary<string, ItemMetadata>();

	[NonInstancedStatic]
	public static readonly List<IItemDataDefinition> ItemTypes = new List<IItemDataDefinition>();

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

	internal static void RegisterItemTypes()
	{
		IItemDataDefinition[] array = new IItemDataDefinition[13]
		{
			new ObjectDataDefinition(),
			new BigCraftableDataDefinition(),
			new FurnitureDataDefinition(),
			new WeaponDataDefinition(),
			new BootsDataDefinition(),
			new HatDataDefinition(),
			new MannequinDataDefinition(),
			new PantsDataDefinition(),
			new ShirtDataDefinition(),
			new ToolDataDefinition(),
			new TrinketDataDefinition(),
			new WallpaperDataDefinition(),
			new FlooringDataDefinition()
		};
		for (int i = 0; i < array.Length; i++)
		{
			AddTypeDefinition(array[i]);
		}
	}

	public static void AddTypeDefinition(IItemDataDefinition definition)
	{
		if (definition == null)
		{
			throw new ArgumentNullException("definition");
		}
		string identifier = definition.Identifier;
		if (string.IsNullOrWhiteSpace(identifier))
		{
			throw GetException("it has no identifier");
		}
		if (identifier.Length < 2 || identifier[0] != '(' || identifier[identifier.Length - 1] != ')')
		{
			throw GetException("its identifier must start with '(' and end with ')'");
		}
		if (identifier.IndexOf('(', 1) != -1 || identifier.IndexOf(')') != identifier.Length - 1)
		{
			throw GetException("its identifier can't contain '(' or ')' except as the first and last character respectively");
		}
		if (IdentifierLookup.ContainsKey(identifier))
		{
			throw GetException("its identifier is already registered");
		}
		ItemTypes.Add(definition);
		IdentifierLookup[identifier] = definition;
		ResetCache();
		InvalidOperationException GetException(string reason)
		{
			return new InvalidOperationException($"Can't add item data definition of type '{definition.GetType().FullName}'{((!string.IsNullOrWhiteSpace(definition.Identifier)) ? (" with identifier '" + definition.Identifier + "'") : "")} because {reason}.");
		}
	}

	public static IItemDataDefinition GetTypeDefinition(string identifier)
	{
		if (identifier == null)
		{
			return null;
		}
		return IdentifierLookup.GetValueOrDefault(identifier);
	}

	public static IItemDataDefinition RequireTypeDefinition(string identifier)
	{
		return GetTypeDefinition(identifier) ?? throw new KeyNotFoundException("No item type definition found with ID '" + identifier + "'.");
	}

	public static TItemDataDefinition RequireTypeDefinition<TItemDataDefinition>(string identifier) where TItemDataDefinition : class, IItemDataDefinition
	{
		IItemDataDefinition itemDataDefinition = GetTypeDefinition(identifier) ?? throw new KeyNotFoundException("No item type definition found with ID '" + identifier + "'.");
		return (itemDataDefinition as TItemDataDefinition) ?? throw new InvalidCastException($"The item type definition for ID '{identifier}' implements {itemDataDefinition.GetType().FullName}, but expected {typeof(TItemDataDefinition).FullName}.");
	}

	public static ObjectDataDefinition GetObjectTypeDefinition()
	{
		return RequireTypeDefinition<ObjectDataDefinition>("(O)");
	}

	public static void ResetCache()
	{
		CachedItems.Clear();
		ItemContextTagManager.ResetCache();
	}

	public static bool HasItemId(Item item, string itemId)
	{
		if (item == null)
		{
			return string.IsNullOrEmpty(itemId);
		}
		return item.QualifiedItemId == QualifyItemId(itemId);
	}

	public static bool IsQualifiedItemId(string itemId)
	{
		if (itemId != null && itemId.StartsWith('('))
		{
			return itemId.Contains(')');
		}
		return false;
	}

	public static string QualifyItemId(string itemId)
	{
		ItemMetadata metadata = GetMetadata(itemId);
		if (metadata == null)
		{
			return null;
		}
		if (metadata.QualifiedItemId != null)
		{
			return metadata.QualifiedItemId;
		}
		metadata.GetTypeDefinition();
		if (metadata.QualifiedItemId != null)
		{
			return metadata.QualifiedItemId;
		}
		if (!itemId.StartsWith('(') || !itemId.Contains(')'))
		{
			return null;
		}
		return itemId;
	}

	public static string ManuallyQualifyItemId(string itemId, string typeDefinitionId, bool overrideIfQualified = false)
	{
		if (string.IsNullOrWhiteSpace(itemId))
		{
			return itemId;
		}
		if (itemId.StartsWith('('))
		{
			if (!overrideIfQualified)
			{
				return itemId;
			}
			int num = itemId.IndexOf(')') + 1;
			if (num > 0)
			{
				return typeDefinitionId + itemId.Substring(num).Trim();
			}
		}
		return typeDefinitionId + itemId;
	}

	public static ItemMetadata GetMetadata(string itemId)
	{
		if (string.IsNullOrWhiteSpace(itemId))
		{
			return null;
		}
		if (CachedItems.Count == 0)
		{
			RebuildCache();
		}
		if (!CachedItems.TryGetValue(itemId, out var value))
		{
			if (itemId[0] == '(')
			{
				int num = itemId.IndexOf(')') + 1;
				if (num >= 0)
				{
					value = new ItemMetadata(itemId, itemId.Substring(num), itemId.Substring(0, num));
				}
			}
			else
			{
				value = new ItemMetadata(null, itemId, null);
			}
			CachedItems[itemId] = value;
		}
		return value;
	}

	public static bool Exists(string itemId)
	{
		return GetMetadata(itemId)?.Exists() ?? false;
	}

	public static ItemMetadata ResolveMetadata(string itemId)
	{
		ItemMetadata metadata = GetMetadata(itemId);
		if (metadata == null || !metadata.Exists())
		{
			return null;
		}
		return metadata;
	}

	internal static IItemDataDefinition GetTypeDefinitionFor(ItemMetadata metadata)
	{
		if (metadata.TypeIdentifier != null)
		{
			return GetTypeDefinition(metadata.TypeIdentifier);
		}
		foreach (IItemDataDefinition itemType in ItemTypes)
		{
			if (itemType.Exists(metadata.LocalItemId))
			{
				return itemType;
			}
		}
		return null;
	}

	public static ParsedItemData GetData(string itemId)
	{
		return ResolveMetadata(itemId)?.GetParsedData();
	}

	public static ParsedItemData GetDataOrErrorItem(string itemId)
	{
		ItemMetadata metadata = GetMetadata(itemId);
		IItemDataDefinition itemDataDefinition = metadata?.GetTypeDefinition();
		if (itemDataDefinition != null)
		{
			ParsedItemData parsedData = metadata.GetParsedData();
			if (parsedData != null)
			{
				return parsedData;
			}
		}
		return itemDataDefinition?.GetErrorData(metadata?.LocalItemId ?? itemId) ?? RequireTypeDefinition("(O)").GetErrorData(metadata?.LocalItemId ?? itemId);
	}

	public static Item Create(string itemId, int amount = 1, int quality = 0, bool allowNull = false)
	{
		ParsedItemData parsedItemData = (allowNull ? GetData(itemId) : GetDataOrErrorItem(itemId));
		if (parsedItemData == null || parsedItemData.IsErrorItem)
		{
			if (allowNull)
			{
				return null;
			}
			if (parsedItemData == null)
			{
				parsedItemData = RequireTypeDefinition("(O)").GetErrorData(itemId);
			}
		}
		Item item = parsedItemData.ItemType.CreateItem(parsedItemData);
		if (amount != 1)
		{
			item.Stack = amount;
			item.FixStackSize();
		}
		if (quality != 0)
		{
			item.Quality = quality;
			item.FixQuality();
		}
		return item;
	}

	public static TItem Create<TItem>(string itemId, int amount = 1, int quality = 0, bool allowNull = false) where TItem : Item
	{
		Item item = Create(itemId, amount, quality, allowNull);
		if (item != null)
		{
			if (item is TItem result)
			{
				return result;
			}
			throw new InvalidCastException($"Can't create item ID '{itemId}' as a {typeof(TItem).Name} type because it's a {item.GetType()} instance.");
		}
		return null;
	}

	public static string GetErrorItemName()
	{
		return Game1.content.LoadString("Strings\\StringsFromCSFiles:CraftingRecipe.cs.575");
	}

	public static string GetErrorItemName(string itemId)
	{
		return GetErrorItemName() + " (" + itemId + ")";
	}

	public static string GetUnnamedItemName()
	{
		return Game1.content.LoadString("Strings\\StringsFromCSFiles:UnnamedItem");
	}

	public static string GetUnnamedItemName(string itemId)
	{
		return GetUnnamedItemName() + " (" + itemId + ")";
	}

	private static void RebuildCache()
	{
		CachedItems.Clear();
		foreach (IItemDataDefinition itemType in ItemTypes)
		{
			string identifier = itemType.Identifier;
			foreach (string allId in itemType.GetAllIds())
			{
				string text = identifier + allId;
				ItemMetadata itemMetadata = new ItemMetadata(text, allId, identifier);
				itemMetadata.SetTypeDefinition(identifier, itemType, true);
				CachedItems[text] = itemMetadata;
				CachedItems.TryAdd(allId, itemMetadata);
			}
		}
	}
}
