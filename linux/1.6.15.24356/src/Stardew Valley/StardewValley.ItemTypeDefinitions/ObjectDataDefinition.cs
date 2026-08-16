using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.BellsAndWhistles;
using StardewValley.Extensions;
using StardewValley.GameData.Objects;
using StardewValley.Menus;
using StardewValley.Objects;
using StardewValley.TokenizableStrings;

namespace StardewValley.ItemTypeDefinitions;

public class ObjectDataDefinition : BaseItemDataDefinition
{
	public override string Identifier => "(O)";

	public override string StandardDescriptor => "O";

	public override IEnumerable<string> GetAllIds()
	{
		return Game1.objectData.Keys;
	}

	public override bool Exists(string itemId)
	{
		if (itemId != null)
		{
			return Game1.objectData.ContainsKey(itemId);
		}
		return false;
	}

	public override ParsedItemData GetData(string itemId)
	{
		ObjectData rawData = GetRawData(itemId);
		if (rawData == null)
		{
			return null;
		}
		int num = rawData.Category;
		if (num == 0 && rawData.Type == "Ring")
		{
			num = -96;
		}
		return new ParsedItemData(this, itemId, rawData.SpriteIndex, rawData.Texture ?? "Maps\\springobjects", rawData.Name, TokenParser.ParseText(rawData.DisplayName), TokenParser.ParseText(rawData.Description), num, rawData.Type, rawData, isErrorItem: false, rawData.ExcludeFromRandomSale);
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
		return Game1.getSourceRectForStandardTileSheet(texture, spriteIndex, 16, 16);
	}

	public override Item CreateItem(ParsedItemData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		string itemId = data.ItemId;
		HashSet<string> baseContextTags = ItemContextTagManager.GetBaseContextTags(itemId);
		if (baseContextTags.Contains("torch_item"))
		{
			return new Torch(1, itemId);
		}
		if (itemId == "812")
		{
			return new ColoredObject(itemId, 1, Color.Orange);
		}
		if (baseContextTags.Contains("item_type_ring") || itemId == "801")
		{
			if (!(itemId == "880"))
			{
				return new Ring(itemId);
			}
			return new CombinedRing();
		}
		return new Object(itemId, 1);
	}

	public static bool HasExplicitCategory(ParsedItemData data)
	{
		if (data.HasTypeObject() && data.RawData is ObjectData objectData)
		{
			return objectData.Category < 0;
		}
		return false;
	}

	public static int GetRawPrice(ParsedItemData data)
	{
		if (!data.HasTypeObject() || !(data.RawData is ObjectData objectData))
		{
			return 0;
		}
		return objectData.Price;
	}

	public bool CanHaveRoe(Item fish)
	{
		if (fish is Object obj)
		{
			return ItemContextTagManager.HasBaseTag(obj.QualifiedItemId, "fish_has_roe");
		}
		return false;
	}

	public virtual ColoredObject CreateFlavoredAgedRoe(Object ingredient)
	{
		if (ingredient == null)
		{
			throw new ArgumentNullException("ingredient");
		}
		if (ingredient.QualifiedItemId != "(O)812")
		{
			ingredient = CreateFlavoredRoe(ingredient);
		}
		Color color = TailoringMenu.GetDyeColor(ingredient) ?? Color.Orange;
		ColoredObject coloredObject = new ColoredObject("447", 1, color);
		coloredObject.Name = "Aged " + ingredient.Name;
		coloredObject.preserve.Value = Object.PreserveType.AgedRoe;
		coloredObject.preservedParentSheetIndex.Value = ingredient.preservedParentSheetIndex.Value;
		coloredObject.Price = ingredient.Price * 2;
		return coloredObject;
	}

	public virtual Object CreateFlavoredHoney(Object ingredient)
	{
		Object obj = new Object("340", 1);
		if (ingredient == null || ingredient.Name == null || ingredient.Name == "Error Item" || ingredient.ItemId == "-1")
		{
			ingredient = null;
		}
		if (ingredient == null)
		{
			obj.Name = "Wild Honey";
		}
		else
		{
			obj.Name = ingredient.Name + " Honey";
			obj.Price += ingredient.Price * 2;
		}
		obj.preserve.Value = Object.PreserveType.Honey;
		obj.preservedParentSheetIndex.Value = ingredient?.ItemId ?? "-1";
		return obj;
	}

	public virtual Object CreateFlavoredJelly(Object ingredient)
	{
		if (ingredient == null)
		{
			throw new ArgumentNullException("ingredient");
		}
		Color color = TailoringMenu.GetDyeColor(ingredient) ?? Color.Red;
		Object obj = new ColoredObject("344", 1, color);
		obj.Name = ingredient.Name + " Jelly";
		obj.preserve.Value = Object.PreserveType.Jelly;
		obj.preservedParentSheetIndex.Value = ingredient.ItemId;
		obj.Price = ingredient.Price * 2 + 50;
		if (ingredient.Edibility > 0)
		{
			obj.Edibility = (int)((float)ingredient.Edibility * 2f);
		}
		else if (ingredient.Edibility == -300)
		{
			obj.Edibility = (int)((float)ingredient.Price * 0.2f);
		}
		else
		{
			obj.Edibility = ingredient.Edibility;
		}
		return obj;
	}

