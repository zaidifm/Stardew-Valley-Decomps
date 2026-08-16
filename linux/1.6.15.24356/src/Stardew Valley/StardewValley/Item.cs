using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using Netcode.Validation;
using StardewValley.BellsAndWhistles;
using StardewValley.Buffs;
using StardewValley.Delegates;
using StardewValley.ItemTypeDefinitions;
using StardewValley.Mods;
using StardewValley.Objects;
using StardewValley.Objects.Trinkets;
using StardewValley.Tools;

namespace StardewValley;

[XmlInclude(typeof(Boots))]
[XmlInclude(typeof(Clothing))]
[XmlInclude(typeof(Hat))]
[XmlInclude(typeof(ModDataDictionary))]
[XmlInclude(typeof(Object))]
[XmlInclude(typeof(Ring))]
[XmlInclude(typeof(SpecialItem))]
[XmlInclude(typeof(Tool))]
[InstanceStatics]
[NotImplicitNetField]
public abstract class Item : IComparable, INetObject<NetFields>, ISalable, IHaveItemTypeId, IHaveModData
{
	public const string ErrorItemName = "Error Item";

	public bool isLostItem;

	private readonly NetInt specialVariable = new NetInt();

	[XmlElement("category")]
	public readonly NetInt category = new NetInt();

	[XmlElement("hasBeenInInventory")]
	public readonly NetBool hasbeenInInventory = new NetBool();

	private HashSet<string> _contextTags;

	protected bool _contextTagsDirty;

	[XmlIgnore]
	public Dictionary<string, object> tempData;

	[XmlIgnore]
	public string SetFlagOnPickup;

	[XmlElement("name")]
	public readonly NetString netName = new NetString("Error Item");

	[XmlElement("parentSheetIndex")]
	public readonly NetInt parentSheetIndex = new NetInt();

	[XmlElement("itemId")]
	public NetString itemId = new NetString();

	[XmlIgnore]
	protected string _qualifiedItemId;

	public bool specialItem;

	[XmlElement("isRecipe")]
	public readonly NetBool isRecipe = new NetBool();

	[XmlElement("quality")]
	public readonly NetInt quality = new NetInt(0);

	[XmlElement("stack")]
	public readonly NetInt stack = new NetInt(1);

	[XmlIgnore]
	public ModDataDictionary modData { get; } = new ModDataDictionary();

	[XmlElement("modData")]
	public ModDataDictionary modDataForSerialization
	{
		get
		{
			return modData.GetForSerialization();
		}
		set
		{
			modData.SetFromSerialization(value);
		}
	}

	public int SpecialVariable
	{
		get
		{
			return specialVariable.Value;
		}
		set
		{
			specialVariable.Set(value);
		}
	}

	[XmlIgnore]
	public int Category
	{
		get
		{
			return category.Value;
		}
		set
		{
			category.Set(value);
		}
	}

	[XmlIgnore]
	public bool HasBeenInInventory
	{
		get
		{
			return hasbeenInInventory.Value;
		}
		set
		{
			hasbeenInInventory.Set(value);
		}
	}

	[XmlIgnore]
	public NetFields NetFields { get; } = new NetFields("Item");

	[XmlIgnore]
	public int ParentSheetIndex
	{
		get
		{
			return parentSheetIndex.Value;
		}
		set
		{
			parentSheetIndex.Value = value;
		}
	}

	public abstract string TypeDefinitionId { get; }

	[XmlIgnore]
	public string ItemId
	{
		get
		{
			if (itemId.Value == null)
			{
				MigrateLegacyItemId();
			}
			return itemId.Value;
		}
		set
		{
			itemId.Value = value;
			_qualifiedItemId = null;
		}
	}

	[XmlIgnore]
	public string QualifiedItemId
	{
		get
		{
			if (_qualifiedItemId == null)
			{
				_qualifiedItemId = TypeDefinitionId + ItemId;
			}
			return _qualifiedItemId;
		}
	}

	public abstract string DisplayName { get; }

	[XmlIgnore]
	public virtual string Name
	{
		get
		{
			return netName.Value;
		}
		set
		{
			netName.Value = value;
		}
	}

	[XmlIgnore]
	public virtual string BaseName => Name;

	[XmlIgnore]
	public virtual int Stack
	{
		get
		{
			return Math.Max(0, stack.Value);
		}
		set
		{
			if (Game1.gameMode != 3)
			{
				stack.Value = value;
			}
			else
			{
				stack.Value = Math.Min(Math.Max(0, value), (value == int.MaxValue) ? value : maximumStackSize());
			}
		}
	}

