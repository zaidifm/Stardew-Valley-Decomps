using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using StardewValley.GameData;
using StardewValley.GameData.BigCraftables;
using StardewValley.GameData.Buffs;
using StardewValley.GameData.Buildings;
using StardewValley.GameData.Bundles;
using StardewValley.GameData.Characters;
using StardewValley.GameData.Crafting;
using StardewValley.GameData.Crops;
using StardewValley.GameData.FarmAnimals;
using StardewValley.GameData.Fences;
using StardewValley.GameData.FishPonds;
using StardewValley.GameData.FloorsAndPaths;
using StardewValley.GameData.FruitTrees;
using StardewValley.GameData.GarbageCans;
using StardewValley.GameData.GiantCrops;
using StardewValley.GameData.HomeRenovations;
using StardewValley.GameData.LocationContexts;
using StardewValley.GameData.Locations;
using StardewValley.GameData.Machines;
using StardewValley.GameData.MakeoverOutfits;
using StardewValley.GameData.Minecarts;
using StardewValley.GameData.Movies;
using StardewValley.GameData.Museum;
using StardewValley.GameData.Objects;
using StardewValley.GameData.Pants;
using StardewValley.GameData.Pets;
using StardewValley.GameData.Powers;
using StardewValley.GameData.Shirts;
using StardewValley.GameData.Shops;
using StardewValley.GameData.SpecialOrders;
using StardewValley.GameData.Tools;
using StardewValley.GameData.Weapons;
using StardewValley.GameData.Weddings;
using StardewValley.GameData.WildTrees;
using StardewValley.GameData.WorldMaps;

namespace StardewValley;

public static class DataLoader
{
	public static Dictionary<int, string> Achievements(LocalizedContentManager content)
	{
		return Load<Dictionary<int, string>>(content, "Data\\Achievements");
	}

	public static List<ModFarmType> AdditionalFarms(LocalizedContentManager content)
	{
		return Load<List<ModFarmType>>(content, "Data\\AdditionalFarms");
	}

	public static List<ModLanguage> AdditionalLanguages(LocalizedContentManager content)
	{
		return Load<List<ModLanguage>>(content, "Data\\AdditionalLanguages");
	}

	public static List<ModWallpaperOrFlooring> AdditionalWallpaperFlooring(LocalizedContentManager content)
	{
		return Load<List<ModWallpaperOrFlooring>>(content, "Data\\AdditionalWallpaperFlooring");
	}

	public static Dictionary<string, string> AnimationDescriptions(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\animationDescriptions");
	}

	public static Dictionary<string, string> AquariumFish(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\AquariumFish");
	}

	public static Dictionary<string, AudioCueData> AudioChanges(LocalizedContentManager content)
	{
		return Load<Dictionary<string, AudioCueData>>(content, "Data\\AudioChanges");
	}

	public static Dictionary<string, BigCraftableData> BigCraftables(LocalizedContentManager content)
	{
		return Load<Dictionary<string, BigCraftableData>>(content, "Data\\BigCraftables");
	}

	public static Dictionary<string, string> Boots(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\Boots");
	}

	public static Dictionary<string, BuffData> Buffs(LocalizedContentManager content)
	{
		return Load<Dictionary<string, BuffData>>(content, "Data\\Buffs");
	}

	public static Dictionary<string, BuildingData> Buildings(LocalizedContentManager content)
	{
		return Load<Dictionary<string, BuildingData>>(content, "Data\\Buildings");
	}

	public static Dictionary<string, string> Bundles(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\Bundles");
	}

	public static Dictionary<string, string> ChairTiles(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\ChairTiles");
	}

	public static Dictionary<string, CharacterData> Characters(LocalizedContentManager content)
	{
		return Load<Dictionary<string, CharacterData>>(content, "Data\\Characters");
	}

	public static List<ConcessionItemData> Concessions(LocalizedContentManager content)
	{
		return Load<List<ConcessionItemData>>(content, "Data\\Concessions");
	}

	public static List<ConcessionTaste> ConcessionTastes(LocalizedContentManager content)
	{
		return Load<List<ConcessionTaste>>(content, "Data\\ConcessionTastes");
	}

	public static Dictionary<string, string> CookingRecipes(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\CookingRecipes");
	}

	public static Dictionary<string, string> CraftingRecipes(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\CraftingRecipes");
	}

	public static Dictionary<string, CropData> Crops(LocalizedContentManager content)
	{
		return Load<Dictionary<string, CropData>>(content, "Data\\Crops");
	}

