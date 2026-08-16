using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.ItemTypeDefinitions;

public interface IItemDataDefinition
{
	string Identifier { get; }

	string StandardDescriptor { get; }

	IEnumerable<string> GetAllIds();

	bool Exists(string itemId);

	ParsedItemData GetData(string itemId);

	ParsedItemData GetErrorData(string itemId);

	Item CreateItem(ParsedItemData data);

	Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex);

	Texture2D GetErrorTexture();

	string GetErrorTextureName();

	Rectangle GetErrorSourceRect();
}
