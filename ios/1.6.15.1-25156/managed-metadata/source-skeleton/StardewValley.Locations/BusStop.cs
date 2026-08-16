using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class BusStop : GameLocation
{
	public const int busDefaultXTile = 21;

	public const int busDefaultYTile = 6;

	private TemporaryAnimatedSprite minecartSteam;

	private TemporaryAnimatedSprite busDoor;

	[XmlIgnore]
	public Vector2 busPosition;

	[XmlIgnore]
	public Vector2 busMotion;

	[XmlIgnore]
	public bool drivingOff;

	[XmlIgnore]
	public bool drivingBack;

	[XmlIgnore]
	public bool leaving;

	private int forceWarpTimer;

	private Microsoft.Xna.Framework.Rectangle busSource;

	private Microsoft.Xna.Framework.Rectangle pamSource;

	private Vector2 pamOffset;

	[XmlIgnore]
	public int TicketPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BusStop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BusStop(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IgnoreTouchActions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void playerReachedBusDoor(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
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
	private void doorOpenAfterReturn(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void busLeftToDesert()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldHideCharacters()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}
}
