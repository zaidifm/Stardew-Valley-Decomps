using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Locations;

namespace StardewValley.Monsters;

public class Bug : Monster
{
	[XmlElement("isArmoredBug")]
	public readonly NetBool isArmoredBug;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bug()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bug(Vector2 position, int facingDirection, string specialType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bug(Vector2 position, int areaType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bug(Vector2 position, int facingDirection, MineShaft mine)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateMonsterSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void collide(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuffForAdditionalDifficulty(int additional_difficulty)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Item> getExtraDropItems()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
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
}