	public static List<LostItem> LostItemsShop(LocalizedContentManager content)
	{
		return Load<List<LostItem>>(content, "Data\\LostItemsShop");
	}

	public static Dictionary<string, string> EngagementDialogue(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\EngagementDialogue");
	}

	public static Dictionary<string, FarmAnimalData> FarmAnimals(LocalizedContentManager content)
	{
		return Load<Dictionary<string, FarmAnimalData>>(content, "Data\\FarmAnimals");
	}

	public static Dictionary<string, FenceData> Fences(LocalizedContentManager content)
	{
		return Load<Dictionary<string, FenceData>>(content, "Data\\Fences");
	}

	public static Dictionary<string, string> Festivals_FestivalDates(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\Festivals\\FestivalDates");
	}

	public static Dictionary<string, string> Fish(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\Fish");
	}

	public static List<FishPondData> FishPondData(LocalizedContentManager content)
	{
		return Load<List<FishPondData>>(content, "Data\\FishPondData");
	}

	public static Dictionary<string, FloorPathData> FloorsAndPaths(LocalizedContentManager content)
	{
		return Load<Dictionary<string, FloorPathData>>(content, "Data\\FloorsAndPaths");
	}

	public static Dictionary<string, FruitTreeData> FruitTrees(LocalizedContentManager content)
	{
		return Load<Dictionary<string, FruitTreeData>>(content, "Data\\FruitTrees");
	}

	public static Dictionary<string, string> Furniture(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\Furniture");
	}

	public static GarbageCanData GarbageCans(LocalizedContentManager content)
	{
		return Load<GarbageCanData>(content, "Data\\GarbageCans");
	}

	public static Dictionary<string, GiantCropData> GiantCrops(LocalizedContentManager content)
	{
		return Load<Dictionary<string, GiantCropData>>(content, "Data\\GiantCrops");
	}

	public static Dictionary<int, string> HairData(LocalizedContentManager content)
	{
		return Load<Dictionary<int, string>>(content, "Data\\HairData");
	}

	public static Dictionary<string, string> Hats(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\hats");
	}

	public static Dictionary<string, HomeRenovation> HomeRenovations(LocalizedContentManager content)
	{
		return Load<Dictionary<string, HomeRenovation>>(content, "Data\\HomeRenovations");
	}

	public static Dictionary<string, IncomingPhoneCallData> IncomingPhoneCalls(LocalizedContentManager content)
	{
		return Load<Dictionary<string, IncomingPhoneCallData>>(content, "Data\\IncomingPhoneCalls");
	}

	public static Dictionary<string, JukeboxTrackData> JukeboxTracks(LocalizedContentManager content)
	{
		return Load<Dictionary<string, JukeboxTrackData>>(content, "Data\\JukeboxTracks");
	}

	public static Dictionary<string, LocationContextData> LocationContexts(LocalizedContentManager content)
	{
		return Load<Dictionary<string, LocationContextData>>(content, "Data\\LocationContexts");
	}

	public static Dictionary<string, LocationData> Locations(LocalizedContentManager content)
	{
		return Load<Dictionary<string, LocationData>>(content, "Data\\Locations");
	}

	public static Dictionary<string, MachineData> Machines(LocalizedContentManager content)
	{
		return Load<Dictionary<string, MachineData>>(content, "Data\\Machines");
	}

	public static Dictionary<string, string> Mail(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\mail");
	}

	public static List<MakeoverOutfit> MakeoverOutfits(LocalizedContentManager content)
	{
		return content.Load<List<MakeoverOutfit>>("Data\\MakeoverOutfits");
	}

	public static Dictionary<string, MannequinData> Mannequins(LocalizedContentManager content)
	{
		return content.Load<Dictionary<string, MannequinData>>("Data\\Mannequins");
	}

	public static Dictionary<string, MinecartNetworkData> Minecarts(LocalizedContentManager content)
	{
		return Load<Dictionary<string, MinecartNetworkData>>(content, "Data\\Minecarts");
	}

	public static Dictionary<string, string> Monsters(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\Monsters");
	}

	public static Dictionary<string, MonsterSlayerQuestData> MonsterSlayerQuests(LocalizedContentManager content)
	{
		return Load<Dictionary<string, MonsterSlayerQuestData>>(content, "Data\\MonsterSlayerQuests");
	}

	public static List<MovieData> Movies(LocalizedContentManager content)
	{
		return Load<List<MovieData>>(content, "Data\\Movies");
	}

