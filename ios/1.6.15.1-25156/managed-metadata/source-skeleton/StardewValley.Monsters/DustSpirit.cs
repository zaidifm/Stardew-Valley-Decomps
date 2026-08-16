using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Monsters;

public class DustSpirit : Monster
{
	[XmlIgnore]
	public bool seenFarmer;

	[XmlIgnore]
	public bool runningAwayFromFarmer;

	[XmlIgnore]
	public bool chargingFarmer;

	public byte voice;

	[XmlIgnore]
	public ICue meep;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DustSpirit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DustSpirit(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DustSpirit(Vector2 position, bool chargingTowardFarmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void sharedDeathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void localDeathAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void shedChunks(int number, float scale)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void offScreenBehavior(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CaughtInWeb()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorAtGameTick(GameTime time)
	{
	}
}