	[XmlIgnore]
	public int Quality
	{
		get
		{
			return quality.Value;
		}
		set
		{
			quality.Value = value;
		}
	}

	[XmlIgnore]
	public bool IsRecipe
	{
		get
		{
			return isRecipe.Value;
		}
		set
		{
			isRecipe.Value = value;
		}
	}

	public bool IsInfiniteStock()
	{
		if (isLostItem)
		{
			return true;
		}
		return false;
	}

	public void MarkContextTagsDirty()
	{
		_contextTagsDirty = true;
	}

	public HashSet<string> GetContextTags()
	{
		if (_contextTags == null || _contextTagsDirty)
		{
			_GenerateContextTags();
		}
		return _contextTags;
	}

	public bool HasContextTag(string tag)
	{
		return ItemContextTagManager.DoesTagMatch(tag, GetContextTags());
	}

	protected void _GenerateContextTags()
	{
		_contextTagsDirty = false;
		_contextTags = new HashSet<string>(ItemContextTagManager.GetBaseContextTags(QualifiedItemId), StringComparer.OrdinalIgnoreCase);
		_PopulateContextTags(_contextTags);
	}

	protected virtual void _PopulateContextTags(HashSet<string> tags)
	{
		switch (quality.Value)
		{
		case 0:
			tags.Add("quality_none");
			break;
		case 1:
			tags.Add("quality_silver");
			break;
		case 2:
			tags.Add("quality_gold");
			break;
		case 4:
			tags.Add("quality_iridium");
			break;
		case 3:
			break;
		}
	}

	protected Item()
	{
		initNetFields();
		parentSheetIndex.Value = -1;
	}

	public virtual bool ShouldSerializeparentSheetIndex()
	{
		return parentSheetIndex.Value != -1;
	}

	protected virtual void MigrateLegacyItemId()
	{
		itemId.Value = ParentSheetIndex.ToString();
	}

	protected virtual void initNetFields()
	{
		NetFields.SetOwner(this).AddField(specialVariable, "specialVariable").AddField(category, "category")
			.AddField(netName, "netName")
			.AddField(parentSheetIndex, "parentSheetIndex")
			.AddField(hasbeenInInventory, "hasbeenInInventory")
			.AddField(itemId, "itemId")
			.AddField(stack, "stack")
			.AddField(quality, "quality")
			.AddField(isRecipe, "isRecipe")
			.AddField(modData, "modData");
		itemId.fieldChangeVisibleEvent += delegate
		{
			_qualifiedItemId = null;
			MarkContextTagsDirty();
		};
		netName.fieldChangeVisibleEvent += delegate(NetString field, string oldValue, string newValue)
		{
			if (newValue == null)
			{
				field.Value = "Error Item";
			}
		};
		quality.fieldChangeVisibleEvent += delegate
		{
			MarkContextTagsDirty();
		};
	}

	public void ResetParentSheetIndex()
	{
		ParentSheetIndex = ItemRegistry.GetDataOrErrorItem(QualifiedItemId).SpriteIndex;
	}

	protected string ValidateUnqualifiedItemId(string id)
	{
		if (ItemRegistry.IsQualifiedItemId(id))
		{
			string typeDefinitionId = TypeDefinitionId;
			if (id.StartsWith(typeDefinitionId))
			{
				Game1.log.Warn($"The {GetType().FullName} constructor was called with qualified item ID '{id}'. The '{typeDefinitionId}' prefix will be removed automatically.");
				id = id.Substring(typeDefinitionId.Length).TrimStart();
			}
			else
			{
				Game1.log.Warn($"The {GetType().FullName} constructor was called with qualified item ID '{id}'. This will likely result in an error item.");
			}
		}
		return id;
	}

	public string GetItemTypeId()
	{
		return TypeDefinitionId;
	}

	public virtual void drawTooltip(SpriteBatch spriteBatch, ref int x, ref int y, SpriteFont font, float alpha, StringBuilder overrideText)
	{
		if (overrideText != null && overrideText.Length != 0 && (overrideText.Length != 1 || overrideText[0] != ' '))
		{
			spriteBatch.DrawString(font, overrideText, new Vector2(x + 16, y + 16 + 4) + new Vector2(2f, 2f), Game1.textShadowColor * alpha);
			spriteBatch.DrawString(font, overrideText, new Vector2(x + 16, y + 16 + 4) + new Vector2(0f, 2f), Game1.textShadowColor * alpha);
			spriteBatch.DrawString(font, overrideText, new Vector2(x + 16, y + 16 + 4) + new Vector2(2f, 0f), Game1.textShadowColor * alpha);
			spriteBatch.DrawString(font, overrideText, new Vector2(x + 16, y + 16 + 4), Game1.textColor * 0.9f * alpha);
			y += (int)font.MeasureString(overrideText).Y + 4;
		}
	}

