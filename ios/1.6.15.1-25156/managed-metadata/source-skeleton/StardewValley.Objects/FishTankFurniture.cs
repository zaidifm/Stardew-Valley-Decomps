using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Objects;

public class FishTankFurniture : StorageFurniture
{
	public enum FishTankCategories
	{
		None,
		Swim,
		Ground,
		Decoration
	}

	public const int TANK_DEPTH = 10;

	public const int FLOOR_DECORATION_OFFSET = 4;

	public const int TANK_SORT_REGION = 20;

	[XmlIgnore]
	public List<Vector4> bubbles;

	[XmlIgnore]
	public List<TankFish> tankFish;

	[XmlIgnore]
	public NetEvent0 refreshFishEvent;

	[XmlIgnore]
	public bool fishDirty;

	[XmlIgnore]
	private Texture2D _aquariumTexture;

	[XmlIgnore]
	public List<KeyValuePair<Rectangle, Vector2>?> floorDecorations;

	[XmlIgnore]
	public List<Vector2> decorationSlots;

	[XmlIgnore]
	public List<int> floorDecorationIndices;

	public NetInt generationSeed;

	[XmlIgnore]
	public Item localDepositedItem;

	[XmlIgnore]
	protected int _currentDecorationIndex;

	protected Dictionary<Item, TankFish> _fishLookup;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishTankFurniture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishTankFurniture(string itemId, Vector2 tile, int initialRotations)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishTankFurniture(string itemId, Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void actionOnPlayerEntryOrPlacement(GameLocation environment, bool dropDown)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetFish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Texture2D GetAquariumTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetCapacityForCategory(FishTankCategories category)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishTankCategories GetCategoryFromItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasRoomForThisItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetShopMenuContext()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ShowMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanBeDeposited(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, string> GetAquariumData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool onDresserItemWithdrawn(ISalable salable, Farmer who, int countTaken, ItemStockInformation stock)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateFish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateDecorAndFish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddFloorDecoration(Rectangle source_rect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _AdvanceDecorationIndex()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnMenuClose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetFishSortRegion()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetGlassDrawLayer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetBaseDrawLayer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetItemCount(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle GetTankBounds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