	public virtual Object CreateFlavoredJuice(Object ingredient)
	{
		if (ingredient == null)
		{
			throw new ArgumentNullException("ingredient");
		}
		Color color = TailoringMenu.GetDyeColor(ingredient) ?? Color.Green;
		Object obj = new ColoredObject("350", 1, color);
		obj.Name = ingredient.Name + " Juice";
		obj.preserve.Value = Object.PreserveType.Juice;
		obj.preservedParentSheetIndex.Value = ingredient.ItemId;
		obj.Price = (int)((double)ingredient.Price * 2.25);
		if (ingredient.Edibility > 0)
		{
			obj.Edibility = (int)((float)ingredient.Edibility * 2f);
		}
		else if (ingredient.Edibility == -300)
		{
			obj.Edibility = (int)((float)ingredient.Price * 0.4f);
		}
		else
		{
			obj.Edibility = ingredient.Edibility;
		}
		return obj;
	}

	public virtual Object CreateFlavoredPickle(Object ingredient)
	{
		if (ingredient == null)
		{
			throw new ArgumentNullException("ingredient");
		}
		Color color = TailoringMenu.GetDyeColor(ingredient) ?? Color.Green;
		Object obj = new ColoredObject("342", 1, color);
		obj.Name = "Pickled " + ingredient.Name;
		obj.preserve.Value = Object.PreserveType.Pickle;
		obj.preservedParentSheetIndex.Value = ingredient.ItemId;
		obj.Price = ingredient.Price * 2 + 50;
		if (ingredient.Edibility > 0)
		{
			obj.Edibility = (int)((float)ingredient.Edibility * 1.75f);
		}
		else if (ingredient.Edibility == -300)
		{
			obj.Edibility = (int)((float)ingredient.Price * 0.25f);
		}
		else
		{
			obj.Edibility = ingredient.Edibility;
		}
		return obj;
	}

	public virtual ColoredObject CreateFlavoredRoe(Object ingredient)
	{
		if (ingredient == null)
		{
			throw new ArgumentNullException("ingredient");
		}
		Color color = ((ingredient.QualifiedItemId == "(O)698") ? new Color(61, 55, 42) : (TailoringMenu.GetDyeColor(ingredient) ?? Color.Orange));
		ColoredObject coloredObject = new ColoredObject("812", 1, color);
		coloredObject.Name = ingredient.Name + " Roe";
		coloredObject.preserve.Value = Object.PreserveType.Roe;
		coloredObject.preservedParentSheetIndex.Value = ingredient.ItemId;
		coloredObject.Price += ingredient.Price / 2;
		return coloredObject;
	}

	public virtual Object CreateFlavoredWine(Object ingredient)
	{
		if (ingredient == null)
		{
			throw new ArgumentNullException("ingredient");
		}
		Color color = TailoringMenu.GetDyeColor(ingredient) ?? Color.Purple;
		ColoredObject coloredObject = new ColoredObject("348", 1, color);
		coloredObject.Name = ingredient.Name + " Wine";
		coloredObject.Price = ingredient.Price * 3;
		coloredObject.preserve.Value = Object.PreserveType.Wine;
		coloredObject.preservedParentSheetIndex.Value = ingredient.ItemId;
		if (ingredient.Edibility > 0)
		{
			coloredObject.Edibility = (int)((float)ingredient.Edibility * 1.75f);
		}
		else if (ingredient.Edibility == -300)
		{
			coloredObject.Edibility = (int)((float)ingredient.Price * 0.1f);
		}
		else
		{
			coloredObject.Edibility = ingredient.Edibility;
		}
		return coloredObject;
	}

	public virtual Object CreateFlavoredBait(Object ingredient)
	{
		if (ingredient == null)
		{
			throw new ArgumentNullException("ingredient");
		}
		Color color = TailoringMenu.GetDyeColor(ingredient) ?? Color.Orange;
		ColoredObject coloredObject = new ColoredObject("SpecificBait", 1, color);
		coloredObject.Name = ingredient.Name + " Bait";
		coloredObject.Price = Math.Max(1, (int)((float)ingredient.Price * 0.1f));
		coloredObject.preserve.Value = Object.PreserveType.Bait;
		coloredObject.preservedParentSheetIndex.Value = ingredient.ItemId;
		return coloredObject;
	}

