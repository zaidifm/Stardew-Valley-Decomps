using System;
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

	public DelayedAction(int delay)
	{
		timeUntilAction = delay;
	}

	public DelayedAction(int delay, Action behavior)
	{
		timeUntilAction = delay;
		this.behavior = behavior;
	}

	public bool update(GameTime time)
	{
		if (!waitUntilMenusGone || Game1.activeClickableMenu == null)
		{
			timeUntilAction -= time.ElapsedGameTime.Milliseconds;
			if (timeUntilAction <= 0)
			{
				behavior();
			}
		}
		return timeUntilAction <= 0;
	}

	public static void warpAfterDelay(string targetLocation, Point targetTile, int delay)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = delayedAction.ApplyWarp;
		delayedAction.stringData = targetLocation;
		delayedAction.pointData = targetTile;
		Game1.delayedActions.Add(delayedAction);
	}

	public static void addTemporarySpriteAfterDelay(TemporaryAnimatedSprite sprite, GameLocation location, int delay, bool waitUntilMenusGone = false)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = delayedAction.ApplyTempSprite;
		delayedAction.temporarySpriteData = sprite;
		delayedAction.location = location;
		delayedAction.waitUntilMenusGone = waitUntilMenusGone;
		Game1.delayedActions.Add(delayedAction);
	}

	public static void playSoundAfterDelay(string soundName, int delay, GameLocation location = null, Vector2? position = null, int pitch = -1, bool local = false)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		if (local)
		{
			delayedAction.behavior = delayedAction.ApplySoundLocal;
		}
		else
		{
			delayedAction.behavior = delayedAction.ApplySound;
		}
		delayedAction.stringData = soundName;
		delayedAction.location = location;
		delayedAction.intData = pitch;
		if (position.HasValue)
		{
			delayedAction.pointData = Utility.Vector2ToPoint(position.Value);
		}
		Game1.delayedActions.Add(delayedAction);
	}

	public static void removeTemporarySpriteAfterDelay(GameLocation location, int idOfTempSprite, int delay)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = delayedAction.ApplyRemoveTemporarySprite;
		delayedAction.location = location;
		delayedAction.intData = idOfTempSprite;
		Game1.delayedActions.Add(delayedAction);
	}

	public static DelayedAction playMusicAfterDelay(string musicName, int delay, bool interruptable = true)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = delayedAction.ApplyMusicTrack;
		delayedAction.stringData = musicName;
		delayedAction.intData = (interruptable ? 1 : 0);
		Game1.delayedActions.Add(delayedAction);
		return delayedAction;
	}

	public static void textAboveHeadAfterDelay(string text, NPC who, int delay)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = delayedAction.ApplyTextAboveHead;
		delayedAction.stringData = text;
		delayedAction.character = who;
		Game1.delayedActions.Add(delayedAction);
	}

	public static void stopFarmerGlowing(int delay)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = delayedAction.ApplyStopGlowing;
		Game1.delayedActions.Add(delayedAction);
	}

	public static void showDialogueAfterDelay(string dialogue, int delay)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = delayedAction.ApplyDialogue;
		delayedAction.stringData = dialogue;
		Game1.delayedActions.Add(delayedAction);
	}

	public static void screenFlashAfterDelay(float intensity, int delay, string sound = null)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = delayedAction.ApplyScreenFlash;
		delayedAction.stringData = sound;
		delayedAction.floatData = intensity;
		Game1.delayedActions.Add(delayedAction);
	}

	public static void removeTileAfterDelay(int x, int y, int delay, GameLocation location, string whichLayer)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = delayedAction.ApplyRemoveMapTile;
		delayedAction.pointData = new Point(x, y);
		delayedAction.location = location;
		delayedAction.stringData = whichLayer;
		Game1.delayedActions.Add(delayedAction);
	}

	public static void fadeAfterDelay(Game1.afterFadeFunction behaviorAfterFade, int delay)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = delayedAction.ApplyFade;
		delayedAction.afterFadeBehavior = behaviorAfterFade;
		Game1.delayedActions.Add(delayedAction);
	}

	public static DelayedAction functionAfterDelay(Action func, int delay)
	{
		DelayedAction delayedAction = new DelayedAction(delay);
		delayedAction.behavior = func;
		Game1.delayedActions.Add(delayedAction);
		return delayedAction;
	}

	private void ApplyFade()
	{
		Game1.globalFadeToBlack(afterFadeBehavior);
	}

	private void ApplyTextAboveHead()
	{
		string text = stringData;
		if (text != null)
		{
			character?.showTextAboveHead(text);
		}
	}

	private void ApplyTempSprite()
	{
		if (temporarySpriteData != null)
		{
			location?.TemporarySprites.Add(temporarySpriteData);
		}
	}

	private void ApplyStopGlowing()
	{
		Game1.player.stopGlowing();
		Game1.player.stopJittering();
		Game1.screenGlowHold = false;
		if (Game1.isFestival() && Game1.IsFall)
		{
			Game1.changeMusicTrack("fallFest");
		}
	}

	private void ApplyDialogue()
	{
		Game1.drawObjectDialogue(stringData);
	}

	private void ApplyWarp()
	{
		string text = stringData;
		Point point = pointData;
		if (text != null)
		{
			Game1.warpFarmer(text, point.X, point.Y, flip: false);
		}
	}

	private void ApplyRemoveMapTile()
	{
		string text = stringData;
		Point point = pointData;
		if (text != null)
		{
			location?.removeTile(point.X, point.Y, text);
		}
	}

	private void ApplyRemoveTemporarySprite()
	{
		int id = intData;
		location?.removeTemporarySpritesWithID(id);
	}

	private void ApplySoundHelper(bool local)
	{
		string text = stringData;
		int? pitch = ((intData > -1) ? new int?(intData) : ((int?)null));
		Vector2? position = ((pointData != Point.Zero) ? new Vector2?(Utility.PointToVector2(pointData)) : ((Vector2?)null));
		if (text != null)
		{
			if (location == null)
			{
				Game1.playSound(text, pitch);
			}
			else if (local)
			{
				location.localSound(text, position, pitch);
			}
			else
			{
				location.playSound(text, position, pitch);
			}
		}
	}

	private void ApplySound()
	{
		ApplySoundHelper(local: false);
	}

	private void ApplySoundLocal()
	{
		ApplySoundHelper(local: true);
	}

	private void ApplyMusicTrack()
	{
		string text = stringData;
		bool track_interruptable = intData > 0;
		if (text != null)
		{
			Game1.changeMusicTrack(text, track_interruptable);
		}
	}

	private void ApplyScreenFlash()
	{
		float flashAlpha = floatData;
		string text = stringData;
		if (!string.IsNullOrEmpty(text))
		{
			Game1.playSound(text);
		}
		Game1.flashAlpha = flashAlpha;
	}
}
