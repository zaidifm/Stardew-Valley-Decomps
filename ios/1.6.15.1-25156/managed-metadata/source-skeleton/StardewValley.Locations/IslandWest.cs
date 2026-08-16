using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.BellsAndWhistles;
using StardewValley.Monsters;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class IslandWest : IslandLocation
{
	[XmlElement("addedSlimesToday")]
	private readonly NetBool addedSlimesToday;

	[XmlElement("sandDuggy")]
	public NetRef<SandDuggy> sandDuggy;

	[XmlElement("farmhouseRestored")]
	public readonly NetBool farmhouseRestored;

	[XmlElement("farmhouseMailbox")]
	public readonly NetBool farmhouseMailbox;

	[XmlElement("farmObelisk")]
	public readonly NetBool farmObelisk;

	public Point shippingBinPosition;

	private TemporaryAnimatedSprite shippingBinLid;

	private Microsoft.Xna.Framework.Rectangle shippingBinLidOpenArea;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetBuriedNutLocations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanPlantSeedsHere(string itemId, int tileX, int tileY, bool isGardenPot, out string deniedMessage)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanPlantTreesHere(string itemId, int tileX, int tileY, out string deniedMessage)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandWest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t, int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Vector2> GetAdditionalWalnutBushes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandWest(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool leftClick(int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showShipment(Item item, bool playThrowSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsQiWalnutRoomDoorUnlocked(out int actualFoundWalnutsCount)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isActionableTile(int xTile, int yTile, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyFarmObeliskBuild()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyFarmHouseRestore()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void monsterDrop(Monster monster, int x, int y, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void spawnObjects()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool breakStone(string stoneId, int x, int y, Farmer who, Random r)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override double GetDirtDecayChance(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void openShippingBinLid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void closeShippingBinLid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateShippingBinLid(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool isShippingBinLidOpen(bool requiredToBeFullyOpen = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
