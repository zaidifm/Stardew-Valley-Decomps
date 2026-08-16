using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using Netcode.Validation;
using StardewValley.Delegates;
using StardewValley.GameData.Buildings;
using StardewValley.Internal;
using StardewValley.Mods;
using StardewValley.Objects;

namespace StardewValley.Buildings;

[NotImplicitNetField]
[XmlInclude(typeof(Stable))]
[XmlInclude(typeof(ShippingBin))]
[XmlInclude(typeof(PetBowl))]
[XmlInclude(typeof(Mill))]
[XmlInclude(typeof(JunimoHut))]
[XmlInclude(typeof(GreenhouseBuilding))]
[XmlInclude(typeof(FishPond))]
[XmlInclude(typeof(Coop))]
[XmlInclude(typeof(Barn))]
public class Building : INetObject<NetFields>, IHaveModData
{
	[XmlElement("id")]
	public readonly NetGuid id;

	[XmlIgnore]
	public Lazy<Texture2D> texture;

	[XmlIgnore]
	public Texture2D paintedTexture;

	public NetString skinId;

	[XmlElement("indoors")]
	public readonly NetRef<GameLocation> indoors;

	public readonly NetString nonInstancedIndoorsName;

	[XmlElement("tileX")]
	public readonly NetInt tileX;

	[XmlElement("tileY")]
	public readonly NetInt tileY;

	[XmlElement("tilesWide")]
	public readonly NetInt tilesWide;

	[XmlElement("tilesHigh")]
	public readonly NetInt tilesHigh;

	[XmlElement("maxOccupants")]
	public readonly NetInt maxOccupants;

	[XmlElement("currentOccupants")]
	public readonly NetInt currentOccupants;

	[XmlElement("daysOfConstructionLeft")]
	public readonly NetInt daysOfConstructionLeft;

	[XmlElement("daysUntilUpgrade")]
	public readonly NetInt daysUntilUpgrade;

	[XmlElement("upgradeName")]
	public readonly NetString upgradeName;

	[XmlElement("buildingType")]
	public readonly NetString buildingType;

	[XmlElement("buildingPaintColor")]
	public NetRef<BuildingPaintColor> netBuildingPaintColor;

	[XmlElement("hayCapacity")]
	public NetInt hayCapacity;

	public NetList<Chest, NetRef<Chest>> buildingChests;

	[XmlIgnore]
	public NetString parentLocationName;

	[XmlIgnore]
	public bool hasLoaded;

	[XmlIgnore]
	protected Dictionary<string, string> buildingMetadata;

	protected int lastHouseUpgradeLevel;

	protected bool? hasChimney;

	protected Vector2 chimneyPosition;

	protected int chimneyTimer;

	[XmlElement("humanDoor")]
	public readonly NetPoint humanDoor;

	[XmlElement("animalDoor")]
	public readonly NetPoint animalDoor;

	[XmlIgnore]
	public Color color;

	[XmlElement("animalDoorOpen")]
	public readonly NetBool animalDoorOpen;

	[XmlElement("animalDoorOpenAmount")]
	public readonly NetFloat animalDoorOpenAmount;

	[XmlElement("magical")]
	public readonly NetBool magical;

	[XmlElement("fadeWhenPlayerIsBehind")]
	public readonly NetBool fadeWhenPlayerIsBehind;

	[XmlElement("owner")]
	public readonly NetLong owner;

	[XmlElement("newConstructionTimer")]
	protected readonly NetInt newConstructionTimer;

	[XmlIgnore]
	public float alpha;

	[XmlIgnore]
	protected bool _isMoving;

	public static Rectangle leftShadow;

	public static Rectangle middleShadow;

	public static Rectangle rightShadow;

