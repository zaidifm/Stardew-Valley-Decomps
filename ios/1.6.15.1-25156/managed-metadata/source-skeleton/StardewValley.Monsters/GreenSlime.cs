using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Monsters;

public class GreenSlime : Monster
{
	public const float mutationFactor = 0.25f;

	public const int matingInterval = 120000;

	public const int childhoodLength = 120000;

	public const int durationOfMating = 2000;

	public const double chanceToMate = 0.001;

	public static int matingRange;

	public const int AQUA_SLIME = 9999899;

	public NetIntDelta stackedSlimes;

	public float randomStackOffset;

	[XmlIgnore]
	public NetEvent1Field<Vector2, NetVector2> attackedEvent;

	[XmlElement("leftDrift")]
	public readonly NetBool leftDrift;

	[XmlElement("cute")]
	public readonly NetBool cute;

	[XmlIgnore]
	public int readyToJump;

	[XmlIgnore]
	public int matingCountdown;

	[XmlIgnore]
	public new int yOffset;

	[XmlIgnore]
	public int wagTimer;

	public int readyToMate;

	[XmlElement("ageUntilFullGrown")]
	public readonly NetInt ageUntilFullGrown;

	public int animateTimer;

	public int timeSinceLastJump;

	[XmlElement("specialNumber")]
	public readonly NetInt specialNumber;

	[XmlElement("firstGeneration")]
	public readonly NetBool firstGeneration;

	[XmlElement("color")]
	public readonly NetColor color;

	private readonly NetBool pursuingMate;

	private readonly NetBool avoidingMate;

	private GreenSlime mate;

	public readonly NetBool prismatic;

	private readonly NetVector2 facePosition;

	private readonly NetEvent1Field<Vector2, NetVector2> jumpEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GreenSlime()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GreenSlime(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GreenSlime(Vector2 position, int mineLevel)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GreenSlime(Vector2 position, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void makeTigerSlime(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void makePrismatic()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAttacked(Vector2 trajectory)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void shedChunks(int number, float scale)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void collisionWithFarmerBehavior()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void onDealContactDamage(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void moveTowardOtherSlime(GreenSlime other, bool moveAway, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doneMating()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void noMovementProgressNearPlayerBehavior()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void mateWith(GreenSlime mateToPursue, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Item> getExtraDropItems()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void dayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateAnimation(GameTime time)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doJump(Vector2 trajectory)
	{
	}
}
