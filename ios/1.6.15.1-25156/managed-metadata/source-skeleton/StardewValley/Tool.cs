using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Buffs;
using StardewValley.Enchantments;
using StardewValley.GameData.Tools;
using StardewValley.Tools;

namespace StardewValley;

[XmlInclude(typeof(Pan))]
[XmlInclude(typeof(Pickaxe))]
[XmlInclude(typeof(MilkPail))]
[XmlInclude(typeof(Slingshot))]
[XmlInclude(typeof(Wand))]
[XmlInclude(typeof(Shears))]
[XmlInclude(typeof(MeleeWeapon))]
[XmlInclude(typeof(WateringCan))]
[XmlInclude(typeof(Hoe))]
[XmlInclude(typeof(GenericTool))]
[XmlInclude(typeof(FishingRod))]
[XmlInclude(typeof(ErrorTool))]
[XmlInclude(typeof(Axe))]
[XmlInclude(typeof(MagnifyingGlass))]
public abstract class Tool : Item
{
	public const int standardStaminaReduction = 2;

	public const int stone = 0;

	public const int copper = 1;

	public const int steel = 2;

	public const int gold = 3;

	public const int iridium = 4;

	public const int hammerSpriteIndex = 105;

	public const int wateringCanSpriteIndex = 273;

	public const int fishingRodSpriteIndex = 8;

	public const int wateringCanMenuIndex = 296;

	public const string weaponsTextureName = "TileSheets\\weapons";

	public static Texture2D weaponsTexture;

	[XmlElement("initialParentTileIndex")]
	public readonly NetInt initialParentTileIndex;

	[XmlElement("currentParentTileIndex")]
	public readonly NetInt currentParentTileIndex;

	[XmlElement("indexOfMenuItemView")]
	public readonly NetInt indexOfMenuItemView;

	[XmlElement("instantUse")]
	public readonly NetBool instantUse;

	[XmlElement("isEfficient")]
	public readonly NetBool isEfficient;

	[XmlElement("animationSpeedModifier")]
	public readonly NetFloat animationSpeedModifier;

	public int swingTicker;

	[XmlIgnore]
	private string _description;

	[XmlElement("upgradeLevel")]
	public readonly NetInt upgradeLevel;

	[XmlElement("numAttachmentSlots")]
	public readonly NetInt numAttachmentSlots;

	[XmlIgnore]
	public Farmer lastUser;

	public readonly NetObjectArray<Object> attachments;

	[XmlIgnore]
	protected string displayName;

	[XmlElement("enchantments")]
	public readonly NetList<BaseEnchantment, NetRef<BaseEnchantment>> enchantments;

	[XmlElement("previousEnchantments")]
	public readonly NetStringList previousEnchantments;

	[XmlIgnore]
	public bool PlayUseSounds;

	[XmlIgnore]
	public string description
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

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public override string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int CurrentParentTileIndex
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

	public int InitialParentTileIndex
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

	public int IndexOfMenuItemView
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
	public int UpgradeLevel
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
	public int AttachmentSlotsCount
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

	public bool InstantUse
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

	public bool IsEfficient
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

	public float AnimationSpeedModifier
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
	public Tool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Tool(string name, int upgradeLevel, int initialParentTileIndex, int indexOfMenuItemView, bool stackable, int numAttachmentSlots = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSpriteIndex(int spriteIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected new virtual void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string loadDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string loadDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanBeLostOnDeath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getCategoryName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void GetOneCopyFrom(Item source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpgradeFrom(Tool other)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Color getCategoryColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolData GetToolData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAttachments(SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DrawAttachmentSlot(int slot, SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void GetAttachmentSlotSprite(int slot, out Texture2D texture, out Rectangle sourceRect)
	{
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
	public virtual void tickUpdate(GameTime time, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isHeavyHitter()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isScythe()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(int direction, int farmerMotionFrame, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int salePrice(bool ignoreProfitMargins = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int attachmentSlots()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farmer getLastFarmerToUse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void leftClick(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void endUsing(GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool beginUsing(GameLocation location, int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool onRelease(GameLocation location, int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canBeDropped()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canThisBeAttached(Object o)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool canThisBeAttached(Object o, int slot)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Object attach(Object o)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void actionWhenClaimed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanBuyItem(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool actionWhenPurchased(string shopId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected List<Vector2> tilesAffected(Vector2 tileLocation, int power, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool doesShowTileLocationMarker()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPlaceable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int maximumStackSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int getDescriptionWidth()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ClearEnchantments()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetMaxForges()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanAddEnchantment(BaseEnchantment enchantment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CopyEnchantments(Tool source, Tool destination)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTotalForgeLevels(bool for_unforge = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool AddEnchantment(BaseEnchantment enchantment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasEnchantmentOfType<T>()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveEnchantment(BaseEnchantment enchantment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void actionWhenBeingHeld(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void actionWhenStopBeingHeld(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanUseOnStandingTile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddEquipmentEffects(BuffEffects effects)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanForge(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetEnchantmentOfType<T>() where T : BaseEnchantment
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEnchantmentLevel<T>() where T : BaseEnchantment
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool Forge(Item item, bool count_towards_stats = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
