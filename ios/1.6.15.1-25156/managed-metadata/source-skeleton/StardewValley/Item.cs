using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using Netcode.Validation;
using StardewValley.Buffs;
using StardewValley.Delegates;
using StardewValley.ItemTypeDefinitions;
using StardewValley.Mods;
using StardewValley.Objects;

namespace StardewValley;

[InstanceStatics]
[XmlInclude(typeof(Tool))]
[XmlInclude(typeof(SpecialItem))]
[XmlInclude(typeof(Ring))]
[XmlInclude(typeof(Object))]
[XmlInclude(typeof(Boots))]
[XmlInclude(typeof(Hat))]
[XmlInclude(typeof(Clothing))]
[XmlInclude(typeof(ModDataDictionary))]
[NotImplicitNetField]
public abstract class Item : IComparable, INetObject<NetFields>, ISalable, IHaveItemTypeId, IHaveModData
{
	public const string ErrorItemName = "Error Item";

	public bool isLostItem;

	private readonly NetInt specialVariable;

	[XmlElement("category")]
	public readonly NetInt category;

	[XmlElement("hasBeenInInventory")]
	public readonly NetBool hasbeenInInventory;

	private HashSet<string> _contextTags;

	protected bool _contextTagsDirty;

	[XmlIgnore]
	public Dictionary<string, object> tempData;

	[XmlIgnore]
	public bool drawInToolbar;

	[XmlIgnore]
	public bool drawCooldown;

	private int _itemSlotSize;

	[XmlIgnore]
	public string SetFlagOnPickup;

	[XmlElement("name")]
	public readonly NetString netName;

	[XmlElement("parentSheetIndex")]
	public readonly NetInt parentSheetIndex;

	[XmlElement("itemId")]
	public NetString itemId;

	[XmlIgnore]
	protected string _qualifiedItemId;

	public bool specialItem;

	[XmlElement("isRecipe")]
	public readonly NetBool isRecipe;

	[XmlElement("quality")]
	public readonly NetInt quality;

	[XmlElement("stack")]
	public readonly NetInt stack;

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

	[XmlIgnore]
	public int itemSlotSize
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

	public int SpecialVariable
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
	public int Category
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
	public bool HasBeenInInventory
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
	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public int ParentSheetIndex
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

	public abstract string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[XmlIgnore]
	public string ItemId
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
	public string QualifiedItemId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public abstract string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[XmlIgnore]
	public virtual string Name
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
	public virtual string BaseName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public virtual int Stack
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
	public int Quality
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
	public bool IsRecipe
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
	public bool IsInfiniteStock()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkContextTagsDirty()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HashSet<string> GetContextTags()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasContextTag(string tag)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _GenerateContextTags()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _PopulateContextTags(HashSet<string> tags)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Item()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldSerializeparentSheetIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetParentSheetIndex()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected string ValidateUnqualifiedItemId(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetItemTypeId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawTooltip(SpriteBatch spriteBatch, ref int x, ref int y, SpriteFont font, float alpha, StringBuilder overrideText)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ModifyItemBuffs(BuffEffects buffs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point getExtraSpaceNeededForTooltipSpecialIcons(SpriteFont font, int minWidth, int horizontalBuffer, int startingHeight, StringBuilder descriptionText, string boldTitleText, int moneyAmountToDisplayAtBottom)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldDrawIcon()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float getScaleSizeForMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawInMenuWithStackNumber(SpriteBatch spriteBatch, Vector2 location, float scaleSize, int stackNumber = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract int maximumStackSize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AdjustMenuDrawForRecipes(ref float transparency, ref float scale)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawMenuIcons(SpriteBatch sb, Vector2 location, float scale_size, float transparency, float layer_depth, StackDrawType drawStackNumber, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawIconBar(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int addToStack(Item otherStack)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract string getDescription();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract bool isPlaceable();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int sellToStorePrice(long specificPlayerID = -1L)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int salePrice(bool ignoreProfitMargins = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool appliesProfitMargins()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanBeLostOnDeath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canBeTrashed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canBePlacedInWater()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool actionWhenPurchased(string shopId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool LearnRecipe(Farmer player = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanBuyItem(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canBeDropped()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canBeShipped()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDetachedFromParent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onEquip(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onUnequip(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void actionWhenBeingHeld(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void actionWhenStopBeingHeld(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getRemainingStackSpace()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Item? ConsumeStack(int amount)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int healthRecoveredOnConsumption()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int staminaRecoveredOnConsumption()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getHoverBoxText(Item hoveredItem)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canBeGivenAsGift()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawAttachments(SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canBePlacedHere(GameLocation l, Vector2 tile, CollisionMask collisionMask = CollisionMask.All, bool showError = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int attachmentSlots()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getCategoryName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Color getCategoryColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canStackWith(ISalable other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string checkForSpecialItemHoldUpMeessage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item getOne()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract Item GetOneNew();

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void GetOneCopyFrom(Item source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyFieldsFrom(Item source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ISalable GetSalableInstance()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int CompareTo(object other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getCategorySortValue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getDescriptionWidth()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTempData<T>(string key, T value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetTempData<T>(string key, out T value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixStackSize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixQuality()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void resetState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasEquipmentBuffs()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddEquipmentEffects(BuffEffects effects)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerable<Buff> GetFoodOrDrinkBuffs()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GenerateLightSourceId(Farmer heldBy)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ForEachItem(ForEachItemDelegate handler, GetForEachItemPathDelegate getPath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
