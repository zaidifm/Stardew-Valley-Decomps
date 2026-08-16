using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Enchantments;
using StardewValley.Extensions;
using StardewValley.GameData.GiantCrops;
using StardewValley.Internal;
using StardewValley.ItemTypeDefinitions;
using StardewValley.Tools;

namespace StardewValley.TerrainFeatures;

public class GiantCrop : ResourceClump
{
	private static readonly Dictionary<string, List<KeyValuePair<string, GiantCropData>>> CacheByCropId = new Dictionary<string, List<KeyValuePair<string, GiantCropData>>>();

	private static int CacheTick;

	[XmlElement("id")]
	public readonly NetString netId = new NetString();

	[XmlIgnore]
	public string Id
	{
		get
		{
			if (netId.Value == null)
			{
				netId.Value = GetIdFromLegacySpriteIndex(parentSheetIndex.Value);
			}
			return netId.Value;
		}
		set
		{
			netId.Value = value;
		}
	}

	public GiantCrop()
	{
	}

	public GiantCrop(string id, Vector2 tile)
		: this()
	{
		Tile = tile;
		Id = id;
		GiantCropData data = GetData();
		width.Value = data?.TileSize.X ?? 3;
		height.Value = data?.TileSize.Y ?? 3;
		health.Value = data?.Health ?? 3;
	}

	public override void initNetFields()
	{
		base.initNetFields();
		base.NetFields.AddField(netId, "netId");
	}

	public override void draw(SpriteBatch spriteBatch)
	{
		Vector2 tile = Tile;
		GiantCropData data = GetData();
		if (data != null)
		{
			Texture2D texture2D = Game1.content.Load<Texture2D>(data.Texture);
			spriteBatch.Draw(texture2D, Game1.GlobalToLocal(Game1.viewport, tile * 64f - new Vector2((shakeTimer > 0f) ? ((float)Math.Sin(Math.PI * 2.0 / (double)shakeTimer) * 2f) : 0f, 64f)), new Rectangle(data.TexturePosition.X, data.TexturePosition.Y, 16 * data.TileSize.X, 16 * (data.TileSize.Y + 1)), Color.White, 0f, Vector2.Zero, 4f, SpriteEffects.None, (tile.Y + (float)data.TileSize.Y) * 64f / 10000f);
		}
		else
		{
			IItemDataDefinition itemDataDefinition = ItemRegistry.RequireTypeDefinition("(O)");
			spriteBatch.Draw(itemDataDefinition.GetErrorTexture(), Game1.GlobalToLocal(Game1.viewport, tile * 64f - new Vector2((shakeTimer > 0f) ? ((float)Math.Sin(Math.PI * 2.0 / (double)shakeTimer) * 2f) : 0f, 64f)), itemDataDefinition.GetErrorSourceRect(), Color.White, 0f, Vector2.Zero, 4f, SpriteEffects.None, (tile.Y + 2f) * 64f / 10000f);
		}
	}

