using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Monsters;

public class Leaper : Monster
{
	public NetFloat leapDuration;

	public NetFloat leapProgress;

	public NetBool leaping;

	public NetVector2 leapStartPosition;

	public NetVector2 leapEndPosition;

	public float nextLeap;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Leaper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Leaper(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetBaseDifficultyLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnLeapingChanged(NetBool field, bool old_value, bool new_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isInvincible()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateMovement(GameLocation location, GameTime time)
	{
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
	public override void defaultMovementBehavior(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void noMovementProgressNearPlayerBehavior()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsValidLandingTile(Vector2 tile, bool check_other_characters = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorAtGameTick(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void shedChunks(int number, float scale)
	{
	}
}
