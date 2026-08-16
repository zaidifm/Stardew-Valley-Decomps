using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.ItemTypeDefinitions;

public abstract class BaseItemDataDefinition : IItemDataDefinition
{
	public Dictionary<string, ParsedItemData> ParsedItemCache = new Dictionary<string, ParsedItemData>();

	public abstract string Identifier { get; }

	public virtual string StandardDescriptor => null;

	public abstract IEnumerable<string> GetAllIds();

	public abstract bool Exists(string itemId);

	public abstract ParsedItemData GetData(string itemId);

	public ParsedItemData GetErrorData(string itemId)
	{
		return new ParsedItemData(this, itemId, 0, GetErrorTextureName(), "ErrorItem", ItemRegistry.GetErrorItemName(itemId), "???", -1, null, null, isErrorItem: true);
	}

	public abstract Item CreateItem(ParsedItemData data);

	public abstract Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex);

	public virtual Texture2D GetErrorTexture()
	{
		return Game1.mouseCursors;
	}

	public virtual string GetErrorTextureName()
	{
		return "LooseSprites\\Cursors";
	}

	public virtual Rectangle GetErrorSourceRect()
	{
		return new Rectangle(320, 496, 16, 16);
	}
}
