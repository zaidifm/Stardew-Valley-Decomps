using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Buffs;
using StardewValley.Enchantments;
using StardewValley.GameData.Weapons;

namespace StardewValley.Tools;

public class MeleeWeapon : Tool
{
	public const int defenseCooldownTime = 1500;

	public const int daggerCooldownTime = 3000;

	public const int clubCooldownTime = 6000;

	public const int millisecondsPerSpeedPoint = 40;

	public const int defaultSpeed = 400;

	public const int stabbingSword = 0;

	public const int dagger = 1;

	public const int club = 2;

	public const int defenseSword = 3;

	public const int baseClubSpeed = -8;

	public const string scytheId = "47";

	public const string goldenScytheId = "53";

	public const string iridiumScytheID = "66";

	public const string galaxySwordId = "4";

	public const int MAX_FORGES = 3;

	[XmlElement("type")]
	public readonly NetInt type;

	[XmlElement("minDamage")]
	public readonly NetInt minDamage;

	[XmlElement("maxDamage")]
	public readonly NetInt maxDamage;

	[XmlElement("speed")]
	public readonly NetInt speed;

	[XmlElement("addedPrecision")]
	public readonly NetInt addedPrecision;

	[XmlElement("addedDefense")]
	public readonly NetInt addedDefense;

	[XmlElement("addedAreaOfEffect")]
	public readonly NetInt addedAreaOfEffect;

	[XmlElement("knockback")]
	public readonly NetFloat knockback;

	[XmlElement("critChance")]
	public readonly NetFloat critChance;

	[XmlElement("critMultiplier")]
	public readonly NetFloat critMultiplier;

	[XmlElement("appearance")]
	public readonly NetString appearance;

	public bool isOnSpecial;

	public static int defenseCooldown;

	public static int attackSwordCooldown;

	public static int daggerCooldown;

	public static int clubCooldown;

	public static int daggerHitsLeft;

	public static int timedHitTimer;

	internal static float addedSwordScale;

	internal static float addedClubScale;

	internal static float addedDaggerScale;

	private float swipeSpeed;

	[XmlIgnore]
	public Rectangle mostRecentArea;

	[XmlIgnore]
	private readonly NetEvent0 animateSpecialMoveEvent;

	[XmlIgnore]
	private readonly NetEvent0 defenseSwordEvent;

	[XmlIgnore]
	private readonly NetEvent1Field<int, NetInt> daggerEvent;

	private WeaponData cachedData;

	private bool anotherClick;

	internal static Vector2 center;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MeleeWeapon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MeleeWeapon(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void ReloadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WeaponData GetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(string itemId, out WeaponData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanBeLostOnDeath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddEquipmentEffects(BuffEffects effects)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetMaxForges()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void GetOneCopyFrom(Item source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string loadDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string loadDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getCategoryName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string checkForSpecialItemHoldUpMeessage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int maximumStackSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int salePrice(bool ignoreProfitMargins = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void weaponsTypeUpdate(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void tickUpdate(GameTime time, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool doesShowTileLocationMarker()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getNumberOfDescriptionCategories()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClick(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isScythe()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsScythe(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getItemLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item attemptAddRandomInnateEnchantment(Item item, Random r, bool force = false, List<BaseEnchantment> enchantsToReroll = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float defaultKnockBackForThisType(int type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle getAreaOfEffect(int x, int y, int facingDirection, ref Vector2 tileLocation1, ref Vector2 tileLocation2, Rectangle wielderBoundingBox, int indexInCurrentAnimation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void triggerDefenseSwordFunction(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doDefenseSwordFunction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void triggerDaggerFunction(Farmer who, int dagger_hits_left)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doDaggerFunction(int dagger_hits)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void triggerClubFunction(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void beginSpecialMove(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void quickStab(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual int specialCooldown()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void animateSpecialMove(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void doAnimateSpecialMove()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doSwipe(int type, Vector2 position, int facingDirection, float swipeSpeed, Farmer f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FireProjectile(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setFarmerAnimating(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void actionWhenStopBeingHeld(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RecalculateAppliedForges(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoDamage(GameLocation location, int x, int y, int facingDirection, int power, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDrawnItemId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawTooltip(SpriteBatch spriteBatch, ref int x, ref int y, SpriteFont font, float alpha, StringBuilder overrideText)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Point getExtraSpaceNeededForTooltipSpecialIcons(SpriteFont font, int minWidth, int horizontalBuffer, int startingHeight, StringBuilder descriptionText, string boldTitleText, int moneyAmountToDisplayAtBottom)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetIndexOfMenuItemView()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawDuringUse(int frameOfFarmerAnimation, int facingDirection, SpriteBatch spriteBatch, Vector2 playerPosition, Farmer f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanForge(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanAddEnchantment(BaseEnchantment enchantment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isGalaxyWeapon()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void transform(string newItemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Forge(Item item, bool count_towards_stats = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawDuringUse(int frameOfFarmerAnimation, int facingDirection, SpriteBatch spriteBatch, Vector2 playerPosition, Farmer f, string weaponItemId, int type, bool isOnSpecial)
	{
	}
}
