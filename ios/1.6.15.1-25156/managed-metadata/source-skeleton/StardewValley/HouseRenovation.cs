using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.ItemTypeDefinitions;

namespace StardewValley;

public class HouseRenovation : ISalable, IHaveItemTypeId
{
	public enum AnimationType
	{
		Build,
		Destroy
	}

	protected string _displayName;

	protected string _name;

	protected string _description;

	public AnimationType animationType;

	public List<List<Rectangle>> renovationBounds;

	public string placementText;

	public GameLocation location;

	public bool requireClearance;

	public Action<HouseRenovation, int> onRenovation;

	public Func<HouseRenovation, int, bool> validate;

	public int Price;

	public string RoomId;

	public string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string QualifiedItemId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

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

	public int Stack
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldDrawIcon()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int maximumStackSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int addToStack(Item stack)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int sellToStorePrice(long specificPlayerID = -1L)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int salePrice(bool ignoreProfitMargins = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool appliesProfitMargins()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool actionWhenPurchased(string shopId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canStackWith(ISalable other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanBuyItem(Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInfiniteStock()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ISalable GetSalableInstance()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FixStackSize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FixQuality()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetItemTypeId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowRenovationMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<ISalable> GetAvailableRenovations()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool EnsureNoObstructions(HouseRenovation renovation, int selected_index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void BuildCrib(HouseRenovation renovation, int selected_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveCrib(HouseRenovation renovation, int selected_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpenBedroom(HouseRenovation renovation, int selected_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CloseBedroom(HouseRenovation renovation, int selected_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpenSouthernRoom(HouseRenovation renovation, int selected_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CloseSouthernRoom(HouseRenovation renovation, int selected_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpenCornernRoom(HouseRenovation renovation, int selected_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CloseCornerRoom(HouseRenovation renovation, int selected_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool OnPurchaseRenovation(ISalable salable, Farmer who, int countTaken, ItemStockInformation stock)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddRenovationBound(Rectangle bound)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddRenovationBound(List<Rectangle> bounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HouseRenovation()
	{
	}
}
