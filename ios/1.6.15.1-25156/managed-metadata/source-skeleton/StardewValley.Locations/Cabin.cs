using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using StardewValley.Inventories;
using StardewValley.Network;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class Cabin : FarmHouse
{
	[XmlElement("farmhand")]
	public Farmer obsolete_farmhand;

	[XmlElement("farmhandReference")]
	public readonly NetFarmerRef farmhandReference;

	[XmlIgnore]
	public readonly NetMutex inventoryMutex;

	[XmlIgnore]
	public override Farmer owner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Cabin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Cabin(string map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateFarmhand()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteFarmhand()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanAssignTo(Farmer farmhand)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AssignFarmhand(Farmer farmhand)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool skipWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IInventory getInventory()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void openFarmhandInventory()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isInventoryOpen()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void grabItemFromPlayerInventory(Item item, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void grabItemFromFarmhandInventory(Item item, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWarps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Item> demolish()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Point getPorchStandingSpot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
