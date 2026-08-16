using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Extensions;
using StardewValley.GameData.Tools;
using StardewValley.TokenizableStrings;
using StardewValley.Tools;

namespace StardewValley.ItemTypeDefinitions;

public class ToolDataDefinition : BaseItemDataDefinition
{
	public override string Identifier => "(T)";

	public override IEnumerable<string> GetAllIds()
	{
		return Game1.toolData.Keys;
	}

	public override bool Exists(string itemId)
	{
		if (itemId != null)
		{
			return Game1.toolData.ContainsKey(itemId);
		}
		return false;
	}

	public override ParsedItemData GetData(string itemId)
	{
		ToolData rawData = GetRawData(itemId);
		if (rawData == null)
		{
			return null;
		}
		return new ParsedItemData(this, itemId, (rawData.MenuSpriteIndex > -1) ? rawData.MenuSpriteIndex : rawData.SpriteIndex, rawData.Texture, itemId, TokenParser.ParseText(rawData.DisplayName), TokenParser.ParseText(rawData.Description), -99, null, rawData);
	}

	public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Game1.getSquareSourceRectForNonStandardTileSheet(texture, 16, 16, spriteIndex);
	}

	public override Item CreateItem(ParsedItemData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		ToolData rawData = GetRawData(data.ItemId);
		Tool tool = CreateToolInstance(data, rawData);
		if (tool == null)
		{
			return GetErrorTool(data);
		}
		tool.ItemId = data.ItemId;
		tool.SetSpriteIndex(rawData.SpriteIndex);
		if (rawData.MenuSpriteIndex > -1)
		{
			tool.IndexOfMenuItemView = rawData.MenuSpriteIndex;
		}
		tool.Name = rawData.Name;
		if (rawData.UpgradeLevel > -1)
		{
			tool.UpgradeLevel = rawData.UpgradeLevel;
		}
		if (rawData.AttachmentSlots > -1)
		{
			tool.AttachmentSlotsCount = rawData.AttachmentSlots;
		}
		if (rawData.SetProperties != null)
		{
			Type type = tool.GetType();
			foreach (KeyValuePair<string, string> setProperty in rawData.SetProperties)
			{
				TrySetProperty(type, tool, setProperty.Key, setProperty.Value);
			}
		}
		if (rawData.ModData != null)
		{
			foreach (KeyValuePair<string, string> modDatum in rawData.ModData)
			{
				tool.modData[modDatum.Key] = modDatum.Value;
			}
		}
		return tool;
	}

	protected ToolData GetRawData(string itemId)
	{
		if (itemId == null || !Game1.toolData.TryGetValue(itemId, out var value))
		{
			return null;
		}
		return value;
	}

	protected Tool CreateToolInstance(ParsedItemData itemData, ToolData toolData)
	{
		if (itemData != null && toolData != null)
		{
			Type type = typeof(Tool).Assembly.GetType("StardewValley.Tools." + toolData.ClassName);
			if (type != null)
			{
				Tool tool = (Tool)Activator.CreateInstance(type);
				if (tool != null)
				{
					return tool;
				}
			}
		}
		return GetErrorTool(itemData);
	}

	protected Tool GetErrorTool(ParsedItemData data)
	{
		return new ErrorTool(data.ItemId);
	}

	protected void TrySetProperty(Type type, Tool tool, string name, string rawValue)
	{
		MemberInfo memberInfo = (MemberInfo)(((object)type.GetProperty(name)) ?? ((object)type.GetField(name)));
		string error;
		if (memberInfo == null)
		{
			Game1.log.Error($"Can't set field or property '{name}' for tool '{tool.QualifiedItemId}': the {type.FullName} class has none public with that name");
		}
		else if (!memberInfo.TrySetValueFromString(tool, rawValue, null, out error))
		{
			Game1.log.Error($"Can't set {((memberInfo is FieldInfo) ? "field" : "property")} '{name}' for tool '{tool.QualifiedItemId}': {error}.");
		}
	}
}
