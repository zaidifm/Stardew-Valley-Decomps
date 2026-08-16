using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.BellsAndWhistles;
using StardewValley.Extensions;
using StardewValley.WorldMaps;

namespace StardewValley.Menus;

public class MapPage : IClickableMenu
{
	[Flags]
	public enum WorldMapDebugLineType
	{
		None = 0,
		Areas = 1,
		Positions = 2,
		Tooltips = 4,
		All = -1
	}

	public static WorldMapDebugLineType EnableDebugLines;

	public readonly MapAreaPositionWithContext? mapPosition;

	public readonly MapRegion mapRegion;

	public readonly MapArea[] mapAreas;

	public readonly string scrollText;

	public readonly int defaultComponentID;

	public Rectangle mapBounds;

	public readonly Dictionary<string, ClickableComponent> points = new Dictionary<string, ClickableComponent>(StringComparer.OrdinalIgnoreCase);

	public string hoverText = "";

	public MapPage(int x, int y, int width, int height)
		: base(x, y, width, height)
	{
		WorldMapManager.ReloadData();
		Point normalizedPlayerTile = GetNormalizedPlayerTile(Game1.player);
		mapPosition = WorldMapManager.GetPositionData(Game1.player.currentLocation, normalizedPlayerTile) ?? WorldMapManager.GetPositionData(Game1.getFarm(), Point.Zero);
		mapRegion = mapPosition?.Data.Region ?? WorldMapManager.GetMapRegions().First();
		mapAreas = mapRegion.GetAreas();
		scrollText = mapPosition?.Data.GetScrollText(normalizedPlayerTile);
		mapBounds = mapRegion.GetMapPixelBounds();
		int num = (defaultComponentID = 1000);
		MapArea[] array = mapAreas;
		for (int i = 0; i < array.Length; i++)
		{
			MapAreaTooltip[] tooltips = array[i].GetTooltips();
			foreach (MapAreaTooltip mapAreaTooltip in tooltips)
			{
				Rectangle pixelArea = mapAreaTooltip.GetPixelArea();
				pixelArea = new Rectangle(mapBounds.X + pixelArea.X, mapBounds.Y + pixelArea.Y, pixelArea.Width, pixelArea.Height);
				num++;
				ClickableComponent value = new ClickableComponent(pixelArea, mapAreaTooltip.NamespacedId)
				{
					myID = num,
					label = mapAreaTooltip.Text
				};
				points[mapAreaTooltip.NamespacedId] = value;
				if (mapAreaTooltip.NamespacedId == "Farm/Default")
				{
					defaultComponentID = num;
				}
			}
		}
		array = mapAreas;
		for (int i = 0; i < array.Length; i++)
		{
			MapAreaTooltip[] tooltips = array[i].GetTooltips();
			foreach (MapAreaTooltip mapAreaTooltip2 in tooltips)
			{
				if (points.TryGetValue(mapAreaTooltip2.NamespacedId, out var value2))
				{
					SetNeighborId(value2, "left", mapAreaTooltip2.Data.LeftNeighbor);
					SetNeighborId(value2, "right", mapAreaTooltip2.Data.RightNeighbor);
					SetNeighborId(value2, "up", mapAreaTooltip2.Data.UpNeighbor);
					SetNeighborId(value2, "down", mapAreaTooltip2.Data.DownNeighbor);
				}
			}
		}
	}

	public override void populateClickableComponentList()
	{
		base.populateClickableComponentList();
		allClickableComponents.AddRange(points.Values);
	}

	public void SetNeighborId(ClickableComponent component, string direction, string neighborKeys)
	{
		if (string.IsNullOrWhiteSpace(neighborKeys))
		{
			return;
		}
		if (!TryGetNeighborId(neighborKeys, out var id, out var foundIgnore))
		{
			if (!foundIgnore)
			{
				Game1.log.Warn($"World map tooltip '{component.name}' has {direction} neighbor keys '{neighborKeys}' which don't match a tooltip namespaced ID or alias.");
			}
			return;
		}
		switch (direction)
		{
		case "left":
			component.leftNeighborID = id;
			break;
		case "right":
			component.rightNeighborID = id;
			break;
		case "up":
			component.upNeighborID = id;
			break;
		case "down":
			component.downNeighborID = id;
			break;
		default:
			Game1.log.Warn("Can't set neighbor ID for unknown direction '" + direction + "'.");
			break;
		}
	}

