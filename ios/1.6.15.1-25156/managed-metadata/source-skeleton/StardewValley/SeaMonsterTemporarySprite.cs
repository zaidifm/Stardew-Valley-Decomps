using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

public class SeaMonsterTemporarySprite : TemporaryAnimatedSprite
{
	public new Texture2D texture;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SeaMonsterTemporarySprite(float animationInterval, int animationLength, int numberOfLoops, Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, bool localPosition = false, int xOffset = 0, int yOffset = 0, float extraAlpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
