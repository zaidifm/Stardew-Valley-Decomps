using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Buildings;
using StardewValley.GameData;
using StardewValley.GameData.FarmAnimals;
using StardewValley.Network;
using StardewValley.Pathfinding;
using StardewValley.TerrainFeatures;
using StardewValley.Tools;
using xTile.Dimensions;

namespace StardewValley;

public class FarmAnimal : Character
{
	public const byte eatGrassBehavior = 0;

	public const short newHome = 0;

	public const short happy = 1;

	public const short neutral = 2;

	public const short unhappy = 3;

	public const short hungry = 4;

	public const short disturbedByDog = 5;

	public const short leftOutAtNight = 6;

	public const double chancePerUpdateToChangeDirection = 0.007;

	public const byte fullnessValueOfGrass = 60;

	public const int noWarpTimerTime = 3000;

	public new const double chanceForSound = 0.002;

	public const double chanceToGoOutside = 0.002;

	public const int uniqueDownFrame = 16;

	public const int uniqueRightFrame = 18;

	public const int uniqueUpFrame = 20;

	public const int uniqueLeftFrame = 22;

	public const int pushAccumulatorTimeTillPush = 60;

	public const int timePerUniqueFrame = 500;

	public const string ErrorTextureName = "Animals\\Error";

	public const int ErrorSpriteSize = 16;

	public NetBool isSwimming;

	[XmlIgnore]
	public Vector2 hopOffset;

	[XmlElement("currentProduce")]
	public readonly NetString currentProduce;

	[XmlElement("friendshipTowardFarmer")]
	public readonly NetInt friendshipTowardFarmer;

	[XmlElement("skinID")]
	public readonly NetString skinID;

	[XmlIgnore]
	public int pushAccumulator;

	[XmlIgnore]
	public int uniqueFrameAccumulator;

	[XmlElement("age")]
	public readonly NetInt age;

	[XmlElement("daysOwned")]
	public readonly NetInt daysOwned;

	[XmlElement("health")]
	public readonly NetInt health;

	[XmlElement("produceQuality")]
	public readonly NetInt produceQuality;

	[XmlElement("daysSinceLastLay")]
	public readonly NetInt daysSinceLastLay;

	[XmlElement("happiness")]
	public readonly NetInt happiness;

	[XmlElement("fullness")]
	public readonly NetInt fullness;

	[XmlElement("wasAutoPet")]
	public readonly NetBool wasAutoPet;

	[XmlElement("wasPet")]
	public readonly NetBool wasPet;

	[XmlElement("allowReproduction")]
	public readonly NetBool allowReproduction;

	[XmlElement("type")]
	public readonly NetString type;

	[XmlElement("buildingTypeILiveIn")]
	public readonly NetString buildingTypeILiveIn;

	[XmlElement("myID")]
	public readonly NetLong myID;

	[XmlElement("ownerID")]
	public readonly NetLong ownerID;

	[XmlElement("parentId")]
	public readonly NetLong parentId;

	[XmlIgnore]
	private readonly NetLocationRef netHomeInterior;

	[XmlElement("hasEatenAnimalCracker")]
	public readonly NetBool hasEatenAnimalCracker;

	[XmlIgnore]
	public int noWarpTimer;

	[XmlIgnore]
	public int hitGlowTimer;

	[XmlIgnore]
	public int pauseTimer;

	[XmlElement("moodMessage")]
	public readonly NetInt moodMessage;

	[XmlElement("isEating")]
	public readonly NetBool isEating;

	[XmlIgnore]
	private readonly NetEvent1Field<int, NetInt> doFarmerPushEvent;

	[XmlIgnore]
	private readonly NetEvent0 doBuildingPokeEvent;

	[XmlIgnore]
	private readonly NetEvent0 doDiveEvent;

	private string _displayHouse;

	private string _displayType;

	public static int NumPathfindingThisTick;

	public static int MaxPathfindingPerTick;

	[XmlIgnore]
	public int nextRipple;

	[XmlIgnore]
	public int nextFollowDirectionChange;

	protected FarmAnimal _followTarget;

	protected Point? _followTargetPosition;

	protected float _nextFollowTargetScan;

	[XmlIgnore]
	public int bobOffset;

	[XmlIgnore]
	protected Vector2 _swimmingVelocity;

	[XmlIgnore]
	public static HashSet<Grass> reservedGrass;

	[XmlIgnore]
	public Grass foundGrass;

	[XmlIgnore]
	public Building home
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

	[XmlIgnore]
	public GameLocation homeInterior
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

	[XmlIgnore]
	public string displayHouse
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

	[XmlIgnore]
	public string displayType
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

	public override string displayName
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

	[MemberNotNullWhen(true, "home")]
	public bool IsHome
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[MemberNotNullWhen(true, "home")]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmAnimal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmAnimal(string type, long id, long ownerID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimatedSprite GetOrLoadTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReloadTextureIfNeeded(bool forceReload = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetTexturePath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetTexturePath(FarmAnimalData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FarmAnimalData GetAnimalDataFromEgg(Item eggItem, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetAnimalDataFromEgg(Item eggItem, GameLocation location, out string id, out FarmAnimalData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual FarmAnimalData GetAnimalData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDisplayName(string id, bool forShop = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetShopDescription(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string shortDisplayType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Microsoft.Xna.Framework.Rectangle GetHarvestBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Microsoft.Xna.Framework.Rectangle GetCursorPetBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Microsoft.Xna.Framework.Rectangle GetBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void reload(GameLocation homeInterior)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void reload(Building home)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDaysOwned()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void pet(Farmer who, bool is_auto_pet = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void farmerPushing()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doDive()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doFarmerPush(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Poke()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doBuildingPoke()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setRandomPosition(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopAllActions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HandleStatsOnProduceCollected(Item item, uint amount = 1u)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HandleStats(List<StatIncrement> stats, Item item, uint amount = 1u)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetProduceID(Random r, bool deluxe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void dayUpdate(GameLocation environment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDayStarted()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getSellPrice()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isMale()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getMoodMessage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isAdult()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isBaby()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanGetProduceWithTool(Tool tool)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmAnimalHarvestType? GetHarvestType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanLiveIn(Building building)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void warpHome()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void growFully(Random random = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateWhenNotCurrentLocation(Building currentBuilding, GameTime time, GameLocation environment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void behaviorAfterFindingGrassPatch(Character c, GameLocation environment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool grassEndPointFunction(PathNode currentPoint, Point endPoint, GameLocation location, Character c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updatePerTenMinutes(int timeOfDay, GameLocation environment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void eatGrass(GameLocation environment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Eat(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool behaviors(GameTime time, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DigUpProduce(GameLocation location, Object produce)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Microsoft.Xna.Framework.Rectangle GetFollowRange(FarmAnimal animal, int distance = 2)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetNewFollowPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void hitWithWeapon(MeleeWeapon t)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void makeSound()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetSoundId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanHavePregnancy()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool SleepIfNecessary()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isMoving()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool updateWhenCurrentLocation(GameTime time, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateRandomMovements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanSwim()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanFollowAdult()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldCollideWithBuildingLayer(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HandleHop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MovePosition(GameTime time, xTile.Dimensions.Rectangle viewport, GameLocation currentLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HandleCollision(Microsoft.Xna.Framework.Rectangle next_position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsActuallySwimming()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Splash()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void animateInFacingDirection(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ValidateSpritesheetSize()
	{
	}
}
