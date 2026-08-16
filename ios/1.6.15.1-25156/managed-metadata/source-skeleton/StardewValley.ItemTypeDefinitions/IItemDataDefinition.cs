using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.ItemTypeDefinitions;

public interface IItemDataDefinition
{
	string Identifier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	string StandardDescriptor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerable<string> GetAllIds();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool Exists(string itemId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	ParsedItemData GetData(string itemId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	ParsedItemData GetErrorData(string itemId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	Item CreateItem(ParsedItemData data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex);

	[MethodImpl(MethodImplOptions.NoInlining)]
	Texture2D GetErrorTexture();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetErrorTextureName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	Rectangle GetErrorSourceRect();
}
