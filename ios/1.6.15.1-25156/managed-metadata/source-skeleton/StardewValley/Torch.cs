using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

public class Torch : Object
{
	public const float yVelocity = 1f;

	public const float yDissapearLevel = -100f;

	public const double ashChance = 0.015;

	private float color;

	private Vector2[] ashes;

	private float smokePuffTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Torch()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Torch(int initialStack)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Torch(int initialStack, string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Torch(string index, bool bigCraftable)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RecalculateBoundingBox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void actionOnPlayerEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool placementAction(GameLocation location, int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPassable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateAshes(int identifier)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performRemoveAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int xNonTile, int yNonTile, float layerDepth, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawBasicTorch(SpriteBatch spriteBatch, float x, float y, float layerDepth, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}
}
