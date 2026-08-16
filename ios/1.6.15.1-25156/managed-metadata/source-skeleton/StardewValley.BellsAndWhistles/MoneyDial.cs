using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class MoneyDial
{
	public const int digitHeight = 8;

	public int numDigits;

	public int currentValue;

	public int previousTargetValue;

	public TemporaryAnimatedSpriteList animations;

	private int speed;

	private int soundTimer;

	private int moneyMadeAccumulator;

	private int moneyShineTimer;

	private bool playSounds;

	public Action<int> onPlaySound;

	public bool ShouldShakeMainMoneyBox;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MoneyDial(int numDigits, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playDefaultSound(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b, Vector2 position, int target)
	{
	}
}
