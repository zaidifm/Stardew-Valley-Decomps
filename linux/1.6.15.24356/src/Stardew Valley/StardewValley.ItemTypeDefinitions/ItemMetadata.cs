using System;

namespace StardewValley.ItemTypeDefinitions;

public class ItemMetadata
{
	private ParsedItemData ParsedData;

	private bool IsParsedDataLoaded;

	private IItemDataDefinition TypeDefinition;

	private bool IsTypeResolveAttempted;

	private bool TypeDefinitionContainsItem;

	public string LocalItemId { get; }

	public string QualifiedItemId { get; }

	public string TypeIdentifier { get; private set; }

	public ItemMetadata(string qualifiedItemId, string localItemId, string typeIdentifier)
	{
		QualifiedItemId = qualifiedItemId;
		LocalItemId = localItemId;
		TypeIdentifier = typeIdentifier;
	}

	internal void SetTypeDefinition(string typeIdentifier, IItemDataDefinition typeDefinition, bool? itemExists = null)
	{
		TypeIdentifier = typeIdentifier;
		TypeDefinition = typeDefinition;
		IsTypeResolveAttempted = true;
		TypeDefinitionContainsItem = itemExists ?? typeDefinition?.Exists(LocalItemId) ?? false;
	}

	public IItemDataDefinition GetTypeDefinition()
	{
		if (!IsTypeResolveAttempted)
		{
			IItemDataDefinition typeDefinitionFor = ItemRegistry.GetTypeDefinitionFor(this);
			SetTypeDefinition(typeDefinitionFor?.Identifier ?? TypeIdentifier, typeDefinitionFor);
		}
		return TypeDefinition;
	}

	public ParsedItemData GetParsedData()
	{
		if (!IsParsedDataLoaded)
		{
			if (!IsTypeResolveAttempted)
			{
				GetTypeDefinition();
			}
			if (TypeDefinition != null)
			{
				try
				{
					ParsedData = TypeDefinition.GetData(LocalItemId);
				}
				catch (Exception exception)
				{
					Game1.log.Error($"Item type '{TypeIdentifier}' failed parsing item with ID '{LocalItemId}', defaulting to error item.", exception);
					ParsedData = TypeDefinition.GetErrorData(LocalItemId);
				}
			}
			else
			{
				ParsedData = null;
			}
			IsParsedDataLoaded = true;
		}
		return ParsedData;
	}

	public ParsedItemData GetParsedOrErrorData()
	{
		return GetParsedData() ?? TypeDefinition.GetErrorData(LocalItemId);
	}

	public bool Exists()
	{
		if (!IsTypeResolveAttempted)
		{
			GetTypeDefinition();
		}
		return TypeDefinitionContainsItem;
	}

	public Item CreateItem(int amount = 1, int quality = 0)
	{
		if (!Exists())
		{
			return null;
		}
		return ItemRegistry.Create(QualifiedItemId, amount, quality);
	}

	public Item CreateItemOrErrorItem(int amount = 1, int quality = 0)
	{
		return ItemRegistry.Create(QualifiedItemId, amount, quality);
	}
}
