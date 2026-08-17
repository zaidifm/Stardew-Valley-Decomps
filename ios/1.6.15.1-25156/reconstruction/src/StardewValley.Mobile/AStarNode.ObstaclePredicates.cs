using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Objects;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsFurniture()
	{
		Rectangle tileBounds = rect;
		foreach (Furniture furniture in _aStarGraph.gameLocation.furniture)
		{
			int furnitureType = furniture.furniture_type.Value;
			if (furnitureType != Furniture.rug
				&& furnitureType != Furniture.bed
				&& furniture.GetBoundingBox().Intersects(tileBounds))
			{
				return true;
			}
		}

		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Furniture GetFurniture()
	{
		Rectangle tileBounds = rect;

		foreach (Furniture furniture in _aStarGraph.gameLocation.furniture)
		{
			if (furniture.furniture_type.Value != Furniture.rug
				&& furniture.GetBoundingBox().Intersects(tileBounds))
			{
				return furniture;
			}
		}

		foreach (Furniture furniture in _aStarGraph.gameLocation.furniture)
		{
			if (furniture.furniture_type.Value == Furniture.rug
				&& furniture.GetBoundingBox().Intersects(tileBounds))
			{
				return furniture;
			}
		}

		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsChest()
	{
		return _aStarGraph.gameLocation.objects.TryGetValue(new Vector2(x, y), out Object value)
			&& value is Chest;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chest FetchChest()
	{
		if (_aStarGraph.gameLocation.objects.TryGetValue(new Vector2(x, y), out Object value))
			return value as Chest;

		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ObjectParentSheetIndexOnTile()
	{
		if (_aStarGraph.gameLocation.objects.TryGetValue(new Vector2(x, y), out Object value))
			return value.ItemId;

		return "-1";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsScarecrow()
	{
		if (!_aStarGraph.gameLocation.objects.TryGetValue(new Vector2(x, y), out Object value))
			return false;

		return value.ParentSheetIndex is 8 or 110 or 113 or 126 or 136 or 137 or 138 or 139 or 140 or 167;
	}
}
