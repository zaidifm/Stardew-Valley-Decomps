using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Buildings;
using StardewValley.Locations;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ContainsTravellingCart(int pointX, int pointY)
	{
		if (gameLocation is not Forest forest || forest.travelingMerchantBounds == null)
			return false;

		foreach (Rectangle bounds in forest.travelingMerchantBounds)
		{
			if (bounds.Contains(pointX, pointY))
				return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ContainsTravellingDesertShop(int pointX, int pointY)
	{
		return gameLocation is Desert desert
			&& desert.desertMerchantBounds.Contains(pointX, pointY);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ContainsCinemaDoor(int tileX, int tileY)
	{
		if (gameLocation is not Town
			|| !Utility.doesMasterPlayerHaveMailReceivedButNotMailForTomorrow("ccMovieTheater"))
		{
			return false;
		}

		return (tileX == 52 || tileX == 53)
			&& (tileY == 18 || tileY == 19);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ContainsCinemaTicketOffice(int tileX, int tileY)
	{
		if (gameLocation is not Town
			|| !Utility.doesMasterPlayerHaveMailReceivedButNotMailForTomorrow("ccMovieTheater"))
		{
			return false;
		}

		return tileX > 53 && tileX < 57
			&& tileY > 18 && tileY < 21;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsIslandNorthSuspensionBridgeRightSide(Vector2 tile)
	{
		return tile.X > 37f && tile.X < 48f && tile.Y == 39f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsWizardBuilding(AStarNode endNode)
	{
		return IsWizardBuilding(new Vector2(endNode.x, endNode.y));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsWizardBuilding(Vector2 tile)
	{
		if (!gameLocation.IsBuildableLocation())
			return false;

		Building building = gameLocation.getBuildingAt(tile);
		if (building == null)
			return false;

		return building.buildingType.Value == "Obelisk"
			|| building.buildingType.Value == "Junimo Hut";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TapToMoveUtils()
	{
	}
}
