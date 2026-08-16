using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Characters;
using StardewValley.Objects;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class FarmHouse : DecoratableLocation
{
	[XmlElement("fridge")]
	public readonly NetRef<Chest> fridge;

	[XmlIgnore]
	public readonly NetInt synchronizedDisplayedLevel;

	public Point fridgePosition;

	[XmlIgnore]
	public Point spouseRoomSpot;

	private string lastSpouseRoom;

	[XmlIgnore]
	private LocalizedContentManager mapLoader;

	public List<Warp> cellarWarps;

	[XmlElement("cribStyle")]
	public readonly NetInt cribStyle;

	[XmlIgnore]
	public int previousUpgradeLevel;

	private int currentlyDisplayedUpgradeLevel;

	private bool displayingSpouseRoom;

	private Color nightLightingColor;

	private Color rainLightingColor;

	[XmlIgnore]
	public virtual Farmer owner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MemberNotNullWhen(true, "owner")]
	[XmlIgnore]
	public virtual bool HasOwner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[MemberNotNullWhen(true, "owner")]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual long OwnerId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MemberNotNullWhen(true, "owner")]
	public bool IsOwnerActivated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[MemberNotNullWhen(true, "owner")]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MemberNotNullWhen(true, "owner")]
	public bool IsOwnedByCurrentPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[MemberNotNullWhen(true, "owner")]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public virtual int upgradeLevel
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmHouse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmHouse(string m, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddStarterGiftBox(Farm farm)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddStarterFurniture(Farm farm)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetStarterFlooring(Farm farm)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetStarterWallpaper(Farm farm)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetStarterFlooring(Farm farm, string styleToOverride = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetStarterWallpaper(Farm farm, string styleToOverride = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Child> getChildren()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getChildrenCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character, bool pathfinding, bool projectile = false, bool ignoreCharacterRequirement = false, bool skipCollisionEffects = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteUpdate(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void spouseSleepEndFunction(Character c, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point getFrontDoorSpot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point getPorchStandingSpot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point getKitchenStandingSpot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BedFurniture GetSpouseBed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point getSpouseBedSpot(string spouseName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point GetSpouseRoomSpot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BedFurniture GetBed(BedFurniture.BedType bed_type = BedFurniture.BedType.Any, int index = 0)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point GetPlayerBedSpot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BedFurniture GetPlayerBed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point getBedSpot(BedFurniture.BedType bed_type = BedFurniture.BedType.Any)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point getEntryLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BedFurniture GetChildBed(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point GetChildBedSpot(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isTilePlaceable(Vector2 v, bool itemIsPassable = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point getRandomOpenPointInHouse(Random r, int buffer = 0, int tries = 30)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point getFireplacePoint()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasNpcSpouseOrRoommate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasNpcSpouseOrRoommate(string spouseName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void showSpouseRoom()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddCellarTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Cellar GetCellar()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCellarName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateForRenovation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateFarmLayout()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _ApplyRenovations()
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
	private void addFurnitureIfSpaceIsFreePenny(List<Object> objectsToStoreInChests, Furniture f, Furniture heldObject = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void decoratePennyRoom(int whichStyle, List<Object> objectsToStoreInChests)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlaceInNearbySpace(Vector2 tileLocation, Object o)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RefreshFloorObjectNeighbors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void moveObjectsForHouseUpgrade(int whichUpgrade)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override LocalizedContentManager getMapLoader()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _updateAmbientLighting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setMapForUpgradeLevel(int level)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point? GetFridgePositionFromMap()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createCellarWarps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateCellarWarps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point GetSpouseRoomCorner()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void loadSpouseRoom()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Microsoft.Xna.Framework.Rectangle? GetCribBounds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateChildRoom()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playerDivorced()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<Microsoft.Xna.Framework.Rectangle> getForbiddenPetWarpTiles()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canPetWarpHere(Vector2 tile_position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Microsoft.Xna.Framework.Rectangle> getWalls()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Microsoft.Xna.Framework.Rectangle> getFloors()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanModifyCrib()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