	public virtual Object CreateFlavoredDriedFruit(Object ingredient)
	{
		if (ingredient == null)
		{
			throw new ArgumentNullException("ingredient");
		}
		Color color = TailoringMenu.GetDyeColor(ingredient) ?? Color.Orange;
		Object obj = new ColoredObject("DriedFruit", 1, color);
		obj.Name = Lexicon.makePlural("Dried " + ingredient.Name);
		obj.Price = (int)((float)(ingredient.Price * 5) * 1.5f) + 25;
		obj.Quality = ingredient.Quality;
		obj.preserve.Value = Object.PreserveType.DriedFruit;
		obj.preservedParentSheetIndex.Value = ingredient.ItemId;
		obj.Edibility = ingredient.Edibility * 3;
		if (ingredient.Edibility > 0)
		{
			obj.Edibility = (int)((float)ingredient.Edibility * 3f);
		}
		else if (ingredient.Edibility == -300)
		{
			obj.Edibility = (int)((float)ingredient.Price * 0.5f);
		}
		else
		{
			obj.Edibility = ingredient.Edibility;
		}
		return obj;
	}

	public virtual Object CreateFlavoredDriedMushroom(Object ingredient)
	{
		if (ingredient == null)
		{
			throw new ArgumentNullException("ingredient");
		}
		Color color = TailoringMenu.GetDyeColor(ingredient) ?? Color.Orange;
		ColoredObject coloredObject = new ColoredObject("DriedMushrooms", 1, color);
		coloredObject.Name = Lexicon.makePlural("Dried " + ingredient.Name);
		coloredObject.Price = (int)((float)(ingredient.Price * 5) * 1.5f) + 25;
		coloredObject.Quality = ingredient.Quality;
		coloredObject.preserve.Value = Object.PreserveType.DriedMushroom;
		coloredObject.preservedParentSheetIndex.Value = ingredient.ItemId;
		coloredObject.Edibility = ingredient.Edibility * 3;
		return coloredObject;
	}

	public virtual Object CreateFlavoredSmokedFish(Object ingredient)
	{
		if (ingredient == null)
		{
			throw new ArgumentNullException("ingredient");
		}
		Color color = TailoringMenu.GetDyeColor(ingredient) ?? Color.Orange;
		Object obj = new ColoredObject("SmokedFish", 1, color);
		obj.Name = "Smoked " + ingredient.Name;
		obj.Price = ingredient.Price * 2;
		obj.Quality = ingredient.Quality;
		obj.preserve.Value = Object.PreserveType.SmokedFish;
		obj.preservedParentSheetIndex.Value = ingredient.ItemId;
		if (ingredient.Edibility > 0)
		{
			obj.Edibility = (int)((float)ingredient.Edibility * 1.5f);
		}
		else if (ingredient.Edibility == -300)
		{
			obj.Edibility = (int)((float)ingredient.Price * 0.3f);
		}
		else
		{
			obj.Edibility = ingredient.Edibility;
		}
		return obj;
	}

	public virtual Object CreateFlavoredItem(Object.PreserveType preserveType, Object ingredient)
	{
		return preserveType switch
		{
			Object.PreserveType.AgedRoe => CreateFlavoredAgedRoe(ingredient), 
			Object.PreserveType.Honey => CreateFlavoredHoney(ingredient), 
			Object.PreserveType.Jelly => CreateFlavoredJelly(ingredient), 
			Object.PreserveType.Juice => CreateFlavoredJuice(ingredient), 
			Object.PreserveType.Pickle => CreateFlavoredPickle(ingredient), 
			Object.PreserveType.Roe => CreateFlavoredRoe(ingredient), 
			Object.PreserveType.Wine => CreateFlavoredWine(ingredient), 
			Object.PreserveType.Bait => CreateFlavoredBait(ingredient), 
			Object.PreserveType.DriedFruit => CreateFlavoredDriedFruit(ingredient), 
			Object.PreserveType.DriedMushroom => CreateFlavoredDriedMushroom(ingredient), 
			Object.PreserveType.SmokedFish => CreateFlavoredSmokedFish(ingredient), 
			_ => null, 
		};
	}

	public string GetBaseItemIdForFlavoredItem(Object.PreserveType preserveType, string ingredientItemId)
	{
		return preserveType switch
		{
			Object.PreserveType.AgedRoe => "(O)447", 
			Object.PreserveType.Honey => "(O)340", 
			Object.PreserveType.Jelly => "(O)344", 
			Object.PreserveType.Juice => "(O)350", 
			Object.PreserveType.Pickle => "(O)342", 
			Object.PreserveType.Roe => "(O)812", 
			Object.PreserveType.Wine => "(O)348", 
			Object.PreserveType.Bait => "(O)SpecificBait", 
			Object.PreserveType.DriedFruit => "(O)DriedFruit", 
			Object.PreserveType.DriedMushroom => "(O)DriedMushrooms", 
			Object.PreserveType.SmokedFish => "(O)SmokedFish", 
			_ => null, 
		};
	}

	protected ObjectData GetRawData(string itemId)
	{
		if (itemId == null || !Game1.objectData.TryGetValue(itemId, out var value))
		{
			return null;
		}
		return value;
	}
}