	public virtual void ModifyItemBuffs(BuffEffects buffs)
	{
	}

	public virtual Point getExtraSpaceNeededForTooltipSpecialIcons(SpriteFont font, int minWidth, int horizontalBuffer, int startingHeight, StringBuilder descriptionText, string boldTitleText, int moneyAmountToDisplayAtBottom)
	{
		return Point.Zero;
	}

	public bool ShouldDrawIcon()
	{
		return true;
	}

	public abstract void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow);

	public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber)
	{
		drawInMenu(spriteBatch, location, scaleSize, transparency, layerDepth, drawStackNumber, Color.White, drawShadow: true);
	}

	public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth)
	{
		drawInMenu(spriteBatch, location, scaleSize, transparency, layerDepth, StackDrawType.Draw, Color.White, drawShadow: true);
	}

	public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize)
	{
		drawInMenu(spriteBatch, location, scaleSize, 1f, 0.9f, StackDrawType.Draw, Color.White, drawShadow: true);
	}

	public abstract int maximumStackSize();

	public void AdjustMenuDrawForRecipes(ref float transparency, ref float scale)
	{
		if (isRecipe.Value)
		{
			transparency = 0.5f;
			scale *= 0.75f;
		}
	}

	public virtual void DrawMenuIcons(SpriteBatch sb, Vector2 location, float scale_size, float transparency, float layer_depth, StackDrawType drawStackNumber, Color color)
	{
		int num = Stack;
		bool flag = ((drawStackNumber == StackDrawType.Draw && maximumStackSize() > 1 && num > 1) || drawStackNumber == StackDrawType.Draw_OneInclusive) && (double)scale_size > 0.3 && num != int.MaxValue;
		if (IsRecipe)
		{
			flag = false;
		}
		if (flag)
		{
			Utility.drawTinyDigits(num, sb, location + new Vector2((float)(64 - Utility.getWidthOfTinyDigitString(num, 3f * scale_size)) + 3f * scale_size, 64f - 18f * scale_size + 1f), 3f * scale_size, Math.Min(1f, layer_depth + 1E-06f), color);
		}
		if (drawStackNumber != StackDrawType.Hide && quality.Value > 0)
		{
			Rectangle value = ((quality.Value < 4) ? new Rectangle(338 + (quality.Value - 1) * 8, 400, 8, 8) : new Rectangle(346, 392, 8, 8));
			Texture2D mouseCursors = Game1.mouseCursors;
			float num2 = ((quality.Value < 4) ? 0f : (((float)Math.Cos((double)Game1.currentGameTime.TotalGameTime.Milliseconds * Math.PI / 512.0) + 1f) * 0.05f));
			sb.Draw(mouseCursors, location + new Vector2(12f, 52f + num2), value, color * transparency, 0f, new Vector2(4f, 4f), 3f * scale_size * (1f + num2), SpriteEffects.None, layer_depth);
		}
		else if (drawStackNumber != StackDrawType.Hide && Category == -102 && Game1.player.stats.Get(itemId.Value) != 0)
		{
			sb.Draw(Game1.mouseCursors_1_6, location + new Vector2(12f, 44f), new Rectangle(244, 271, 9, 11), color * transparency, 0f, new Vector2(4f, 4f), 3f * scale_size * 1f, SpriteEffects.None, layer_depth);
		}
		DrawIconBar(sb, location, scale_size, transparency, layer_depth, drawStackNumber, color);
		if (isRecipe.Value)
		{
			sb.Draw(Game1.objectSpriteSheet, location + new Vector2(16f, 16f), Game1.getSourceRectForStandardTileSheet(Game1.objectSpriteSheet, 451, 16, 16), color, 0f, Vector2.Zero, 3f, SpriteEffects.None, layer_depth + 0.0001f);
		}
	}

	public virtual void DrawIconBar(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color)
	{
	}

	public virtual int addToStack(Item otherStack)
	{
		int num = maximumStackSize();
		if (num != 1)
		{
			stack.Value += otherStack.Stack;
			if (this is Object obj && otherStack is Object obj2 && obj.IsSpawnedObject && !obj2.IsSpawnedObject)
			{
				obj.IsSpawnedObject = false;
			}
			if (stack.Value > num)
			{
				int result = stack.Value - num;
				stack.Value = num;
				return result;
			}
			return 0;
		}
		return otherStack.Stack;
	}

	public abstract string getDescription();

	public abstract bool isPlaceable();

	public virtual int sellToStorePrice(long specificPlayerID = -1L)
	{
		return salePrice() / 2;
	}

	public virtual int salePrice(bool ignoreProfitMargins = false)
	{
		return -1;
	}

	public virtual bool appliesProfitMargins()
	{
		return false;
	}

	public virtual bool CanBeLostOnDeath()
	{
		if (canBeTrashed())
		{
			return !HasContextTag("prevent_loss_on_death");
		}
		return false;
	}

	public virtual bool canBeTrashed()
	{
		if (specialItem)
		{
			return false;
		}
		if (!(this is MeleeWeapon meleeWeapon))
		{
			if (this is FishingRod || this is Pan || this is Slingshot)
			{
				return true;
			}
			return !(this is Tool);
		}
		return !meleeWeapon.isScythe();
	}

	public virtual bool actionWhenPurchased(string shopId)
	{
		if (isLostItem)
		{
			Game1.player.itemsLostLastDeath.Clear();
			isLostItem = false;
			Game1.player.recoveredItem = this;
			Game1.player.mailReceived.Remove("MarlonRecovery");
			Game1.addMailForTomorrow("MarlonRecovery");
			Game1.playSound("newArtifact");
			Game1.exitActiveMenu();
			bool flag = Stack > 1;
			Game1.DrawDialogue(Game1.getCharacterFromName("Marlon"), flag ? "Strings\\StringsFromCSFiles:ItemRecovery_Engaged_Stack" : "Strings\\StringsFromCSFiles:ItemRecovery_Engaged", Lexicon.makePlural(DisplayName, !flag));
			return true;
		}
		return false;
	}

	public bool LearnRecipe(Farmer player = null)
	{
		if (player == null)
		{
			player = Game1.player;
		}
		return ((Category == -7) ? player.cookingRecipes : player.craftingRecipes).TryAdd(BaseName, 0);
	}

	public virtual bool CanBuyItem(Farmer who)
	{
		return Game1.player.couldInventoryAcceptThisItem(this);
	}

	public virtual bool canBeDropped()
	{
		return true;
	}

	public virtual bool canBeShipped()
	{
		return false;
	}

	public virtual void onDetachedFromParent()
	{
		NetFields.Parent = null;
	}

	public virtual void onEquip(Farmer who)
	{
	}

	public virtual void onUnequip(Farmer who)
	{
	}

	public virtual void actionWhenBeingHeld(Farmer who)
	{
	}

	public virtual void actionWhenStopBeingHeld(Farmer who)
	{
	}

	public int getRemainingStackSpace()
	{
		return maximumStackSize() - Stack;
	}

	public virtual Item? ConsumeStack(int amount)
	{
		if (amount == 0)
		{
			return this;
		}
		if (Stack - amount <= 0)
		{
			return null;
		}
		Stack -= amount;
		return this;
	}

	public virtual int healthRecoveredOnConsumption()
	{
		return 0;
	}

	public virtual int staminaRecoveredOnConsumption()
	{
		return 0;
	}

	public virtual string getHoverBoxText(Item hoveredItem)
	{
		return null;
	}

	public virtual bool canBeGivenAsGift()
	{
		return false;
	}

	public virtual void drawAttachments(SpriteBatch b, int x, int y)
	{
	}

	public virtual bool canBePlacedHere(GameLocation l, Vector2 tile, CollisionMask collisionMask = CollisionMask.All, bool showError = false)
	{
		return false;
	}

	public virtual int attachmentSlots()
	{
		return 0;
	}

	public virtual string getCategoryName()
	{
		return Object.GetCategoryDisplayName(Category);
	}

	public virtual Color getCategoryColor()
	{
		return Object.GetCategoryColor(Category);
	}

	public virtual bool canStackWith(ISalable other)
	{
		if (!(other is Item item) || other.GetType() != GetType())
		{
			return false;
		}
		if (this is ColoredObject coloredObject && other is ColoredObject coloredObject2 && !coloredObject.color.Value.Equals(coloredObject2.color.Value))
		{
			return false;
		}
		if (maximumStackSize() <= 1 || other.maximumStackSize() <= 1)
		{
			return false;
		}
		if (this is Object obj && other is Object obj2 && obj2.orderData.Value != obj.orderData.Value)
		{
			return false;
		}
		if (quality.Value != item.quality.Value)
		{
			return false;
		}
		if (QualifiedItemId != item.QualifiedItemId)
		{
			return false;
		}
		if (!Name.Equals(other.Name))
		{
			return false;
		}
		return true;
	}

	public virtual string checkForSpecialItemHoldUpMeessage()
	{
		return null;
	}

	public Item getOne()
	{
		Item oneNew = GetOneNew();
		oneNew.GetOneCopyFrom(this);
		return oneNew;
	}

	protected abstract Item GetOneNew();

	protected virtual void GetOneCopyFrom(Item source)
	{
		ItemId = source.ItemId;
		IsRecipe = source.isRecipe.Value;
		Quality = source.quality.Value;
		Stack = 1;
		HasBeenInInventory = source.HasBeenInInventory;
		SpecialVariable = source.SpecialVariable;
		Dictionary<string, object> dictionary = source.tempData;
		if (dictionary != null && dictionary.Count > 0)
		{
			foreach (KeyValuePair<string, object> tempDatum in source.tempData)
			{
				SetTempData(tempDatum.Key, tempDatum.Value);
			}
		}
		modData.Clear();
		foreach (string key in source.modData.Keys)
		{
			modData[key] = source.modData[key];
		}
	}

	public void CopyFieldsFrom(Item source)
	{
		GetOneCopyFrom(source);
	}

	public ISalable GetSalableInstance()
	{
		return getOne();
	}

	public virtual int CompareTo(object other)
	{
		if (!(other is Item item))
		{
			return 0;
		}
		if (item.Category != Category)
		{
			return item.getCategorySortValue() - getCategorySortValue();
		}
		string text = ((Name == "") ? DisplayName : Name);
		string text2 = ((item.Name == "") ? item.DisplayName : item.Name);
		if (text2 != text)
		{
			if (this is Object obj && item is Object obj2)
			{
				if (obj.HasContextTag("use_reverse_name_for_sorting") || obj is Trinket)
				{
					text = string.Join("", Enumerable.Reverse(text.Split(' ')));
				}
				if (obj2.HasContextTag("use_reverse_name_for_sorting") || obj2 is Trinket)
				{
					text2 = string.Join("", Enumerable.Reverse(text2.Split(' ')));
				}
				return string.Compare(obj.type.Value + text, obj2.type.Value + text2);
			}
			return string.Compare(text, item.Name);
		}
		if (item.Quality != Quality)
		{
			return item.Quality.CompareTo(Quality);
		}
		if (this is ColoredObject coloredObject && item is ColoredObject coloredObject2 && coloredObject.color.Value != coloredObject2.color.Value)
		{
			return coloredObject2.GetHue().CompareTo(coloredObject.GetHue());
		}
		return Stack - item.Stack;
	}

	public int getCategorySortValue()
	{
		if (Category == -100)
		{
			return -94;
		}
		return Category;
	}

	protected virtual int getDescriptionWidth()
	{
		return Math.Max(LocalizedContentManager.CurrentLanguageCode switch
		{
			LocalizedContentManager.LanguageCode.fr => 384, 
			LocalizedContentManager.LanguageCode.tr => 336, 
			_ => 272, 
		}, (int)Game1.dialogueFont.MeasureString((DisplayName == null) ? "" : DisplayName).X);
	}

	public void SetTempData<T>(string key, T value)
	{
		if (tempData == null)
		{
			tempData = new Dictionary<string, object>();
		}
		tempData[key] = value;
	}

	public bool TryGetTempData<T>(string key, out T value)
	{
		if (tempData == null || !tempData.TryGetValue(key, out var value2))
		{
			value = default(T);
			return false;
		}
		if (value2 == null)
		{
			value = default(T);
			return value == null;
		}
		if (value2 is T val)
		{
			value = val;
			return true;
		}
		value = default(T);
		return false;
	}

	public virtual void FixStackSize()
	{
		stack.Value = Utility.Clamp(stack.Value, 1, maximumStackSize());
	}

	public virtual void FixQuality()
	{
		quality.Value = Utility.Clamp(quality.Value, 0, 4);
		if (quality.Value == 3)
		{
			quality.Value = 4;
		}
	}

	public virtual void resetState()
	{
	}

	public virtual bool HasEquipmentBuffs()
	{
		BuffEffects buffEffects = new BuffEffects();
		AddEquipmentEffects(buffEffects);
		return buffEffects.HasAnyValue();
	}

	public virtual void AddEquipmentEffects(BuffEffects effects)
	{
	}

	public virtual IEnumerable<Buff> GetFoodOrDrinkBuffs()
	{
		return LegacyShims.EmptyArray<Buff>();
	}

	public virtual string GenerateLightSourceId(Farmer heldBy)
	{
		return $"{GetType().Name}_{heldBy?.UniqueMultiplayerID ?? (-1)}_{Game1.random.Next()}";
	}

	public virtual bool ForEachItem(ForEachItemDelegate handler, GetForEachItemPathDelegate getPath)
	{
		return true;
	}
}
