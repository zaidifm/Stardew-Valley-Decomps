using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class Desert : GameLocation
{
	public const int busDefaultXTile = 17;

	public const int busDefaultYTile = 24;

	private TemporaryAnimatedSprite busDoor;

	private Vector2 busPosition;

	private Vector2 busMotion;

	public bool drivingOff;

	public bool drivingBack;

	public bool leaving;

	private int chimneyTimer;

	internal Microsoft.Xna.Framework.Rectangle desertMerchantBounds;

	public static bool warpedToDesert;

	private Microsoft.Xna.Framework.Rectangle busSource;

	private Microsoft.Xna.Framework.Rectangle pamSource;

	private Microsoft.Xna.Framework.Rectangle transparentWindowSource;

	private Vector2 pamOffset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Desert()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Desert(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDesertTrader()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCamel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShowCamelAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void playerReachedBusDoor(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogue(Response answer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsTravelingDesertMerchantHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteUpdate(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void lightMerchantLamps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void busDriveOff()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void busDriveBack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void busStartMovingOff(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IgnoreTouchActions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTouchAction(string[] action, Vector2 playerStandingPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doorOpenAfterReturn(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void busLeftToValley()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isTilePlaceable(Vector2 v, bool itemIsPassable = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldHideCharacters()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}
}
