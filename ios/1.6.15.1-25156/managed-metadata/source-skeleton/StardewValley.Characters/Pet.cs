using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Buildings;
using StardewValley.GameData.Pets;
using StardewValley.Network;
using StardewValley.Objects;

namespace StardewValley.Characters;

public class Pet : NPC
{
	public const string type_cat = "Cat";

	public const string type_dog = "Dog";

	[XmlElement("guid")]
	public NetGuid petId;

	public const int bedTime = 2000;

	public const int maxFriendship = 1000;

	public const string behavior_Walk = "Walk";

	public const string behavior_Sleep = "Sleep";

	public const string behavior_SitDown = "SitDown";

	public const string behavior_Sprint = "Sprint";

	protected int behaviorTimer;

	protected int animationLoopsLeft;

	[XmlElement("petType")]
	public readonly NetString petType;

	[XmlElement("whichBreed")]
	public readonly NetString whichBreed;

	private readonly NetString netCurrentBehavior;

	[XmlElement("homeLocationName")]
	public readonly NetString homeLocationName;

	[XmlIgnore]
	public readonly NetEvent1Field<long, NetLong> petPushEvent;

	[XmlIgnore]
	protected string _currentBehavior;

	[XmlIgnore]
	public NetLongDictionary<int, NetInt> lastPetDay;

	[XmlElement("grantedFriendshipForPet")]
	public NetBool grantedFriendshipForPet;

	[XmlElement("friendshipTowardFarmer")]
	public NetInt friendshipTowardFarmer;

	[XmlElement("timesPet")]
	public NetInt timesPet;

	[XmlElement("hat")]
	public readonly NetRef<Hat> hat;

	protected int _walkFromPushTimer;

	public NetBool isSleepingOnFarmerBed;

	[XmlIgnore]
	public readonly NetMutex mutex;

	private int pushingTimer;

	[XmlIgnore]
	public override bool IsVillager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string CurrentBehavior
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
	public override void reloadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string translateName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pet(int xTile, int yTile, string petBreed, string petType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPetPush(long farmerId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int getTimeFarmerMustPushBeforeStartShaking()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int getTimeFarmerMustPushBeforePassingThrough()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorOnFarmerLocationEntry(GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorOnLocalFarmerLocationEntry(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canTalk()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PetData GetPetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(string petType, out PetData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetPetIcon(out string assetName, out Rectangle sourceRect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getPetTextureName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void reloadBreedSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChooseAppearance(LocalizedContentManager content = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void warpToFarmHouse(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateSleepingOnBed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void dayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GrantLoveMailIfNecessary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PetBowl GetPetBowl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void WarpToPetBowl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setAtFarmPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldCollideWithBuildingLayer(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canPassThroughActionTiles()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void unassignPetBowl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void applyButterflyPowder(Farmer who, string responseKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Farmer who, GameLocation l)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playContentSound()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void hold(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorOnFarmerPushing()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location, long id, bool move)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item TryGetGiftItem(List<PetGift> gifts)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryBehaviorChange(List<PetBehaviorChanges> changes)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PetBehavior GetCurrentPetBehavior()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RunState(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _OnNewBehavior()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnNewBehavior()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _PerformAnimationSound(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlaySound(string sound, bool is_voice, int range_from_border, int range)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSoundInRange(int range_from_border, int sound_range)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _TryAnimationEndBehaviorChange(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle GetBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawHat(SpriteBatch b, Vector2 shake)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool withinLocalPlayerThreshold(int threshold)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool withinPlayerThreshold(int threshold)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void hitGround(Farmer who)
	{
	}
}
