using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Events;

public interface FarmEvent : INetObject<NetFields>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool setUp();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool tickUpdate(GameTime time);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void draw(SpriteBatch b);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void drawAboveEverything(SpriteBatch b);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void makeChangesToLocation();
}
