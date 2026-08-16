using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using Netcode.Validation;
using StardewValley.Buildings;
using StardewValley.Inventories;
using xTile;
using xTile.Dimensions;
using xTile.Tiles;

namespace StardewValley;

public class Farm : GameLocation
{
	public class LightningStrikeEvent : NetEventArg
	{
		public Vector2 boltPosition;

		public bool createBolt;

		public bool bigFlash;

		public bool smallFlash;

		public bool destroyedTerrainFeature;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Read(BinaryReader reader)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(BinaryWriter writer)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LightningStrikeEvent()
		{
		}
	}

	[XmlIgnore]
	[NonInstancedStatic]
	public static Texture2D houseTextures;

	[NotNetField]
	public NetRef<BuildingPaintColor> housePaintColor;

	public const int default_layout = 0;

	public const int riverlands_layout = 1;

	public const int forest_layout = 2;

	public const int mountains_layout = 3;

	public const int combat_layout = 4;

	public const int fourCorners_layout = 5;

	public const int beach_layout = 6;

	public const int mod_layout = 7;

	public const int layout_max = 7;

	[XmlElement("grandpaScore")]
	public readonly NetInt grandpaScore;

	[XmlElement("farmCaveReady")]
	public NetBool farmCaveReady;

	private TemporaryAnimatedSprite shippingBinLid;

	private Microsoft.Xna.Framework.Rectangle shippingBinLidOpenArea;

	[XmlIgnore]
	private readonly NetRef<Inventory> sharedShippingBin;

	[XmlIgnore]
	public Item lastItemShipped;

	public bool hasSeenGrandpaNote;

	protected Dictionary<string, Dictionary<Point, Tile>> _baseSpouseAreaTiles;

	[XmlIgnore]
	public bool hasMatureFairyRoseTonight;

	[XmlElement("greenhouseUnlocked")]
	public readonly NetBool greenhouseUnlocked;

	[XmlElement("greenhouseMoved")]
	public readonly NetBool greenhouseMoved;

	private readonly NetEvent1Field<Vector2, NetVector2> spawnCrowEvent;

	public readonly NetEvent1<LightningStrikeEvent> lightningStrikeEvent;

	[XmlIgnore]
	public Point? mapGrandpaShrinePosition;

	[XmlIgnore]
	public Point? mapMainMailboxPosition;

	[XmlIgnore]
	public Point? mainFarmhouseEntry;

	[XmlIgnore]
	public Vector2? mapSpouseAreaCorner;

	[XmlIgnore]
	public Vector2? mapShippingBinPosition;

	protected Microsoft.Xna.Framework.Rectangle? _mountainForageRectangle;

	protected bool? _shouldSpawnForestFarmForage;

	protected bool? _shouldSpawnBeachFarmForage;

	protected bool? _oceanCrabPotOverride;

	protected string _fishLocationOverride;

	protected float _fishChanceOverride;

	public Point spousePatioSpot;

	public const int numCropsForCrow = 16;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farm(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsBuildableLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddDefaultBuildings(bool load = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 GetStarterShippingBinLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 GetStarterPetBowlLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 GetStarterFarmhouseLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 GetGreenhouseStartLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ClearGreenhouseGrassTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getMapNameFromTypeInt(int type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void onNewGame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doDailyMountainFarmUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool catchOceanCrabPotFishFromThisSpot(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addCrows()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doSpawnCrow(Vector2 v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point getFrontDoorPositionForFarmer(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteUpdate(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void spawnGroundMonsterOffScreen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void spawnFlyingMonstersOffScreen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void requestGrandpaReevaluation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnMapLoad(Map map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnBuildingMoved(Building building)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ShouldExcludeFromNpcPathfinding()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void grandpaStatueCallback(Item item, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IInventory getShippingBin(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void shipItem(Item i, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnsetFarmhouseValues()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showShipment(Item item, bool playThrowSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Item getFish(float millisecondsAfterNibble, string bait, int waterDepth, Farmer who, double baitPotency, Vector2 bobberTile, string location = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdatePatio()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 GetSpouseOutdoorAreaCorner()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CacheOffBasePatioArea()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReapplyBasePatioArea()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addSpouseOutdoorArea(string spouseName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addGrandpaCandles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void openShippingBinLid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void closeShippingBinLid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateShippingBinLid(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool isShippingBinLidOpen(bool requiredToBeFullyOpen = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void pokeTileForConstruction(Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldShadowBeDrawnAboveBuildingsLayer(Vector2 p)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point GetMainMailboxPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point GetGrandpaShrinePosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point GetMainFarmHouseEntry()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Building GetMainFarmHouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ResetForEvent(Event ev)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool skipWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileOpenBesidesTerrainFeatures(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doLightningStrike(LightningStrikeEvent lightning)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldSpawnMountainOres()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldSpawnForestFarmForage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldSpawnBeachFarmForage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SpawnsForage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool doesFarmCaveNeedHarvesting()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
