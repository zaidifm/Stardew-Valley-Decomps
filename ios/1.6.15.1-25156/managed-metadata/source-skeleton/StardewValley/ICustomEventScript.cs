using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

public interface ICustomEventScript
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool update(GameTime time, Event e);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void draw(SpriteBatch b);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void drawAboveAlwaysFront(SpriteBatch b);
}