	public override bool performToolAction(Tool t, int damage, Vector2 tileLocation)
	{
		if (!(t is Axe))
		{
			return false;
		}
		GameLocation location = Location;
		Farmer targetFarmer = t.getLastFarmerToUse() ?? Game1.player;
		int num = t.upgradeLevel.Value / 2 + 1;
		float healthDeducted = Math.Min(health.Value, num);
		GiantCropData data = GetData();
		Random random = ((!Game1.IsMultiplayer) ? Utility.CreateRandom(Game1.uniqueIDForThisGame, Game1.stats.DaysPlayed, (double)tileLocation.X * 7.0, (double)tileLocation.Y * 11.0) : (Game1.recentMultiplayerRandom = Utility.CreateRandom((double)tileLocation.X * 1000.0, tileLocation.Y)));
		location.playSound("axchop", tileLocation);
		Game1.createRadialDebris(Game1.currentLocation, 12, (int)tileLocation.X + width.Value / 2, (int)tileLocation.Y + height.Value / 2, random.Next(4, 9), resource: false);
		if (shakeTimer <= 0f)
		{
			shakeTimer = 100f;
			base.NeedsUpdate = true;
		}
		if (t.hasEnchantmentOfType<ShavingEnchantment>() && random.NextBool((float)num / 5f) && data?.HarvestItems != null)
		{
			foreach (GiantCropHarvestItemData harvestItem in data.HarvestItems)
			{
				Item item = TryGetDrop(harvestItem, random, targetFarmer, isShaving: true, healthDeducted);
				if (item != null)
				{
					if (Id.Equals("QiFruit") && !Game1.player.team.SpecialOrderActive("QiChallenge2"))
					{
						break;
					}
					Debris debris = new Debris(item, new Vector2((tileLocation.X + (float)(width.Value / 2)) * 64f, (tileLocation.Y + (float)(height.Value / 2)) * 64f), Game1.player.getStandingPosition());
					debris.Chunks[0].xVelocity.Value += (float)random.Next(-10, 11) / 10f;
					debris.chunkFinalYLevel = (int)(tileLocation.Y * 64f + 128f);
					location.debris.Add(debris);
				}
			}
		}
		health.Value -= num;
		if (health.Value <= 0f)
		{
			t.getLastFarmerToUse().gainExperience(5, 50 * ((t.getLastFarmerToUse().luckLevel.Value + 1) / 2));
			if (location.HasUnlockedAreaSecretNotes(t.getLastFarmerToUse()))
			{
				Object obj = location.tryToCreateUnseenSecretNote(t.getLastFarmerToUse());
				if (obj != null)
				{
					Game1.createItemDebris(obj, tileLocation * 64f, -1, location);
				}
			}
			if (data?.HarvestItems != null)
			{
				foreach (GiantCropHarvestItemData harvestItem2 in data.HarvestItems)
				{
					Item item2 = TryGetDrop(harvestItem2, random, targetFarmer, isShaving: false, healthDeducted);
					if (item2 == null)
					{
						continue;
					}
					if (Id.Equals("QiFruit") && !Game1.player.team.SpecialOrderActive("QiChallenge2"))
					{
						if (!Game1.player.mailReceived.Contains("GiantQiFruitMessage"))
						{
							Game1.player.mailReceived.Add("GiantQiFruitMessage");
							Game1.chatBox.addMessage(Game1.content.LoadString("Strings\\1_6_Strings:GiantQiFruitMessage"), new Color(100, 50, 255));
						}
						Game1.createMultipleItemDebris(ItemRegistry.Create("(O)MysteryBox"), new Vector2((int)tileLocation.X + width.Value / 2, (int)tileLocation.Y + width.Value / 2) * 64f, -2, location);
					}
					else
					{
						Game1.createMultipleItemDebris(item2, new Vector2((int)tileLocation.X + width.Value / 2, (int)tileLocation.Y + width.Value / 2) * 64f, -2, location);
						Game1.setRichPresence("giantcrop", item2.Name);
					}
				}
			}
			Game1.createRadialDebris(Game1.currentLocation, 12, (int)tileLocation.X + width.Value / 2, (int)tileLocation.Y + width.Value / 2, random.Next(4, 9), resource: false);
			location.playSound("stumpCrack", tileLocation);
			for (int i = 0; i < width.Value; i++)
			{
				for (int j = 0; j < height.Value; j++)
				{
					float animationInterval = Utility.RandomFloat(80f, 110f);
					if (width.Value >= 2 && height.Value >= 2 && (i == 0 || i == width.Value - 2) && (j == 0 || j == height.Value - 2))
					{
						Game1.multiplayer.broadcastSprites(location, new TemporaryAnimatedSprite(5, (tileLocation + new Vector2((float)i + 0.5f, (float)j + 0.5f)) * 64f, Color.White, 8, flipped: false, 70f));
					}
					Game1.multiplayer.broadcastSprites(location, new TemporaryAnimatedSprite(5, (tileLocation + new Vector2(i, j)) * 64f, Color.White, 8, flipped: false, animationInterval));
				}
			}
			return true;
		}
		return false;
	}

