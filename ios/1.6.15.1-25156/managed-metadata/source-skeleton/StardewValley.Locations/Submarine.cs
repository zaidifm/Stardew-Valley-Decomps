using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class Submarine : GameLocation
{
	public const float submergeTime = 20000f;

	public const string MainTileSheetId = "submarine tiles";

	[XmlElement("submerged")]
	public readonly NetBool submerged;

	[XmlElement("ascending")]
	public readonly NetBool ascending;

	private Texture2D submarineSprites;

	private float curtainMovement;

	private float curtainOpenPercent;

	private float submergeTimer;

	private Color ambientLightTargetColor;

	private bool hasLitSubmergeLight;

	private bool hasLitAscendLight;

	private bool doneUntilReset;

	private bool localAscending;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Submarine()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Submarine(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void changeSubmergeLight(bool red, bool clear = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canFishHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteUpdate(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}
}
