using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.ItemTypeDefinitions;

namespace StardewValley;

public interface ISalable : IHaveItemTypeId
{
	string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	string QualifiedItemId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool IsRecipe
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	int Stack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	int Quality
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ShouldDrawIcon();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow);

	[MethodImpl(MethodImplOptions.NoInlining)]
	string getDescription();

	[MethodImpl(MethodImplOptions.NoInlining)]
	int maximumStackSize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	int addToStack(Item stack);

	[MethodImpl(MethodImplOptions.NoInlining)]
	int sellToStorePrice(long specificPlayerID = -1L);

	[MethodImpl(MethodImplOptions.NoInlining)]
	int salePrice(bool ignoreProfitMargins = false);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool appliesProfitMargins();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool actionWhenPurchased(string shopId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool canStackWith(ISalable other);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool CanBuyItem(Farmer farmer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsInfiniteStock();

	[MethodImpl(MethodImplOptions.NoInlining)]
	ISalable GetSalableInstance();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void FixStackSize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void FixQuality();
}