	public GiantCropData GetData()
	{
		if (!TryGetData(Id, out var data))
		{
			return null;
		}
		return data;
	}

	public static bool TryGetData(string id, out GiantCropData data)
	{
		if (id == null)
		{
			data = null;
			return false;
		}
		return DataLoader.GiantCrops(Game1.content).TryGetValue(id, out data);
	}

	public static IReadOnlyList<KeyValuePair<string, GiantCropData>> GetGiantCropsFor(string cropId)
	{
		cropId = ItemRegistry.QualifyItemId(cropId);
		if (cropId != null)
		{
			RebuildCropIdCacheIfNeeded();
			if (CacheByCropId.TryGetValue(cropId, out var value))
			{
				return value;
			}
		}
		return LegacyShims.EmptyArray<KeyValuePair<string, GiantCropData>>();
	}

	public static bool RebuildCropIdCacheIfNeeded(bool forceRebuild = false)
	{
		if (!forceRebuild && CacheTick == Game1.ticks)
		{
			return false;
		}
		CacheTick = Game1.ticks;
		CacheByCropId.Clear();
		foreach (KeyValuePair<string, GiantCropData> item in DataLoader.GiantCrops(Game1.content))
		{
			string text = ItemRegistry.QualifyItemId(item.Value.FromItemId);
			if (text != null)
			{
				if (!CacheByCropId.TryGetValue(text, out var value))
				{
					value = (CacheByCropId[text] = new List<KeyValuePair<string, GiantCropData>>());
				}
				value.Add(item);
			}
		}
		return true;
	}

	public Item TryGetDrop(GiantCropHarvestItemData drop, Random r, Farmer targetFarmer, bool isShaving, float healthDeducted)
	{
		if (!r.NextBool(drop.Chance))
		{
			return null;
		}
		if (drop.Condition != null && !GameStateQuery.CheckConditions(drop.Condition, Location, targetFarmer, null, null, r))
		{
			return null;
		}
		if (drop.ForShavingEnchantment.HasValue && drop.ForShavingEnchantment != isShaving)
		{
			return null;
		}
		Item item = ItemQueryResolver.TryResolveRandomItem(drop, new ItemQueryContext(Location, targetFarmer, r, $"giant crop {Id} > harvest item '{drop.Id}'"), avoidRepeat: false, null, null, null, delegate(string query, string error)
		{
			Game1.log.Error($"Giant crop '{Id}' failed parsing item query '{query}' for harvest item '{drop.Id}': {error}");
		});
		if (isShaving)
		{
			AdjustStackSizeWhenShaving(item, drop.ScaledMinStackWhenShaving, drop.ScaledMaxStackWhenShaving, healthDeducted, r);
		}
		return item;
	}

	private void AdjustStackSizeWhenShaving(Item item, int? min, int? max, float healthDeducted, Random random)
	{
		if (item != null && (min.HasValue || max.HasValue))
		{
			if (min.HasValue)
			{
				min = (int)((float?)min * healthDeducted).Value;
			}
			if (max.HasValue)
			{
				max = (int)((float?)max * healthDeducted).Value;
			}
			if (min.HasValue && max.HasValue)
			{
				item.Stack = random.Next(min.Value, max.Value + 1);
			}
			else if (item.Stack < min)
			{
				item.Stack = min.Value;
			}
			else if (item.Stack > max)
			{
				item.Stack = max.Value;
			}
		}
	}

	private string GetIdFromLegacySpriteIndex(int spriteIndex)
	{
		return spriteIndex switch
		{
			190 => "Cauliflower", 
			254 => "Melon", 
			276 => "Pumpkin", 
			_ => spriteIndex.ToString(), 
		};
	}
}
