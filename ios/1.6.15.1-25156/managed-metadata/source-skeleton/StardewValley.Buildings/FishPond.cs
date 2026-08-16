using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.GameData.FishPonds;
using StardewValley.Network;

namespace StardewValley.Buildings;

public class FishPond : Building
{
	public const int MAXIMUM_OCCUPANCY = 10;

	public static readonly float FISHING_MILLISECONDS;

	public static readonly int HARVEST_BASE_EXP;

	public static readonly float HARVEST_OUTPUT_EXP_MULTIPLIER;

	public static readonly int QUEST_BASE_EXP;

	public static readonly float QUEST_SPAWNRATE_EXP_MULTIPIER;

	public const int NUMBER_OF_NETTING_STYLE_TYPES = 4;

	[XmlArrayItem("int")]
	public readonly NetString fishType;

	public readonly NetInt lastUnlockedPopulationGate;

	public readonly NetBool hasCompletedRequest;

	public readonly NetBool goldenAnimalCracker;

	[XmlIgnore]
	public readonly NetBool isPlayingGoldenCrackerAnimation;

	public readonly NetRef<Object> sign;

	public readonly NetColor overrideWaterColor;

	public readonly NetRef<Item> output;

	public readonly NetRef<Item> neededItem;

	public readonly NetIntDelta neededItemCount;

	public readonly NetInt daysSinceSpawn;

	public readonly NetInt nettingStyle;

	public readonly NetInt seedOffset;

	public readonly NetBool hasSpawnedFish;

	[XmlIgnore]
	public readonly NetMutex needsMutex;

	[XmlIgnore]
	protected bool _hasAnimatedSpawnedFish;

	[XmlIgnore]
	protected float _delayUntilFishSilhouetteAdded;

	[XmlIgnore]
	protected int _numberOfFishToJump;

	[XmlIgnore]
	protected float _timeUntilFishHop;

	[XmlIgnore]
	protected Object _fishObject;

	[XmlIgnore]
	public List<PondFishSilhouette> _fishSilhouettes;

	[XmlIgnore]
	public List<JumpingFish> _jumpingFish;

	[XmlIgnore]
	private readonly NetEvent0 animateHappyFishEvent;

	[XmlIgnore]
	public TemporaryAnimatedSpriteList animations;

	[XmlIgnore]
	protected FishPondData _fishPondData;

	public int FishCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishPond(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishPond()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFishTypeChanged(NetString field, string old_value, string new_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Reseed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<PondFishSilhouette> GetFishSilhouettes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateMaximumOccupancy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishPondData GetFishPondData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FishPondData GetRawData(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetFishProduce(Random random = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Item CreateFishInstance()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool doAction(Vector2 tileLocation, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AnimateHappyFish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetItemBucketTile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetRequestTile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetCenterTile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResolveNeeds(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool isLegalFishForPonds(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void showObjectThrownIntoPondAnimation(Farmer who, Object whichObject, Action callback = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool addFishToPond(Farmer who, Object fish)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void dayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doFishSpecificWaterColoring()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Color? GetWaterColor(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool JumpFish()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnFish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performActiveObjectDropInAction(Farmer who, bool probe)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performToolAction(Tool t, int tileX, int tileY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performActionOnConstruction(GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performActionOnBuildingPlacement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasUnresolvedNeeds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TryGetNeededItemData(out string itemId, out int count)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearPond()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object CatchFish()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object GetFishObject()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isTileFishable(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanRefillWateringCan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle? getSourceRectForMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndMove()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidSignItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
