using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Characters;

public class Junimo : NPC
{
	private readonly NetFloat alpha;

	private readonly NetFloat alphaChange;

	public readonly NetInt whichArea;

	public readonly NetBool friendly;

	public readonly NetBool holdingStar;

	public readonly NetBool holdingBundle;

	public readonly NetBool temporaryJunimo;

	public readonly NetBool stayPut;

	private readonly NetVector2 motion;

	private new readonly NetRectangle nextPosition;

	private readonly NetColor color;

	private readonly NetColor bundleColor;

	private readonly NetBool sayingGoodbye;

	private readonly NetEvent0 setReturnToJunimoHutToFetchStarControllerEvent;

	private readonly NetEvent0 setBringBundleBackToHutControllerEvent;

	private readonly NetEvent0 setJunimoReachedHutToFetchStarControllerEvent;

	private readonly NetEvent0 starDoneSpinningEvent;

	private readonly NetEvent0 returnToJunimoHutToFetchFinalStarEvent;

	private int farmerCloseCheckTimer;

	internal static int soundTimer;

	[XmlIgnore]
	public override bool IsVillager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Junimo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Junimo(Vector2 position, int whichArea, bool temporary = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canPassThroughActionTiles()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldCollideWithBuildingLayer(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canTalk()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChooseAppearance(LocalizedContentManager content = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fadeAway()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setAlpha(float a)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fadeBack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setMoving(int xSpeed, int ySpeed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setMoving(Vector2 motion)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Halt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void returnToJunimoHut(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void stayStill()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void allowToMoveAgain()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void returnToJunimoHutToFetchFinalStar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void returnToJunimoHutToFetchStar(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setReturnToJunimoHutToFetchStarController()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void finalCutscene()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bringBundleBackToHut(Color bundleColor, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setBringBundleBackToHutController()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void junimoReachedHutToReturnBundle(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void junimoReachedHutToFetchStar(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setJunimoReachedHutToFetchStarController()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void placeStar(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sayGoodbye()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void goodbyeDance()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void starDoneSpinning(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performStartDoneSpinning()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void junimoReachedHut(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DrawShadow(SpriteBatch b)
	{
	}
}