	[XmlIgnore]
	public ModDataDictionary modData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlElement("modData")]
	public ModDataDictionary modDataForSerialization
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool isCabin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool isMoving
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Building()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Building(string type, Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanBeReskinned(bool ignoreSeparateConstructionEntries = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AllowsAnimalPregnancy()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanBePainted()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuildingSkin GetSkin()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BuildingSkin GetSkin(string skinId, BuildingData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetPaintDataKey()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetPaintDataKey(Dictionary<string, string> paintData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetMetadata(string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameLocation GetParentLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInCurrentLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool hasCarpenterPermissions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateIndoorParent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BuildingData GetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(string buildingType, out BuildingData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BuildingData ReloadBuildingData(bool forUpgrade = false, bool forConstruction = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadFromBuildingData(BuildingData data, bool forUpgrade = false, bool forConstruction = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Building CreateInstanceFromId(string typeId, Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeIndoor(BuildingData data, bool forConstruction, bool forUpgrade)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuildingItemConversion GetItemConversionForItem(Item item, Chest chest)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidObjectForChest(Item item, Chest chest)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PerformBuildingChestAction(string name, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuildingChest GetBuildingChestData(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BuildingChest GetBuildingChestData(BuildingData data, string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chest GetBuildingChest(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string textureName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void resetTexture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getTileSheetIndexForStructurePlacementTile(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performTenMinuteAction(int timeElapsed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanLeftClick(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool leftClicked()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ToggleAnimalDoor(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnUseHumanDoor(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool doAction(Vector2 tileLocation, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryPerformObeliskWarp(string buildingType, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PerformObeliskWarp(string destination, int warp_x, int warp_y, bool force_dismount, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void obeliskWarpForReal(string destination, int warp_x, int warp_y, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isActionableTile(int xTile, int yTile, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performActionOnBuildingPlacement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performActionOnConstruction(GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performActionOnDemolition(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ForEachItemExcludingInterior(Func<Item, bool> action)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ForEachItemContextExcludingInterior(ForEachItemDelegate handler, GetForEachItemPathDelegate getParentPath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeDemolish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performActionOnUpgrade(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string isThereAnythingtoPreventConstruction(GameLocation location, Vector2 tile_location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool performActiveObjectDropInAction(Farmer who, bool probe)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performToolAction(Tool t, int tileX, int tileY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateWhenFarmNotCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateTransparency()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void showUpgradeAnimation(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 getUpgradeSignLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void showDestroyedAnimation(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FinishConstruction(bool onGameStart = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void dayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CheckItemConversionRule(BuildingItemConversion conversion, ItemQueryContext itemQueryContext)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUpgraded()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle getSourceRect()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle ApplySourceRectOffsets(Rectangle source)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle? getSourceRectForMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateInteriorWarps(GameLocation interior = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasIndoors()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasIndoorsName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetIndoorsName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IndoorsType GetIndoorsType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameLocation GetIndoors()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual GameLocation createIndoors(BuildingData data, string nameOfIndoorsWithoutUnique)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point getPointForHumanDoor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle getRectForHumanDoor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle getRectForAnimalDoor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle getRectForAnimalDoor(BuildingData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void load()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<BuildingPlacementTile> GetAdditionalPlacementTiles()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isUnderConstruction(bool ignoreUpgrades = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool occupiesTile(Vector2 tile, bool applyTilePropertyRadius = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool occupiesTile(int x, int y, bool applyTilePropertyRadius = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isTilePassable(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isTileOccupiedForPlacement(Vector2 tile, Object to_place)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Color? GetWaterColor(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isTileFishable(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanRefillWateringCan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle GetBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool intersects(Rectangle boundingBox)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawInMenu(SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawBackground(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldDrawShadow(BuildingData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawShadow(SpriteBatch b, int localX = -1, int localY = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartMove()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEndMove()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point getPorchStandingSpot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool doesTileHaveProperty(int tile_x, int tile_y, string property_name, string layer_name, ref string property_value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point getMailboxPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetAdditionalTilePropertyRadius()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeOverlappingBushes(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawInConstruction(SpriteBatch b)
	{
	}
}
