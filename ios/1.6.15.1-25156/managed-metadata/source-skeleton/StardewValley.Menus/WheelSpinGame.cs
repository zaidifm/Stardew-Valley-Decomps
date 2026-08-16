using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.BellsAndWhistles;

namespace StardewValley.Menus;

public class WheelSpinGame : IClickableMenu
{
	public new const int width = 640;

	public new const int height = 448;

	public double arrowRotation;

	public double arrowRotationVelocity;

	public double arrowRotationDeceleration;

	private int timerBeforeStart;

	private int wager;

	private SparklingText resultText;

	private bool doneSpinning;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WheelSpinGame(int wager)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
