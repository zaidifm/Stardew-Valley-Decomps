using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

public class DelayedAction
{
	public int timeUntilAction;

	public int intData;

	public float floatData;

	public string stringData;

	public Point pointData;

	public NPC character;

	public GameLocation location;

	public Action behavior;

	public Game1.afterFadeFunction afterFadeBehavior;

	public bool waitUntilMenusGone;

	public TemporaryAnimatedSprite temporarySpriteData;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DelayedAction(int delay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DelayedAction(int delay, Action behavior)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void warpAfterDelay(string targetLocation, Point targetTile, int delay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addTemporarySpriteAfterDelay(TemporaryAnimatedSprite sprite, GameLocation location, int delay, bool waitUntilMenusGone = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void playSoundAfterDelay(string soundName, int delay, GameLocation location = null, Vector2? position = null, int pitch = -1, bool local = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeTemporarySpriteAfterDelay(GameLocation location, int idOfTempSprite, int delay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DelayedAction playMusicAfterDelay(string musicName, int delay, bool interruptable = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void textAboveHeadAfterDelay(string text, NPC who, int delay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void stopFarmerGlowing(int delay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void showDialogueAfterDelay(string dialogue, int delay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void screenFlashAfterDelay(float intensity, int delay, string sound = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeTileAfterDelay(int x, int y, int delay, GameLocation location, string whichLayer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void fadeAfterDelay(Game1.afterFadeFunction behaviorAfterFade, int delay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DelayedAction functionAfterDelay(Action func, int delay)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyFade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyTextAboveHead()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyTempSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyStopGlowing()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyDialogue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyWarp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyRemoveMapTile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyRemoveTemporarySprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplySoundHelper(bool local)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplySound()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplySoundLocal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyMusicTrack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyScreenFlash()
	{
	}
}
