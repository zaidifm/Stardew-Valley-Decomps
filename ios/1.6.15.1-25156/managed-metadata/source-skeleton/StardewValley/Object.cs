using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Audio;
using StardewValley.Buffs;
using StardewValley.Delegates;
using StardewValley.GameData.Machines;
using StardewValley.GameData.Objects;
using StardewValley.Inventories;
using StardewValley.Objects;
using StardewValley.Objects.Trinkets;
using xTile.Dimensions;

namespace StardewValley;

[XmlInclude(typeof(Workbench))]
[XmlInclude(typeof(WoodChipper))]
[XmlInclude(typeof(Wallpaper))]
[XmlInclude(typeof(Trinket))]
[XmlInclude(typeof(Sign))]
[XmlInclude(typeof(Phone))]
[XmlInclude(typeof(MiniJukebox))]
[XmlInclude(typeof(Mannequin))]
[XmlInclude(typeof(ItemPedestal))]
[XmlInclude(typeof(Torch))]
[XmlInclude(typeof(Furniture))]
[XmlInclude(typeof(Fence))]
[XmlInclude(typeof(CrabPot))]
[XmlInclude(typeof(ColoredObject))]
[XmlInclude(typeof(Chest))]
[XmlInclude(typeof(Cask))]
[XmlInclude(typeof(BreakableContainer))]
[XmlInclude(typeof(IndoorPot))]
public class Object : Item
{
	public enum PreserveType
	{
		Wine,
		Jelly,
		Pickle,
		Juice,
		Roe,
		AgedRoe,
		Honey,
		Bait,
		DriedFruit,
		DriedMushroom,
		SmokedFish
	}

	[CompilerGenerated]
	private sealed class <GetFoodOrDrinkBuffs>d__357 : IEnumerable<Buff>, IEnumerable, IEnumerator<Buff>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private Buff <>2__current;

		private int <>l__initialThreadId;

		public Object <>4__this;

		private IEnumerator<Buff> <>7__wrap1;

