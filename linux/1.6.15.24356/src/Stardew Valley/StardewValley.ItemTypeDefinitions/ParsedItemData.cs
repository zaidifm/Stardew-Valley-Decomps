using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.ItemTypeDefinitions;

public class ParsedItemData : IHaveItemTypeId
{
	private bool LoadedTexture;

	private Texture2D Texture;

	private Rectangle DefaultSourceRect;

	public readonly IItemDataDefinition ItemType;

	public readonly string ItemId;

	public readonly string QualifiedItemId;

	public readonly int SpriteIndex;

	public readonly string TextureName;

	public readonly string InternalName;

	public readonly string DisplayName;

	public readonly string Description;

	public readonly int Category;

	public readonly string ObjectType;

	public readonly object RawData;

	public readonly bool IsErrorItem;

	public readonly bool ExcludeFromRandomSale;

	public ParsedItemData(IItemDataDefinition itemType, string itemId, int spriteIndex, string textureName, string internalName, string displayName, string description, int category, string objectType, object rawData, bool isErrorItem = false, bool excludeFromRandomSale = false)
	{
		string text = itemType.Identifier + itemId;
		if (string.IsNullOrWhiteSpace(internalName))
		{
			internalName = text;
		}
		if (string.IsNullOrWhiteSpace(displayName))
		{
			displayName = ItemRegistry.GetUnnamedItemName(text);
		}
		ItemType = itemType;
		ItemId = itemId;
		QualifiedItemId = text;
		SpriteIndex = spriteIndex;
		TextureName = textureName;
		InternalName = internalName;
		DisplayName = displayName;
		Description = description;
		Category = category;
		ObjectType = objectType;
		RawData = rawData;
		IsErrorItem = isErrorItem;
		ExcludeFromRandomSale = excludeFromRandomSale;
		if (IsErrorItem)
		{
			LoadedTexture = true;
		}
	}

	public string GetItemTypeId()
	{
		return ItemType.Identifier;
	}

	public virtual Texture2D GetTexture()
	{
		if (!IsErrorItem)
		{
			LoadTextureIfNeeded();
			Texture2D texture = Texture;
			if (texture != null)
			{
				return texture;
			}
		}
		return ItemType.GetErrorTexture();
	}

	public virtual string GetTextureName()
	{
		if (!IsErrorItem)
		{
			LoadTextureIfNeeded();
			string textureName = TextureName;
			if (Texture != null && textureName != null)
			{
				return textureName;
			}
		}
		return ItemType.GetErrorTextureName();
	}

	public virtual Rectangle GetSourceRect(int offset = 0, int? spriteIndex = null)
	{
		if (!IsErrorItem)
		{
			LoadTextureIfNeeded();
			if (Texture != null)
			{
				if (offset != 0 || (spriteIndex.HasValue && spriteIndex != SpriteIndex))
				{
					return ItemType.GetSourceRect(this, Texture, (spriteIndex ?? SpriteIndex) + offset);
				}
				return DefaultSourceRect;
			}
		}
		return ItemType.GetErrorSourceRect();
	}

	public virtual bool HasCategory()
	{
		return Category < -1;
	}

	protected virtual void LoadTextureIfNeeded()
	{
		if (!LoadedTexture)
		{
			if (IsErrorItem)
			{
				Texture = null;
				DefaultSourceRect = Rectangle.Empty;
				LoadedTexture = true;
			}
			else
			{
				Texture = TryLoadTexture();
				DefaultSourceRect = ((Texture == null) ? Rectangle.Empty : ItemType.GetSourceRect(this, Texture, SpriteIndex));
				LoadedTexture = true;
			}
		}
	}

	protected virtual Texture2D TryLoadTexture()
	{
		string textureName = TextureName;
		try
		{
			if (!Game1.content.DoesAssetExist<Texture2D>(textureName))
			{
				Game1.log.Error($"Failed loading texture {textureName} for item {QualifiedItemId}: asset doesn't exist.");
				return null;
			}
			return Game1.content.Load<Texture2D>(textureName);
		}
		catch (Exception exception)
		{
			Game1.log.Error($"Failed loading texture {textureName} for item {QualifiedItemId}.", exception);
			return null;
		}
	}
}
