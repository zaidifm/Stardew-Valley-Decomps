using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using xTile;
using xTile.Dimensions;
using xTile.Layers;
using xTile.ObjectModel;
using xTile.Tiles;

namespace StardewValley.Extensions;

public static class FrameworkExtensions
{
	public static Microsoft.Xna.Framework.Rectangle GetTitleSafeArea(this Viewport viewport)
	{
		return viewport.Bounds;
	}

	public static IEnumerable<Point> GetPoints(this Microsoft.Xna.Framework.Rectangle rect)
	{
		int right = rect.Right;
		int bottom = rect.Bottom;
		for (int y = rect.Y; y < bottom; y++)
		{
			for (int x = rect.X; x < right; x++)
			{
				yield return new Point(x, y);
			}
		}
	}

	public static IEnumerable<Vector2> GetVectors(this Microsoft.Xna.Framework.Rectangle rect)
	{
		int right = rect.Right;
		int bottom = rect.Bottom;
		for (int y = rect.Y; y < bottom; y++)
		{
			for (int x = rect.X; x < right; x++)
			{
				yield return new Vector2(x, y);
			}
		}
	}

	public static Microsoft.Xna.Framework.Rectangle Clone(this Microsoft.Xna.Framework.Rectangle rect)
	{
		return new Microsoft.Xna.Framework.Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
	}

	public static Vector2 Size(this Viewport vp)
	{
		return new Vector2(vp.Width, vp.Height);
	}

	public static int GetElementCount(this Texture2D texture)
	{
		return texture.ActualWidth * texture.ActualHeight;
	}

	public static int GetActualWidth(this Texture2D texture)
	{
		return texture.ActualWidth;
	}

	public static int GetActualHeight(this Texture2D texture)
	{
		return texture.ActualHeight;
	}

	public static void SetContentSize(this Texture2D texture, int width, int height)
	{
		texture.SetImageSize(width, height);
	}

	public static bool TryGetValue(this IPropertyCollection properties, string key, out string value)
	{
		if (!properties.TryGetValue(key, out var value2))
		{
			value = null;
			return false;
		}
		value = value2;
		return true;
	}

	public static bool TryAdd(this IPropertyCollection properties, string key, string value)
	{
		if (properties.ContainsKey(key))
		{
			return false;
		}
		properties.Add(key, new PropertyValue(value));
		return true;
	}

	public static Layer RequireLayer(this Map map, string layerId)
	{
		return map.GetLayer(layerId) ?? throw new KeyNotFoundException($"The '{map.assetPath}' map doesn't have required layer '{layerId}'.");
	}

	public static TileSheet RequireTileSheet(this Map map, string tilesheetId)
	{
		return map.GetTileSheet(tilesheetId) ?? throw new KeyNotFoundException($"The '{map.assetPath}' map doesn't have required tile sheet '{tilesheetId}'.");
	}

	public static TileSheet RequireTileSheet(this Map map, int expectedIndex, string tilesheetId)
	{
		if (map.TileSheets.Count > expectedIndex)
		{
			TileSheet tileSheet = map.TileSheets[expectedIndex];
			if (tileSheet.Id == tilesheetId)
			{
				return tileSheet;
			}
		}
		return map.GetTileSheet(tilesheetId) ?? throw new KeyNotFoundException($"The '{map.assetPath}' map doesn't have required tile sheet '{tilesheetId}'.");
	}

	public static bool HasTileAt(this Map map, Location tile, string layerId, string tilesheetId = null)
	{
		return map?.GetLayer(layerId)?.HasTileAt(tile.X, tile.Y, tilesheetId) == true;
	}

	public static bool HasTileAt(this Map map, int x, int y, string layerId, string tilesheetId = null)
	{
		return map?.GetLayer(layerId)?.HasTileAt(x, y, tilesheetId) == true;
	}

	public static int GetTileIndexAt(this Map map, int x, int y, string layerId, string tilesheetId = null)
	{
		return map?.GetLayer(layerId)?.GetTileIndexAt(x, y, tilesheetId) ?? (-1);
	}

	public static int GetTileIndexAt(this Map map, Location tile, string layerId, string tilesheetId = null)
	{
		return map?.GetLayer(layerId)?.GetTileIndexAt(tile.X, tile.Y, tilesheetId) ?? (-1);
	}

	public static bool HasTileAt(this Layer layer, Location tile, string tilesheetId = null)
	{
		return layer.HasTileAt(tile.X, tile.Y, tilesheetId);
	}

	public static bool HasTileAt(this Layer layer, int x, int y, string tilesheetId = null)
	{
		return layer.GetTileIndexAt(x, y, tilesheetId) != -1;
	}

	public static int GetTileIndexAt(this Layer layer, Location tile, string tilesheetId = null)
	{
		return layer?.GetTileIndexAt(tile.X, tile.Y, tilesheetId) ?? (-1);
	}

	public static int GetTileIndexAt(this Layer layer, int x, int y, string tilesheetId = null)
	{
		Tile tile = layer?.Tiles[x, y];
		if (tile == null)
		{
			return -1;
		}
		if (tilesheetId != null && !(tile.TileSheet?.Id).EqualsIgnoreCase(tilesheetId))
		{
			return -1;
		}
		return tile.TileIndex;
	}

	public static Microsoft.Xna.Framework.Rectangle ToXna(this xTile.Dimensions.Rectangle xrect)
	{
		return new Microsoft.Xna.Framework.Rectangle(xrect.X, xrect.Y, xrect.Width, xrect.Height);
	}
}
