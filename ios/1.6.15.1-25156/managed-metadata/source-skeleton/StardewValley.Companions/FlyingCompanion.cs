using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Companions;

public class FlyingCompanion : Companion
{
	public const int VARIANT_FAIRY = 0;

	public const int VARIANT_PARROT = 1;

	private float flitTimer;

	private Vector2 extraPosition;

	private Vector2 extraPositionMotion;

	private Vector2 extraPositionAcceleration;

	private bool floatup;

	private int flapAnimationLength;

	private int currentSidewaysFlap;

	private bool hasLight;

	private string lightId;

	private NetInt whichSubVariant;

	private NetInt startingYForVariant;

	private bool perching;

	private float timeSinceLastZeroLerp;

	private float parrot_squawkTimer;

	private float parrot_squatTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlyingCompanion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlyingCompanion(int whichVariant, int whichSubVariant = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeCompanion(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CleanupCompanion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnOwnerWarp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Hop(float amount)
	{
	}
}
