using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.ItemTypeDefinitions;

namespace StardewValley.Objects;

[InstanceStatics]
public class Phone : Object
{
	public static List<IPhoneHandler> PhoneHandlers = new List<IPhoneHandler>
	{
		new DefaultPhoneHandler()
	};

	public const int RING_DURATION = 600;

	public const int RING_CYCLE_TIME = 1800;

	public static Random r;

	protected static bool _phoneSoundPlaying = false;

	public static int ringingTimer;

	public static string whichPhoneCall = null;

	public static long lastRunTick = -1L;

	public static long lastMinutesElapsedTick = -1L;

	public static int intervalsToRing = 0;

	public override string TypeDefinitionId => "(BC)";

	public Phone()
	{
	}

	public Phone(Vector2 position)
		: base(position, "214")
	{
		Name = "Telephone";
		type.Value = "Crafting";
		bigCraftable.Value = true;
		canBeSetDown.Value = true;
	}

	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		if (justCheckingForActivity)
		{
			return true;
		}
		string text = whichPhoneCall;
		StopRinging();
		if (text == null)
		{
			Game1.game1.ShowTelephoneMenu();
		}
		else if (!HandleIncomingCall(text))
		{
			HangUp();
		}
		return true;
	}

	public static bool HandleIncomingCall(string callId)
	{
		Action incomingCallAction = GetIncomingCallAction(callId);
		if (incomingCallAction == null)
		{
			return false;
		}
		Game1.playSound("openBox");
		Game1.player.freezePause = 500;
		DelayedAction.functionAfterDelay(incomingCallAction, 500);
		if (!Game1.player.callsReceived.TryGetValue(callId, out var value))
		{
			value = 0;
		}
		Game1.player.callsReceived[callId] = value + 1;
		return true;
	}

	public override void updateWhenCurrentLocation(GameTime time)
	{
		if (Location != Game1.currentLocation)
		{
			return;
		}
		if (Game1.ticks != lastRunTick)
		{
			if (Game1.eventUp)
			{
				return;
			}
			lastRunTick = Game1.ticks;
			if (whichPhoneCall != null && Game1.shouldTimePass())
			{
				if (ringingTimer == 0)
				{
					Game1.playSound("phone");
					_phoneSoundPlaying = true;
				}
				ringingTimer += (int)time.ElapsedGameTime.TotalMilliseconds;
				if (ringingTimer >= 1800)
				{
					ringingTimer = 0;
					_phoneSoundPlaying = false;
				}
			}
		}
		base.updateWhenCurrentLocation(time);
	}

	public override void DayUpdate()
	{
		base.DayUpdate();
		r = Utility.CreateRandom(Game1.uniqueIDForThisGame, Game1.stats.DaysPlayed);
		_phoneSoundPlaying = false;
		ringingTimer = 0;
		whichPhoneCall = null;
		intervalsToRing = 0;
	}

	public override bool minutesElapsed(int minutes)
	{
		if (!Game1.IsMasterGame)
		{
			return false;
		}
		if (lastMinutesElapsedTick != Game1.ticks)
		{
			lastMinutesElapsedTick = Game1.ticks;
			if (intervalsToRing == 0)
			{
				if (r == null)
				{
					r = Utility.CreateRandom(Game1.uniqueIDForThisGame, Game1.stats.DaysPlayed);
				}
				foreach (IPhoneHandler phoneHandler in PhoneHandlers)
				{
					string text = phoneHandler.CheckForIncomingCall(r);
					if (text != null)
					{
						intervalsToRing = 3;
						Game1.player.team.ringPhoneEvent.Fire(text);
						break;
					}
				}
			}
			else
			{
				intervalsToRing--;
				if (intervalsToRing <= 0)
				{
					Game1.player.team.ringPhoneEvent.Fire(null);
				}
			}
		}
		return base.minutesElapsed(minutes);
	}

	public static bool IsRinging()
	{
		return _phoneSoundPlaying;
	}

	public static void Ring(string callId)
	{
		if (string.IsNullOrWhiteSpace(callId))
		{
			StopRinging();
		}
		else if (GetIncomingCallAction(callId) != null)
		{
			whichPhoneCall = callId;
			ringingTimer = 0;
			_phoneSoundPlaying = false;
		}
	}

	public static void StopRinging()
	{
		whichPhoneCall = null;
		ringingTimer = 0;
		intervalsToRing = 0;
		if (IsRinging())
		{
			Game1.soundBank.GetCue("phone").Stop(AudioStopOptions.Immediate);
			_phoneSoundPlaying = false;
		}
	}

	public static void HangUp()
	{
		StopRinging();
		Game1.currentLocation.playSound("openBox");
	}

	public static Action GetIncomingCallAction(string callId)
	{
		foreach (IPhoneHandler phoneHandler in PhoneHandlers)
		{
			if (phoneHandler.TryHandleIncomingCall(callId, out var showDialogue))
			{
				return showDialogue;
			}
		}
		return null;
	}

	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
		if (!isTemporarilyInvisible)
		{
			base.draw(spriteBatch, x, y, alpha);
			bool flag = ringingTimer > 0 && ringingTimer < 600;
			Vector2 vector = Game1.GlobalToLocal(Game1.viewport, new Vector2(x * 64, y * 64 - 64));
			Rectangle destinationRectangle = new Rectangle((int)vector.X + ((flag || shakeTimer > 0) ? Game1.random.Next(-1, 2) : 0), (int)vector.Y + ((flag || shakeTimer > 0) ? Game1.random.Next(-1, 2) : 0), 64, 128);
			float layerDepth = Math.Max(0f, (float)((y + 1) * 64 - 20) / 10000f) + (float)x * 1E-05f;
			ParsedItemData dataOrErrorItem = ItemRegistry.GetDataOrErrorItem(base.QualifiedItemId);
			spriteBatch.Draw(dataOrErrorItem.GetTexture(), destinationRectangle, dataOrErrorItem.GetSourceRect(1, base.ParentSheetIndex), Color.White * alpha, 0f, Vector2.Zero, SpriteEffects.None, layerDepth);
		}
	}
}