		Buff IEnumerator<Buff>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public <GetFoodOrDrinkBuffs>d__357(int <>1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void <>m__Finally1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void <>m__Finally2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<Buff> IEnumerable<Buff>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[CompilerGenerated]
	private sealed class <TryCreateBuffsFromData>d__358 : IEnumerable<Buff>, IEnumerable, IEnumerator<Buff>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private Buff <>2__current;

		private int <>l__initialThreadId;

		private ObjectData obj;

		public ObjectData <>3__obj;

		private Action<BuffEffects> adjustEffects;

		public Action<BuffEffects> <>3__adjustEffects;

		private float durationMultiplier;

		public float <>3__durationMultiplier;

		private string name;

		public string <>3__name;

		private string displayName;

		public string <>3__displayName;

		private List<ObjectBuffData>.Enumerator <>7__wrap1;

		Buff IEnumerator<Buff>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public <TryCreateBuffsFromData>d__358(int <>1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void <>m__Finally1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<Buff> IEnumerable<Buff>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public const int wood = 388;

	public const int stone = 390;

	public const int copper = 378;

	public const int iron = 380;

	public const int coal = 382;

	public const int gold = 384;

	public const int iridium = 386;

	public const string artifactSpotID = "590";

	public const string hayID = "178";

	public const string iridiumBarID = "337";

	public const string woodID = "388";

	public const string stoneID = "390";

	public const string copperID = "378";

	public const string ironID = "380";

	public const string coalID = "382";

	public const string goldID = "384";

	public const string iridiumID = "386";

	public const string amethystClusterID = "66";

	public const string aquamarineID = "62";

	public const string bobberID = "133";

	public const string caveCarrotID = "78";

	public const string diamondID = "72";

	public const string emeraldID = "60";

	public const string prismaticShardID = "74";

	public const string quartzID = "80";

	public const string rubyID = "64";

	public const string sapphireID = "70";

	public const string stardropID = "434";

	public const string topazID = "68";

	public const string artifactSpotQID = "(O)590";

	public const string hayQID = "(O)178";

	public const string copperBarQID = "(O)334";

	public const string ironBarQID = "(O)335";

	public const string goldBarQID = "(O)336";

	public const string iridiumBarQID = "(O)337";

	public const string woodQID = "(O)388";

	public const string stoneQID = "(O)390";

	public const string copperQID = "(O)378";

	public const string ironQID = "(O)380";

	public const string coalQID = "(O)382";

	public const string goldQID = "(O)384";

	public const string iridiumQID = "(O)386";

	public const string amethystClusterQID = "(O)66";

	public const string aquamarineQID = "(O)62";

	public const string caveCarrotQID = "(O)78";

	public const string diamondQID = "(O)72";

	public const string emeraldQID = "(O)60";

	public const string prismaticShardQID = "(O)74";

	public const string rubyQID = "(O)64";

	public const string sapphireQID = "(O)70";

	public const string stardropQID = "(O)434";

	public const string topazQID = "(O)68";

	public const int inedible = -300;

	public const int GreensCategory = -81;

	public const int GemCategory = -2;

	public const int VegetableCategory = -75;

	public const int FishCategory = -4;

	public const int EggCategory = -5;

	public const int MilkCategory = -6;

	public const int CookingCategory = -7;

	public const int CraftingCategory = -8;

	public const int BigCraftableCategory = -9;

	public const int FruitsCategory = -79;

	public const int SeedsCategory = -74;

	public const int mineralsCategory = -12;

	public const int flowersCategory = -80;

	public const int meatCategory = -14;

	public const int metalResources = -15;

	public const int buildingResources = -16;

	public const int sellAtPierres = -17;

	public const int sellAtPierresAndMarnies = -18;

	public const int fertilizerCategory = -19;

	public const int junkCategory = -20;

	public const int baitCategory = -21;

	public const int tackleCategory = -22;

	public const int sellAtFishShopCategory = -23;

	public const int furnitureCategory = -24;

	public const int ingredientsCategory = -25;

	public const int artisanGoodsCategory = -26;

	public const int syrupCategory = -27;

	public const int monsterLootCategory = -28;

	public const int equipmentCategory = -29;

	public const int clothingCategorySortValue = -94;

	public const int hatCategory = -95;

	public const int ringCategory = -96;

	public const int weaponCategory = -98;

	public const int bootsCategory = -97;

	public const int toolCategory = -99;

	public const int clothingCategory = -100;

	public const int trinketCategory = -101;

	public const int booksCategory = -102;

	public const int skillBooksCategory = -103;

	public const int litterCategory = -999;

	public const int WildHorseradishIndex = 16;

	public const int LeekIndex = 20;

	public const int DandelionIndex = 22;

	public const int HandCursorIndex = 26;

	public const int WaterAnimationIndex = 28;

	public const int LumberIndex = 30;

	public const int mineStoneGrey1Index = 32;

	public const int mineStoneBlue1Index = 34;

	public const int mineStoneBlue2Index = 36;

	public const int mineStoneGrey2Index = 38;

	public const int mineStoneBrown1Index = 40;

	public const int mineStoneBrown2Index = 42;

	public const int mineStonePurpleIndex = 44;

	public const int mineStoneMysticIndex = 46;

	public const int mineStoneSnow1 = 48;

	public const int mineStoneSnow3 = 52;

	public const int mineStoneRed1Index = 56;

	public const int mineStoneRed2Index = 58;

	public const int emeraldIndex = 60;

	public const int aquamarineIndex = 62;

	public const int rubyIndex = 64;

	public const int amethystClusterIndex = 66;

	public const int topazIndex = 68;

	public const int sapphireIndex = 70;

	public const int diamondIndex = 72;

	public const int prismaticShardIndex = 74;

	public const int stardrop = 434;

	public const string WildHoneyPreservedId = "-1";

	public const int lowQuality = 0;

	public const int medQuality = 1;

	public const int highQuality = 2;

	public const int bestQuality = 4;

	public const int fragility_Removable = 0;

	public const int fragility_Delicate = 1;

	public const int fragility_Indestructable = 2;

	public const int spriteSheetTileSize = 16;

	public const float wobbleAmountWhenWorking = 10f;

	public const string RecipeNameSuffix = " Recipe";

	[XmlElement("tileLocation")]
	public readonly NetVector2 tileLocation;

	[XmlElement("owner")]
	public readonly NetLong owner;

	[XmlElement("type")]
	public readonly NetString type;

	[XmlElement("canBeSetDown")]
	public readonly NetBool canBeSetDown;

	[XmlElement("canBeGrabbed")]
	public readonly NetBool canBeGrabbed;

	[XmlElement("isSpawnedObject")]
	public readonly NetBool isSpawnedObject;

	[XmlElement("questItem")]
	public readonly NetBool questItem;

	[XmlElement("questId")]
	public readonly NetString questId;

	[XmlElement("isOn")]
	public readonly NetBool isOn;

	[XmlElement("fragility")]
	public readonly NetInt fragility;

	[XmlElement("price")]
	public readonly NetInt price;

	[XmlElement("edibility")]
	public readonly NetInt edibility;

	[XmlElement("bigCraftable")]
	public readonly NetBool bigCraftable;

	[XmlElement("setOutdoors")]
	public readonly NetBool setOutdoors;

	[XmlElement("setIndoors")]
	public readonly NetBool setIndoors;

	[XmlElement("readyForHarvest")]
	public readonly NetBool readyForHarvest;

	[XmlElement("showNextIndex")]
	public readonly NetBool showNextIndex;

	[XmlElement("flipped")]
	public readonly NetBool flipped;

	[XmlElement("isLamp")]
	public readonly NetBool isLamp;

	[XmlElement("heldObject")]
	public readonly NetRef<Object> heldObject;

	[XmlElement("lastOutputRuleId")]
	public readonly NetString lastOutputRuleId;

	[XmlElement("lastInputItem")]
	public readonly NetRef<Item> lastInputItem;

	[XmlElement("minutesUntilReady")]
	public readonly NetIntDelta minutesUntilReady;

	[XmlElement("boundingBox")]
	public readonly NetRectangle boundingBox;

	public Vector2 scale;

	[XmlElement("uses")]
	public readonly NetInt uses;

	[XmlIgnore]
	private readonly NetRef<LightSource> netLightSource;

	[XmlIgnore]
	public readonly NetString netDisplayNameFormat;

	[XmlIgnore]
	public bool isTemporarilyInvisible;

	[XmlIgnore]
	protected NetBool _destroyOvernight;

	[XmlIgnore]
	public bool shouldShowSign;

	[XmlIgnore]
	public Func<Buff> customBuff;

	[XmlElement("signText")]
	public readonly NetString signText;

	protected MachineEffects _machineAnimation;

	protected bool _machineAnimationLoop;

	protected int _machineAnimationIndex;

	protected int _machineAnimationFrame;

	protected int _machineAnimationInterval;

	[XmlElement("orderData")]
	public readonly NetString orderData;

	[XmlIgnore]
	public static IInventory autoLoadFrom;

	[XmlIgnore]
	public int shakeTimer;

	[XmlIgnore]
	public int lastNoteBlockSoundTime;

	[XmlIgnore]
	public ICue internalSound;

	[XmlElement("preserve")]
	public readonly NetNullableEnum<PreserveType> preserve;

	[XmlElement("preservedParentSheetIndex")]
	public readonly NetString preservedParentSheetIndex;

	[XmlElement("honeyType")]
	public string obsolete_honeyType;

	[XmlIgnore]
	public string displayName;

	protected bool _hasHeldObject;

	protected bool _hasLightSource;

	public static int CurrentParsedItemCount;

	protected int health;

	[XmlIgnore]
	public bool hovering;

	private Dictionary<Vector2, bool> _redGreenSquareDict;

	private int _lastQuantity;

	public bool destroyOvernight
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
	public LightSource lightSource
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
	public virtual GameLocation Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlIgnore]
	public virtual Vector2 TileLocation
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
	public string name
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

	[XmlElement("displayNameFormat")]
	public string displayNameFormat
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

	[XmlIgnore]
	public override string Name
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

	public override string BaseName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public string Type
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
	public bool CanBeSetDown
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
	public bool CanBeGrabbed
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
	public bool IsOn
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
	public bool IsSpawnedObject
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
	public bool Flipped
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
	public int Price
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
	public int Edibility
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
	public int Fragility
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
	public Vector2 Scale
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
	public int MinutesUntilReady
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
	public string SignText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object(Vector2 tileLocation, string itemId, bool isRecipe = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Object(string itemId, int initialStack, bool isRecipe = false, int price = -1, int quality = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("This is used for specialized game behavior and only supports vanilla objects. New code should place a new object instance instead.")]
	public virtual void SetIdAndSprite(int spriteIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RecalculateBoundingBox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsHeldOverHead()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _PopulateContextTags(HashSet<string> tags)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string loadDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetObjectDisplayName(string itemId, PreserveType? preserveType, string preservedId, string displayNameFormat = null, string defaultBaseName = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 getLocalPosition(xTile.Dimensions.Rectangle viewport)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Microsoft.Xna.Framework.Rectangle getSourceRectForBigCraftable(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Microsoft.Xna.Framework.Rectangle getSourceRectForBigCraftable(Texture2D texture, int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool performToolAction(Tool t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void cutWeed(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isAnimalProduct()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool onExplosion(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canBeShipped()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplySprinkler(Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplySprinklerAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<Vector2> GetSprinklerTiles()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsInSprinklerRangeBroadphase(Vector2 target)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DayUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void rot()
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
	public static void ConsumeInventoryItem(Farmer who, Item drop_in, int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TryApplyFairyDust(bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item OutputSolarPanel(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item OutputStatueOfEndlessFortune(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item OutputDeconstructor(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item OutputAnvil(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item OutputGeodeCrusher(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item OutputIncubator(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item OutputSeedMaker(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item OutputMushroomLog(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ParseItemCount(string[] query, out string replacement, Random random, Farmer player)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PlaceInMachine(MachineData machineData, Item inputItem, bool probe, Farmer who, bool showMessages = true, bool playSounds = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void playCustomMachineLoadEffects()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OutputMachine(MachineData machine, MachineOutputRule outputRule, Item inputItem, Farmer who, GameLocation location, bool probe, bool heldObjectOnly = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool PlayMachineEffect(MachineEffects effect, bool playSounds = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void actionOnPlayerEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canBeTrashed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isForage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void initializeLightSource(Vector2 tileLocation, bool mineShaft = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performRemoveAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void dropItem(GameLocation location, Vector2 origin, Vector2 destination)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isPassable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void reloadSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Microsoft.Xna.Framework.Rectangle GetBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Microsoft.Xna.Framework.Rectangle GetBoundingBoxAt(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canBeGivenAsGift()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool performDropDownAction(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void totemWarp(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void totemWarpForReal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MonsterMusk(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ModifyItemBuffs(BuffEffects effects)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void treasureTotem(Farmer who, GameLocation gameLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rainTotem(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readBook(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool performUseAction(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Color getCategoryColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getCategoryName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetCategoryDisplayName(int category)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color GetCategoryColor(int category)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isActionable(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getHealth()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setHealth(int health)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void grabItemFromAutoGrabber(Item item, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HighlightFertilizers(Item i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int healthRecoveredOnConsumption()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int staminaRecoveredOnConsumption()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnSewingMachine(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnAutoGrabber(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnFarmComputer(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ShowFarmComputerReport(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnMiniObelisk(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnPrairieKingArcadeSystem(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnJunimoKartArcadeSystem(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnStaircase(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnSlimeBall(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnBlessedStatue(Farmer who, GameLocation location, bool justCheckingForActivitiy = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnHousePlant(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnFluteBlock(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnDrumBlock(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CheckForActionOnSprinkler(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CheckForActionOnScarecrow(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CheckForActionOnSingingStone(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CheckForActionOnTextSign(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CheckForActionOnFeedHopper(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CheckForActionOnMachine(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playNearbySoundLocal(string audioName, int? pitch = null, SoundContext context = SoundContext.Default)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playNearbySoundAll(string audioName, int? pitch = null, SoundContext context = SoundContext.Default)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsScarecrow()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetRadiusForScarecrow()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<bool> AttemptAutoLoad(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool AttemptAutoLoad(IInventory inventory, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string getFluteBlockSoundFromHeldObject(Object o)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void farmerAdjacentAction(Farmer who, bool diagonal = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void addWorkingAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onReadyForHarvest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool minutesElapsed(int minutes)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldTimePassForMachine()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string checkForSpecialItemHoldUpMeessage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool countsForShippedCollection()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isPotentialBasicShipped(string itemId, int category, string objectType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<GetFoodOrDrinkBuffs>d__357))]
	public override IEnumerable<Buff> GetFoodOrDrinkBuffs()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<TryCreateBuffsFromData>d__358))]
	public static IEnumerable<Buff> TryCreateBuffsFromData(ObjectData obj, string name, string displayName, float durationMultiplier = 1f, Action<BuffEffects> adjustEffects = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldWobble()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 getScale()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawWhenHeld(SpriteBatch spriteBatch, Vector2 objectPosition, Farmer f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawPlacementBounds(SpriteBatch spriteBatch, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CrabPot FetchCrabPot(GameLocation gameLocation, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool itemCanBePlaced(GameLocation gameLocation, Object svObject, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenuWithStackNumber(SpriteBatch spriteBatch, Vector2 location, float scaleSize, int stackNumber = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawInMenuWithColour(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow = true, int stackNumber = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override float getScaleSizeForMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawShadow(SpriteBatch spriteBatch, Vector2 position, Color color, float layerDepth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DrawIconBar(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawAsProp(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawAboveFrontLayer(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch spriteBatch, int xNonTile, int yNonTile, float layerDepth, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int maximumStackSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void hoverAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool clicked(Farmer who)
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
	public override bool canBePlacedHere(GameLocation l, Vector2 tile, CollisionMask collisionMask = CollisionMask.All, bool showError = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPlaceable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsConsideredReadyMachineForComputer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MachineData GetMachineData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isSapling()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTeaSapling()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsFruitTreeSapling()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsWildTreeSapling()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsFloorPathItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsFloorPathItem(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsFenceItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isWildTreeSeed(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool canPlaceWildTreeSeed(GameLocation location, Vector2 tile, out string deniedMessage)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsSprinkler()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBreakableStone()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTextSign()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTwig()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isDebrisOrForage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsWeeds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTapper()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsBar()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetPreservedItemId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetPreservedItemId(PreserveType? preserveType, string preservedId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetModifiedRadiusForSprinkler()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetBaseRadiusForSprinkler()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool placementAction(GameLocation location, int x, int y, Farmer who = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool actionWhenPurchased(string shopId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canBePlacedInWater()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool needsToBeDonated()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GenerateLightSourceId(Vector2 position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int sellToStorePrice(long specificPlayerID = -1L)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int salePrice(bool ignoreProfitMargins = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool appliesProfitMargins()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual float getPriceAfterMultipliers(float startPrice, long specificPlayerID = -1L)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ForEachItem(ForEachItemDelegate handler, GetForEachItemPathDelegate getPath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearRedGreenSquareDict()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DrawRedGreenRectangleForPlacing(SpriteBatch spriteBatch, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
