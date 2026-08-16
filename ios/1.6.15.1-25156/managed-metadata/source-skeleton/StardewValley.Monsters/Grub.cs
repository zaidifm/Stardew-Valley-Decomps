using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Monsters;

public class Grub : Monster
{
	public const int healthToRunAway = 8;

	[XmlIgnore]
	public readonly NetBool leftDrift;

	[XmlIgnore]
	public readonly NetBool pupating;

	[XmlElement("hard")]
	public readonly NetBool hard;

	[XmlIgnore]
	public int metamorphCounter;

	[XmlIgnore]
	public readonly NetFloat targetRotation;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Grub()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Grub(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Grub(Vector2 position, bool hard)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setHard()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void defaultMovementBehavior(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuffForAdditionalDifficulty(int additional_difficulty)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateMonsterSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorAtGameTick(GameTime time)
	{
	}
}
