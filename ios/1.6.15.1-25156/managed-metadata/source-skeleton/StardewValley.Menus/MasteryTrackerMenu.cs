using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class MasteryTrackerMenu : IClickableMenu
{
	public const int MASTERY_EXP_PER_LEVEL = 10000;

	public const int WIDTH = 200;

	public const int HEIGHT = 80;

	public ClickableTextureComponent mainButton;

	private float pressedButtonTimer;

	private float destroyTimer;

	private List<ClickableTextureComponent> rewards;

	private int which;

	private bool canClaim;

	private SpriteFont font;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MasteryTrackerMenu(int whichSkill = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void claimReward()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addSpiritCandles(bool instant = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void addCandle(int x, int y, int delay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addSkillFlairPlaque(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool hasCompletedAllMasteryPlaques()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMasteryExpNeededForLevel(int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getCurrentMasteryLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawBar(SpriteBatch b, Vector2 topLeftSpot, float widthScale = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
