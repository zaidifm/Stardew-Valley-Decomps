using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Objects;

public class RandomizedPlantFurniture : Furniture
{
	public NetInt topIndex;

	public NetInt middleIndex;

	public NetInt bottomIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void GetOneCopyFrom(Item source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RandomizedPlantFurniture(string which, Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RandomizedPlantFurniture(string which, Vector2 tile, int random_seed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RandomizedPlantFurniture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override float getScaleSizeForMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsHeldOverHead()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawWhenHeld(SpriteBatch spriteBatch, Vector2 objectPosition, Farmer f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAtNonTileSpot(SpriteBatch spriteBatch, Vector2 location, float layerDepth, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawFurniture(SpriteBatch sb, Vector2 location, float alpha, Vector2 origin, float scale, float base_sort_y)
	{
	}
}
