using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;

namespace StardewValley.Monsters;

public class ShadowGirl : Monster
{
	public const int blockTimeBeforePathfinding = 500;

	[XmlIgnore]
	public new Vector2 lastPosition;

	[XmlIgnore]
	public int howLongOnThisPosition;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowGirl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowGirl(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void localDeathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void sharedDeathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorAtGameTick(GameTime time)
	{
	}
}
