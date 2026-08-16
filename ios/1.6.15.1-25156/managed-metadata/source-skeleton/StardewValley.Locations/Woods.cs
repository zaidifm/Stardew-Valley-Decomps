using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Inventories;
using StardewValley.Menus;
using StardewValley.Network;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class Woods : GameLocation
{
	public const int numBaubles = 25;

	private List<Vector2> baubles;

	private List<WeatherDebris> weatherDebris;

	[XmlElement("hasUnlockedStatue")]
	public readonly NetBool hasUnlockedStatue;

	[XmlElement("addedSlimesToday")]
	private readonly NetBool addedSlimesToday;

	[XmlIgnore]
	private readonly NetEvent0 statueAnimationEvent;

	protected Color _ambientLightColor;

	private int statueTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Woods()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Woods(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetLostItemsShop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool localPlayerHasFoundStardrop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void statueAnimation(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doStatueAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _updateWoodsLighting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void HandleViewportSizeChange(xTile.Dimensions.Rectangle old_viewport, xTile.Dimensions.Rectangle new_viewport)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateLostItemsShopTile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateStatueEyes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool skipWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateLocationSpecificWeatherDebris()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IInventory GetLostItemsShopInventory()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static NetMutex GetLostItemShopMutex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLostItemsShopClosed(IClickableMenu shopMenu)
	{
	}
}
