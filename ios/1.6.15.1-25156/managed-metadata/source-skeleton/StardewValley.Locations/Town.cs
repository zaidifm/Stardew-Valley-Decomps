using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class Town : GameLocation
{
	private TemporaryAnimatedSprite minecartSteam;

	private bool ccRefurbished;

	private bool ccJoja;

	private bool playerCheckedBoard;

	private bool isShowingDestroyedJoja;

	private bool isShowingUpgradedPamHouse;

	private bool isShowingSpecialOrdersBoard;

	private bool showBookseller;

	private LocalizedContentManager mapLoader;

	[XmlElement("daysUntilCommunityUpgrade")]
	public readonly NetInt daysUntilCommunityUpgrade;

	private Vector2 clockCenter;

	private Vector2 ccFacadePosition;

	private Vector2 ccFacadePositionBottom;

	public static Microsoft.Xna.Framework.Rectangle minuteHandSource;

	public static Microsoft.Xna.Framework.Rectangle hourHandSource;

	public static Microsoft.Xna.Framework.Rectangle clockNub;

	public static Microsoft.Xna.Framework.Rectangle jojaFacadeTop;

	public static Microsoft.Xna.Framework.Rectangle jojaFacadeBottom;

	public static Microsoft.Xna.Framework.Rectangle jojaFacadeWinterOverlay;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Town()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Town(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override LocalizedContentManager getMapLoader()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateMapSeats()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteUpdate(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkedBoard()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addClintMachineGraphics()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool removeObjectAtTileWithName(int x, int y, string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanPlantTreesHere(string itemId, int tileX, int tileY, out string deniedMessage)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void crackOpenAbandonedJojaMartDoor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void refurbishCommunityCenter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void showDestroyedJoja()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isTileFishable(int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showImprovedPamHouse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point GetTheaterTileOffset()
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
	private void showTownCommunityUpgradeShortcuts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initiateMarnieLewisBush()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void marnie_landed(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initiateMagnifyingGlassGet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mgThief_landed(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mgThief_speech(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mgThief_afterSpeech()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mgThief_afterGlass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mg_disappear(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}
}
