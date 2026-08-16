using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Minigames;

public interface IMinigame
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool tick(GameTime time);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool overrideFreeMouseMovement();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool doMainGameUpdates();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void receiveLeftClick(int x, int y, bool playSound = true);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void leftClickHeld(int x, int y);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void receiveRightClick(int x, int y, bool playSound = true);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void releaseLeftClick(int x, int y);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void releaseRightClick(int x, int y);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void receiveKeyPress(Keys k);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void receiveKeyRelease(Keys k);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void draw(SpriteBatch b);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void changeScreenSize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void unload();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void receiveEventPoke(int data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	string minigameId();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool forceQuit();

	[MethodImpl(MethodImplOptions.NoInlining)]
	float GetForcedScaleFactor();
}
