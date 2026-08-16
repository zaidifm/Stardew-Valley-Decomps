using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Inventories;
using StardewValley.ItemTypeDefinitions;
using StardewValley.Objects;

namespace StardewValley;

public class CraftingRecipe
{
	public const int wild_seed_special_category = -777;

	public const int index_ingredients = 0;

	public const int index_output = 2;

	public const int index_cookingUnlockConditions = 3;

	public const int index_cookingDisplayName = 4;

	public const int index_craftingBigCraftable = 3;

	public const int index_craftingUnlockConditions = 4;

	public const int index_craftingDisplayName = 5;

	public string name;

	public string DisplayName;

	public string description;

	public static Dictionary<string, string> craftingRecipes;

	public static Dictionary<string, string> cookingRecipes;

	public Dictionary<string, int> recipeList;

	public List<string> itemToProduce;

	public bool bigCraftable;

	public bool isCookingRecipe;

	public int timesCrafted;

	public int numberProducedPerCraft;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitShared()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CraftingRecipe(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CraftingRecipe(string name, bool isCookingRecipe)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getIndexOfMenuView()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool doesFarmerHaveIngredientsInInventory(IList<Item> extraToCheck = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int howManyCanWeMake(IList<Item> extraToCheck = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawMenuView(SpriteBatch b, int x, int y, float layerDepth = 0.88f, bool shadow = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual ParsedItemData GetItemData(bool useFirst = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Item createItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryParseLevelRequirement(string id, string rawData, bool isCooking, out int skillNumber, out int minLevel, bool logErrors = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isThereSpecialIngredientRule(Item potentialIngredient, string requiredIngredient)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void consumeIngredients(List<IInventory> additionalMaterials)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DoesFarmerHaveAdditionalIngredientsInInventory(List<KeyValuePair<string, int>> additional_recipe_items, IList<Item> extraToCheck = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ItemMatchesForCrafting(Item item, string item_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ConsumeAdditionalIngredients(List<KeyValuePair<string, int>> additionalRecipeItems, List<IInventory> additionalMaterials)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getCraftableCount(IList<Chest> additional_material_chests)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getCraftableCount(IList<Item> additional_materials)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getCraftCountText()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getDescriptionHeight(int width)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawRecipeDescription(SpriteBatch b, Vector2 position, int width, IList<Item> additional_crafting_items = null, bool drawSmall = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getNumberOfIngredients()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getSpriteIndexFromRawIndex(string item_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getNameFromIndex(string item_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogParseError(string rawData, string message)
	{
	}
}
