using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class Butterfly : Critter
{
	public const float maxSpeed = 3f;

	private int flapTimer;

	private int flapSpeed;

	private Vector2 motion;

	private float motionMultiplier;

	private float prismaticCaptureTimer;

	private float prismaticSprinkleTimer;

	private bool summerButterfly;

	public bool stayInbounds;

	public bool isPrismatic;

	public bool isLit;

	private string lightId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Butterfly(GameLocation location, Vector2 position, bool islandButterfly = false, bool forceSummerButterfly = false, int baseFrameOverride = -1, bool prismatic = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doneWithFlap(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Butterfly setStayInbounds(bool stayInbounds)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time, GameLocation environment)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveFrontLayer(SpriteBatch b)
	{
	}
}
