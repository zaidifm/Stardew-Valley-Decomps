using System.Runtime.CompilerServices;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParsedItemData(IItemDataDefinition itemType, string itemId, int spriteIndex, string textureName, string internalName, string displayName, string description, int category, string objectType, object rawData, bool isErrorItem = false, bool excludeFromRandomSale = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetItemTypeId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Texture2D GetTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetTextureName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle GetSourceRect(int offset = 0, int? spriteIndex = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasCategory()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void LoadTextureIfNeeded()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Texture2D TryLoadTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
