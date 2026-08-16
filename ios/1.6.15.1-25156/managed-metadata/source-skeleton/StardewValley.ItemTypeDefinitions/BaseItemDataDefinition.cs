using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.ItemTypeDefinitions;

public abstract class BaseItemDataDefinition : IItemDataDefinition
{
	public Dictionary<string, ParsedItemData> ParsedItemCache;

	public abstract string Identifier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	public virtual string StandardDescriptor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract IEnumerable<string> GetAllIds();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract bool Exists(string itemId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract ParsedItemData GetData(string itemId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParsedItemData GetErrorData(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract Item CreateItem(ParsedItemData data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Texture2D GetErrorTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetErrorTextureName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle GetErrorSourceRect()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected BaseItemDataDefinition()
	{
	}
}
