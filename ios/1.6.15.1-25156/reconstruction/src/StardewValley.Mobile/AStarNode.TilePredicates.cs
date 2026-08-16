using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Locations;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTilePassable()
	{
		return TapToMoveUtils.IsTilePassable(_aStarGraph.gameLocation, x, y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsTravellingCart()
	{
		GameLocation location = _aStarGraph.gameLocation;
		if (location == null || location.GetType() != typeof(Forest))
			return false;

		Forest forest = (Forest)location;
		if (forest.travelingMerchantBounds == null)
			return false;

		Rectangle tileBounds = new Rectangle(x << 6, y << 6, 64, 64);
		foreach (Rectangle merchantBounds in forest.travelingMerchantBounds)
		{
			if (merchantBounds.Intersects(tileBounds))
				return true;
		}

		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsTravellingDesertShop()
	{
		GameLocation location = _aStarGraph.gameLocation;
		if (location == null || location.GetType() != typeof(Desert))
			return false;

		Rectangle tileBounds = new Rectangle(x << 6, y << 6, 64, 64);
		return ((Desert)location).desertMerchantBounds.Intersects(tileBounds);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsFestivalProp()
	{
		if (Game1.CurrentEvent == null)
			return false;

		Rectangle tileBounds = new Rectangle(x << 6, y << 6, 64, 64);
		for (int i = 0; i < Game1.CurrentEvent.festivalProps.Count; i++)
		{
			if (Game1.CurrentEvent.festivalProps[i].isColliding(tileBounds))
				return true;
		}

		return false;
	}
}
