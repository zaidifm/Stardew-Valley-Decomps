using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Locations;

public class ShopLocation : GameLocation
{
	public const int maxItemsToSellFromPlayer = 11;

	public readonly NetObjectList<Item> itemsFromPlayerToSell;

	public readonly NetObjectList<Item> itemsToStartSellingTomorrow;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopLocation(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Dialogue getPurchasedItemDialogueForNPC(Object i, NPC n)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}
}
