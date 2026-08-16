using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.ItemTypeDefinitions;

namespace StardewValley;

public interface ISalable : IHaveItemTypeId
{
	string TypeDefinitionId { get; }

	string QualifiedItemId { get; }

	string DisplayName { get; }

	string Name { get; }

	bool IsRecipe { get; set; }

	int Stack { get; set; }

	int Quality { get; set; }

	bool ShouldDrawIcon();

	void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow);

	string getDescription();

	int maximumStackSize();

	int addToStack(Item stack);

	int sellToStorePrice(long specificPlayerID = -1L);

	int salePrice(bool ignoreProfitMargins = false);

	bool appliesProfitMargins();

	bool actionWhenPurchased(string shopId);

	bool canStackWith(ISalable other);

	bool CanBuyItem(Farmer farmer);

	bool IsInfiniteStock();

	ISalable GetSalableInstance();

	void FixStackSize();

	void FixQuality();
}
