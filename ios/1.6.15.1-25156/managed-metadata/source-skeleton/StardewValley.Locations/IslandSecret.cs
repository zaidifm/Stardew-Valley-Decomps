using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.BellsAndWhistles;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class IslandSecret : IslandLocation
{
	[XmlIgnore]
	public List<SuspensionBridge> suspensionBridges;

	[XmlElement("addedSlimesToday")]
	private readonly NetBool addedSlimesToday;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandSecret()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandSecret(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
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
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaReachedShrine(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaGrabBanana(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaEatBanana(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaAfterEat(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaSpawnNut(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaReturn(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetBuriedNutLocations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsLocationSpecificPlacementRestriction(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
