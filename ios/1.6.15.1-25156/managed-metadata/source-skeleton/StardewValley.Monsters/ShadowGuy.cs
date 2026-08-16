using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Monsters;

public class ShadowGuy : Monster
{
	public const int visionDistance = 8;

	public const int spellCooldown = 1500;

	[XmlIgnore]
	public bool spottedPlayer;

	[XmlIgnore]
	public bool casting;

	[XmlIgnore]
	public bool teleporting;

	[XmlIgnore]
	public int coolDown;

	[XmlIgnore]
	public IEnumerator<Point> teleportationPath;

	[XmlIgnore]
	public float rotationTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowGuy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowGuy(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
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
	public void castTeleport()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorAtGameTick(GameTime time)
	{
	}
}
