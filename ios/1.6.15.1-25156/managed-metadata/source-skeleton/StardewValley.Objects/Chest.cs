using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Delegates;
using StardewValley.Inventories;
using StardewValley.Network;
using StardewValley.Network.ChestHit;

namespace StardewValley.Objects;

public class Chest : Object
{
	public enum SpecialChestTypes
	{
		None,
		MiniShippingBin,
		JunimoChest,
		AutoLoader,
		Enricher,
		Mill,
		BigChest
	}

	public const int capacity = 36;

	internal ChestHitTimer hitTimerInstance;

	[XmlElement("currentLidFrame")]
	public readonly NetInt startingLidFrame;

	public readonly NetInt lidFrameCount;

	private int currentLidFrame;

	[XmlElement("frameCounter")]
	public readonly NetInt frameCounter;

	[XmlElement("items")]
	public NetRef<Inventory> netItems;

	public readonly NetLongDictionary<Inventory, NetRef<Inventory>> separateWalletItems;

	[XmlElement("tint")]
	public readonly NetColor tint;

	[XmlElement("playerChoiceColor")]
	public readonly NetColor playerChoiceColor;

	[XmlElement("playerChest")]
	public readonly NetBool playerChest;

	[XmlElement("fridge")]
	public readonly NetBool fridge;

	[XmlElement("giftbox")]
	public readonly NetBool giftbox;

	[XmlElement("giftboxIndex")]
	public readonly NetInt giftboxIndex;

	public readonly NetBool giftboxIsStarterGift;

	[XmlElement("spriteIndexOverride")]
	public readonly NetInt bigCraftableSpriteIndex;

	[XmlElement("dropContents")]
	public readonly NetBool dropContents;

	[XmlIgnore]
	public string mailToAddOnItemDump;

	[XmlElement("synchronized")]
	public readonly NetBool synchronized;

	[XmlIgnore]
	public int _shippingBinFrameCounter;

	[XmlIgnore]
	public bool _farmerNearby;

	[XmlIgnore]
	public NetVector2 kickStartTile;

	[XmlIgnore]
	public Vector2? localKickStartTile;

	[XmlIgnore]
	public float kickProgress;

	[XmlIgnore]
	public readonly NetEvent0 openChestEvent;

	[XmlElement("specialChestType")]
	public readonly NetEnum<SpecialChestTypes> specialChestType;

	public readonly NetString globalInventoryId;

	[XmlIgnore]
	public readonly NetMutex mutex;

	private ChestHitTimer HitTimerInstance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public SpecialChestTypes SpecialChestType
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
	public string GlobalInventoryId
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
	public Color Tint
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
	public Inventory Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chest(bool playerChest, Vector2 tileLocation, string itemId = "130")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chest(bool playerChest, string itemId = "130")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chest(Vector2 location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chest(string itemId, Vector2 tile_location, int starting_lid_frame, int lid_frame_count)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chest(List<Item> items, Vector2 location, bool giftbox = false, int giftboxIndex = 0, bool giftboxIsStarterGift = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createSlotsForCapacity(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int itemsCountExcludingNulls()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetLidFrame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fixLidFrame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getLastLidFrame()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HandleChestHit(ChestHitArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryMoveToSafePosition(int? preferDirection = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpecialChestType()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void destroyAndDropContents(Vector2 pointToDropAt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void dumpContents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetMutex GetMutex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenMiniShippingMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performOpenChest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void grabItemFromChest(Item item, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Item addItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetActualCapacity()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CheckAutoLoad(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShowMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void grabItemFromInventory(Item item, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IInventory GetItemsForPlayer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IInventory GetItemsForPlayer(long id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isEmpty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void clearNulls()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateFarmerNearby(bool animate = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void actionOnPlayerEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetBigCraftableSpriteIndex(int sprite_index, int starting_lid_frame = -1, int lid_frame_count = 3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f, bool local = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ForEachItem(ForEachItemDelegate handler, GetForEachItemPathDelegate getPath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