	public static List<MovieCharacterReaction> MoviesReactions(LocalizedContentManager content)
	{
		return Load<List<MovieCharacterReaction>>(content, "Data\\MoviesReactions");
	}

	public static Dictionary<string, MuseumRewards> MuseumRewards(LocalizedContentManager content)
	{
		return Load<Dictionary<string, MuseumRewards>>(content, "Data\\MuseumRewards");
	}

	public static Dictionary<string, string> NpcGiftTastes(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\NPCGiftTastes");
	}

	public static Dictionary<string, ObjectData> Objects(LocalizedContentManager content)
	{
		return Load<Dictionary<string, ObjectData>>(content, "Data\\Objects");
	}

	public static Dictionary<string, string> PaintData(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\PaintData");
	}

	public static Dictionary<string, PantsData> Pants(LocalizedContentManager content)
	{
		return Load<Dictionary<string, PantsData>>(content, "Data\\Pants");
	}

	public static Dictionary<string, PassiveFestivalData> PassiveFestivals(LocalizedContentManager content)
	{
		return Load<Dictionary<string, PassiveFestivalData>>(content, "Data\\PassiveFestivals");
	}

	public static Dictionary<string, PetData> Pets(LocalizedContentManager content)
	{
		return Load<Dictionary<string, PetData>>(content, "Data\\Pets");
	}

	public static Dictionary<string, PowersData> Powers(LocalizedContentManager content)
	{
		return content.Load<Dictionary<string, PowersData>>("Data\\Powers");
	}

	public static Dictionary<string, string> Quests(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\Quests");
	}

	public static List<RandomBundleData> RandomBundles(LocalizedContentManager content)
	{
		return Load<List<RandomBundleData>>(content, "Data\\RandomBundles");
	}

	public static Dictionary<int, string> SecretNotes(LocalizedContentManager content)
	{
		return Load<Dictionary<int, string>>(content, "Data\\SecretNotes");
	}

	public static Dictionary<string, ShirtData> Shirts(LocalizedContentManager content)
	{
		return Load<Dictionary<string, ShirtData>>(content, "Data\\Shirts");
	}

	public static Dictionary<string, ShopData> Shops(LocalizedContentManager content)
	{
		return Load<Dictionary<string, ShopData>>(content, "Data\\Shops");
	}

	public static Dictionary<string, SpecialOrderData> SpecialOrders(LocalizedContentManager content)
	{
		return Load<Dictionary<string, SpecialOrderData>>(content, "Data\\SpecialOrders");
	}

	public static List<TailorItemRecipe> TailoringRecipes(LocalizedContentManager content)
	{
		return Load<List<TailorItemRecipe>>(content, "Data\\TailoringRecipes");
	}

	public static Dictionary<string, ToolData> Tools(LocalizedContentManager content)
	{
		return Load<Dictionary<string, ToolData>>(content, "Data\\Tools");
	}

	public static List<TriggerActionData> TriggerActions(LocalizedContentManager content)
	{
		return Load<List<TriggerActionData>>(content, "Data\\TriggerActions");
	}

	public static Dictionary<string, TrinketData> Trinkets(LocalizedContentManager content)
	{
		return content.Load<Dictionary<string, TrinketData>>("Data\\Trinkets");
	}

	public static Dictionary<string, WeaponData> Weapons(LocalizedContentManager content)
	{
		return Load<Dictionary<string, WeaponData>>(content, "Data\\Weapons");
	}

	public static WeddingData Weddings(LocalizedContentManager content)
	{
		return Load<WeddingData>(content, "Data\\Weddings");
	}

	public static Dictionary<string, WildTreeData> WildTrees(LocalizedContentManager content)
	{
		return Load<Dictionary<string, WildTreeData>>(content, "Data\\WildTrees");
	}

	public static Dictionary<string, WorldMapRegionData> WorldMap(LocalizedContentManager content)
	{
		return Load<Dictionary<string, WorldMapRegionData>>(content, "Data\\WorldMap");
	}

	public static Dictionary<string, string> Tv_CookingChannel(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\TV\\CookingChannel");
	}

	public static Dictionary<string, string> Tv_TipChannel(LocalizedContentManager content)
	{
		return Load<Dictionary<string, string>>(content, "Data\\TV\\TipChannel");
	}

	private static TAsset Load<TAsset>(LocalizedContentManager content, string assetName)
	{
		try
		{
			return content.Load<TAsset>(assetName);
		}
		catch (Exception innerException)
		{
			throw new ContentLoadException("Failed loading asset '" + assetName + "'.", innerException);
		}
	}
}
