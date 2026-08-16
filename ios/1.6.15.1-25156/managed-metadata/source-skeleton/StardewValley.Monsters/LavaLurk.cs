using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Monsters;

public class LavaLurk : Monster
{
	[XmlType("LavaLurk.State")]
	public enum State
	{
		Submerged,
		Lurking,
		Emerged,
		Firing,
		Diving
	}

	[XmlIgnore]
	public List<FarmerSprite.AnimationFrame> submergedAnimation;

	[XmlIgnore]
	public List<FarmerSprite.AnimationFrame> lurkAnimation;

	[XmlIgnore]
	public List<FarmerSprite.AnimationFrame> emergeAnimation;

	[XmlIgnore]
	public List<FarmerSprite.AnimationFrame> diveAnimation;

	[XmlIgnore]
	public List<FarmerSprite.AnimationFrame> resubmergeAnimation;

	[XmlIgnore]
	public List<FarmerSprite.AnimationFrame> idleAnimation;

	[XmlIgnore]
	public List<FarmerSprite.AnimationFrame> fireAnimation;

	[XmlIgnore]
	public List<FarmerSprite.AnimationFrame> locallyPlayingAnimation;

	[XmlIgnore]
	public bool approachFarmer;

	[XmlIgnore]
	public Vector2 velocity;

	[XmlIgnore]
	public int swimSpeed;

	[XmlIgnore]
	public Farmer targettedFarmer;

	[XmlIgnore]
	public NetEnum<State> currentState;

	[XmlIgnore]
	public float stateTimer;

	[XmlIgnore]
	public float fireTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LavaLurk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LavaLurk(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Initialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEmergeAnimationEnd(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDiveAnimationEnd(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void sharedDeathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool PlayAnimation(List<FarmerSprite.AnimationFrame> animation_to_play, bool loop)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TargetInRange()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetRandomMovement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateMonsterSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorAtGameTick(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsLavaTile(GameLocation location, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckInWater(Rectangle position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateMovement(GameLocation location, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Debris ModifyMonsterLoot(Debris debris)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
