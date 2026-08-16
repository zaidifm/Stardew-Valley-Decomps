using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class Mountain : GameLocation
{
	public const int daysBeforeLandslide = 31;

	private TemporaryAnimatedSprite minecartSteam;

	private bool bridgeRestored;

	[XmlIgnore]
	public bool treehouseBuilt;

	[XmlIgnore]
	public bool treehouseDoorDirty;

	private readonly NetBool oreBoulderPresent;

	private readonly NetBool railroadAreaBlocked;

	private readonly NetBool landslide;

	private Microsoft.Xna.Framework.Rectangle landSlideRect;

	private Microsoft.Xna.Framework.Rectangle railroadBlockRect;

	private int oldTime;

	private Microsoft.Xna.Framework.Rectangle boulderSourceRect;

	private Microsoft.Xna.Framework.Rectangle raildroadBlocksourceRect;

	private Microsoft.Xna.Framework.Rectangle landSlideSourceRect;

	private Vector2 boulderPosition;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mountain()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mountain(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyTreehouseIfNecessary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void restoreBridge()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
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
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void quarryDayUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool isTileOpenForQuarryStone(int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isTilePlaceable(Vector2 tileLocation, bool itemIsPassable = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}
}