	public bool TryGetNeighborId(string keys, out int id, out bool foundIgnore, bool isAlias = false)
	{
		foundIgnore = false;
		if (!string.IsNullOrWhiteSpace(keys))
		{
			string[] array = keys.Split(',', StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (text.EqualsIgnoreCase("ignore"))
				{
					foundIgnore = true;
					continue;
				}
				if (points.TryGetValue(text, out var value))
				{
					id = value.myID;
					return true;
				}
				if (!isAlias && mapRegion.Data.MapNeighborIdAliases.TryGetValue(text, out var value2))
				{
					if (TryGetNeighborId(value2, out id, out var foundIgnore2, isAlias: true))
					{
						foundIgnore |= foundIgnore2;
						return true;
					}
					foundIgnore |= foundIgnore2;
				}
			}
		}
		id = -1;
		return false;
	}

	public override void snapToDefaultClickableComponent()
	{
		currentlySnappedComponent = getComponentWithID(defaultComponentID);
		snapCursorToCurrentSnappedComponent();
	}

	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
		foreach (ClickableComponent value in points.Values)
		{
			if (!value.containsPoint(x, y))
			{
				continue;
			}
			string name = value.name;
			if (!(name == "Beach/LonelyStone"))
			{
				if (name == "Forest/SewerPipe")
				{
					Game1.playSound("shadowpeep");
				}
			}
			else
			{
				Game1.playSound("stoneCrack");
			}
			return;
		}
		if (Game1.activeClickableMenu is GameMenu gameMenu)
		{
			gameMenu.changeTab(gameMenu.lastOpenedNonMapTab);
		}
	}

	public override void performHoverAction(int x, int y)
	{
		hoverText = "";
		foreach (ClickableComponent value in points.Values)
		{
			if (value.containsPoint(x, y))
			{
				hoverText = value.label;
				break;
			}
		}
	}

	public override void draw(SpriteBatch b)
	{
		drawMap(b);
		drawMiniPortraits(b);
		drawScroll(b);
		drawTooltip(b);
	}

	public override void receiveKeyPress(Keys key)
	{
		if (Game1.options.doesInputListContain(Game1.options.mapButton, key) && readyToClose())
		{
			exitThisMenu();
		}
		base.receiveKeyPress(key);
	}

	public virtual void drawMiniPortraits(SpriteBatch b, float alpha = 1f)
	{
		Dictionary<Vector2, int> dictionary = new Dictionary<Vector2, int>();
		foreach (Farmer onlineFarmer in Game1.getOnlineFarmers())
		{
			Point normalizedPlayerTile = GetNormalizedPlayerTile(onlineFarmer);
			MapAreaPositionWithContext? mapAreaPositionWithContext = (onlineFarmer.IsLocalPlayer ? mapPosition : WorldMapManager.GetPositionData(onlineFarmer.currentLocation, normalizedPlayerTile));
			if (mapAreaPositionWithContext.HasValue && !(mapAreaPositionWithContext.Value.Data.Region.Id != mapRegion.Id))
			{
				Vector2 mapPixelPosition = mapAreaPositionWithContext.Value.GetMapPixelPosition();
				mapPixelPosition = new Vector2(mapPixelPosition.X + (float)mapBounds.X - 32f, mapPixelPosition.Y + (float)mapBounds.Y - 32f);
				dictionary.TryGetValue(mapPixelPosition, out var value);
				dictionary[mapPixelPosition] = value + 1;
				if (value > 0)
				{
					mapPixelPosition += new Vector2(48 * (value % 2), 48 * (value / 2));
				}
				onlineFarmer.FarmerRenderer.drawMiniPortrat(b, mapPixelPosition, 0.00011f, 4f, 2, onlineFarmer, alpha);
			}
		}
	}

	public virtual void drawScroll(SpriteBatch b)
	{
		if (scrollText != null)
		{
			float num = yPositionOnScreen + height + 32 + 4;
			float num2 = num + 80f;
			if (num2 > (float)Game1.uiViewport.Height)
			{
				num -= num2 - (float)Game1.uiViewport.Height;
			}
			SpriteText.drawStringWithScrollCenteredAt(b, scrollText, xPositionOnScreen + width / 2, (int)num);
		}
	}

	public virtual void drawMap(SpriteBatch b, bool drawBorders = true, float alpha = 1f)
	{
		if (drawBorders)
		{
			int y = mapBounds.Y - 96;
			Game1.drawDialogueBox(mapBounds.X - 32, y, (mapBounds.Width + 16) * 4, (mapBounds.Height + 32) * 4, speaker: false, drawOnlyBox: true);
		}
		float num = 0.86f;
		MapAreaTexture baseTexture = mapRegion.GetBaseTexture();
		if (baseTexture != null)
		{
			Rectangle offsetMapPixelArea = baseTexture.GetOffsetMapPixelArea(mapBounds.X, mapBounds.Y);
			b.Draw(baseTexture.Texture, offsetMapPixelArea, baseTexture.SourceRect, Color.White * alpha, 0f, Vector2.Zero, SpriteEffects.None, num);
			num += 0.001f;
		}
		MapArea[] array = mapAreas;
		for (int i = 0; i < array.Length; i++)
		{
			MapAreaTexture[] textures = array[i].GetTextures();
			foreach (MapAreaTexture mapAreaTexture in textures)
			{
				Rectangle offsetMapPixelArea2 = mapAreaTexture.GetOffsetMapPixelArea(mapBounds.X, mapBounds.Y);
				b.Draw(mapAreaTexture.Texture, offsetMapPixelArea2, mapAreaTexture.SourceRect, Color.White * alpha, 0f, Vector2.Zero, SpriteEffects.None, num);
				num += 0.001f;
			}
		}
		if (EnableDebugLines == WorldMapDebugLineType.None)
		{
			return;
		}
		array = mapAreas;
		foreach (MapArea mapArea in array)
		{
			if (EnableDebugLines.HasFlag(WorldMapDebugLineType.Tooltips))
			{
				MapAreaTooltip[] tooltips = mapArea.GetTooltips();
				for (int j = 0; j < tooltips.Length; j++)
				{
					Rectangle pixelArea = tooltips[j].GetPixelArea();
					pixelArea = new Rectangle(mapBounds.X + pixelArea.X, mapBounds.Y + pixelArea.Y, pixelArea.Width, pixelArea.Height);
					Utility.DrawSquare(b, pixelArea, 2, Color.Blue * alpha);
				}
			}
			if (EnableDebugLines.HasFlag(WorldMapDebugLineType.Areas))
			{
				Rectangle pixelArea2 = mapArea.Data.PixelArea;
				if (pixelArea2.Width > 0 || pixelArea2.Height > 0)
				{
					pixelArea2 = new Rectangle(mapBounds.X + pixelArea2.X * 4, mapBounds.Y + pixelArea2.Y * 4, pixelArea2.Width * 4, pixelArea2.Height * 4);
					Utility.DrawSquare(b, pixelArea2, 4, Color.Black * alpha);
				}
			}
			if (!EnableDebugLines.HasFlag(WorldMapDebugLineType.Positions))
			{
				continue;
			}
			foreach (MapAreaPosition worldPosition in mapArea.GetWorldPositions())
			{
				Rectangle pixelArea3 = worldPosition.GetPixelArea();
				pixelArea3 = new Rectangle(mapBounds.X + pixelArea3.X, mapBounds.Y + pixelArea3.Y, pixelArea3.Width, pixelArea3.Height);
				Utility.DrawSquare(b, pixelArea3, 2, Color.Red * alpha);
			}
		}
	}

	public virtual void drawTooltip(SpriteBatch b)
	{
		if (!string.IsNullOrEmpty(hoverText))
		{
			IClickableMenu.drawHoverText(b, hoverText, Game1.smallFont);
		}
	}

	public Point GetNormalizedPlayerTile(Farmer player)
	{
		Point result = player.TilePoint;
		if (result.X < 0 || result.Y < 0)
		{
			result = new Point(Math.Max(0, result.X), Math.Max(0, result.Y));
		}
		return result;
	}
}
