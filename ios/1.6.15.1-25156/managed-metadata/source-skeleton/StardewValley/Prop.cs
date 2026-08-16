using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

public class Prop
{
	private Texture2D texture;

	private Rectangle sourceRect;

	private Rectangle drawRect;

	private Rectangle boundingRect;

	private bool solid;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Prop(Texture2D texture, int index, int tilesWideSolid, int tilesHighSolid, int tilesHighDraw, int tileX, int tileY, bool solid = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isColliding(Rectangle r)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsPoint(Vector2 v)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}
}
