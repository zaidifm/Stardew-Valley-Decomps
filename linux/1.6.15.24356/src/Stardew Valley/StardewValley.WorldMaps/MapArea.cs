using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.GameData.WorldMaps;
using StardewValley.Internal;
using StardewValley.TokenizableStrings;

namespace StardewValley.WorldMaps;

public class MapArea
{
	protected MapAreaTexture[] CachedTextures;

	protected MapAreaTooltip[] CachedTooltips;

	protected MapAreaPosition[] CachedWorldPositions;

	protected string CachedScrollText;

	public string Id { get; }

	public MapRegion Region { get; }

	public WorldMapAreaData Data { get; }

	public MapArea(MapRegion region, WorldMapAreaData data)
	{
		Data = data;
		Id = data.Id;
		Region = region;
	}

	public MapAreaTexture[] GetTextures()
	{
		if (CachedTextures == null)
		{
			if (Data.Textures.Count > 0)
			{
				List<MapAreaTexture> list = new List<MapAreaTexture>();
				foreach (WorldMapTextureData texture in Data.Textures)
				{
					if (!GameStateQuery.CheckConditions(texture.Condition))
					{
						continue;
					}
					Texture2D texture2D = null;
					if (texture.Condition == "IS_CUSTOM_FARM_TYPE")
					{
						string text = Game1.whichModFarm?.WorldMapTexture;
						if (text == null)
						{
							continue;
						}
						texture2D = GetTexture(text);
						if (texture2D.Width <= 200)
						{
							texture.SourceRect = texture2D.Bounds;
						}
					}
					else
					{
						texture2D = GetTexture(texture.Texture);
					}
					Rectangle sourceRect = texture.SourceRect;
					if (sourceRect.IsEmpty)
					{
						sourceRect = new Rectangle(0, 0, texture2D.Width, texture2D.Height);
					}
					Rectangle rectangle = texture.MapPixelArea;
					if (rectangle.IsEmpty)
					{
						rectangle = Data.PixelArea;
					}
					list.Add(new MapAreaTexture(mapPixelArea: new Rectangle(rectangle.X * 4, rectangle.Y * 4, rectangle.Width * 4, rectangle.Height * 4), texture: texture2D, sourceRect: sourceRect));
				}
				CachedTextures = list.ToArray();
			}
			else
			{
				CachedTextures = LegacyShims.EmptyArray<MapAreaTexture>();
			}
		}
		return CachedTextures;
	}

	public MapAreaTooltip[] GetTooltips()
	{
		if (CachedTooltips == null)
		{
			List<WorldMapTooltipData> tooltips = Data.Tooltips;
			if (tooltips != null && tooltips.Count > 0)
			{
				List<MapAreaTooltip> list = new List<MapAreaTooltip>();
				foreach (WorldMapTooltipData tooltip in Data.Tooltips)
				{
					if (GameStateQuery.CheckConditions(tooltip.Condition))
					{
						string text = (GameStateQuery.CheckConditions(tooltip.KnownCondition) ? TokenParser.ParseText(Utility.TrimLines(tooltip.Text)) : "???");
						if (!string.IsNullOrWhiteSpace(text))
						{
							list.Add(new MapAreaTooltip(this, tooltip, text));
						}
					}
				}
				CachedTooltips = list.ToArray();
			}
			else
			{
				CachedTooltips = LegacyShims.EmptyArray<MapAreaTooltip>();
			}
		}
		return CachedTooltips;
	}

	public IEnumerable<MapAreaPosition> GetWorldPositions()
	{
		if (CachedWorldPositions == null)
		{
			List<MapAreaPosition> list = new List<MapAreaPosition>();
			foreach (WorldMapAreaPositionData worldPosition in Data.WorldPositions)
			{
				if (GameStateQuery.CheckConditions(worldPosition.Condition))
				{
					list.Add(new MapAreaPosition(this, worldPosition));
				}
			}
			CachedWorldPositions = list.ToArray();
		}
		return CachedWorldPositions;
	}

	public MapAreaPosition GetWorldPosition(string locationName, string contextName, Point tile)
	{
		return GetWorldPosition(locationName, contextName, tile, null);
	}

	internal MapAreaPosition GetWorldPosition(string locationName, string contextName, Point tile, LogBuilder log)
	{
		LogBuilder log2 = log?.GetIndentedLog();
		foreach (MapAreaPosition worldPosition in GetWorldPositions())
		{
			log?.AppendLine("Checking position '" + worldPosition.Data.Id + "'...");
			if (worldPosition.Matches(locationName, contextName, tile, log2))
			{
				return worldPosition;
			}
		}
		return null;
	}

	public virtual string GetScrollText()
	{
		if (CachedScrollText == null)
		{
			CachedScrollText = TokenParser.ParseText(Utility.TrimLines(Data.ScrollText));
		}
		return CachedScrollText;
	}

	private Texture2D GetTexture(string assetName)
	{
		if (Game1.season != Season.Spring)
		{
			string assetName2 = assetName + "_" + Game1.currentSeason.ToLower();
			if (Game1.content.DoesAssetExist<Texture2D>(assetName2))
			{
				return Game1.content.Load<Texture2D>(assetName2);
			}
		}
		return Game1.content.Load<Texture2D>(assetName);
	}
}
