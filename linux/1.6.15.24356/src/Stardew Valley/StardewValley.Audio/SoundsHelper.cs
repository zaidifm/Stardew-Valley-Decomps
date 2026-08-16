using System;
using System.Text;
using Microsoft.Xna.Framework;

namespace StardewValley.Audio;

public class SoundsHelper : ISoundsHelper
{
	public const float DefaultPitch = 1200f;

	public const float MaxPitch = 2400f;

	public static int MaxDistanceFromScreen = 12;

	private Action<string, GameLocation, Vector2?, int?, float, SoundContext, string> LogSound;

	public virtual bool LogSounds
	{
		get
		{
			return LogSound != null;
		}
		set
		{
			if (value)
			{
				LogSound = LogSoundImpl;
			}
			else
			{
				LogSound = null;
			}
		}
	}

	public virtual bool ShouldPlayLocal(SoundContext context)
	{
		if (context == SoundContext.NPC && Game1.eventUp)
		{
			return false;
		}
		return true;
	}

	public virtual float GetVolumeForDistance(GameLocation location, Vector2? position)
	{
		if (location == null)
		{
			return 1f;
		}
		if (location.NameOrUniqueName != Game1.currentLocation?.NameOrUniqueName)
		{
			return 0f;
		}
		if (!position.HasValue)
		{
			return 1f;
		}
		float num = Utility.distanceFromScreen(position.Value * 64f) / 64f;
		if (num <= 0f)
		{
			return 1f;
		}
		if (num >= (float)MaxDistanceFromScreen)
		{
			return 0f;
		}
		return 1f - num / (float)MaxDistanceFromScreen;
	}

	public virtual bool PlayLocal(string cueName, GameLocation location, Vector2? position, int? pitch, SoundContext context, out ICue cue)
	{
		try
		{
			cue = Game1.soundBank.GetCue(cueName);
			SetPitch(cue, ((float?)pitch) ?? 1200f, pitch.HasValue);
			if (!ShouldPlayLocal(context))
			{
				LogSound?.Invoke(cueName, location, position, pitch, 1f, context, "disabled for context");
				return false;
			}
			float volumeForDistance = GetVolumeForDistance(location, position);
			if (volumeForDistance <= 0f)
			{
				LogSound?.Invoke(cueName, location, position, pitch, volumeForDistance, context, "disabled for distance");
				return false;
			}
			cue.Play();
			if (volumeForDistance < 1f)
			{
				cue.Volume *= volumeForDistance;
			}
			LogSound?.Invoke(cueName, location, position, pitch, volumeForDistance, context, null);
			return true;
		}
		catch (Exception ex)
		{
			Game1.debugOutput = Game1.parseText(ex.Message);
			Game1.log.Error("Error playing sound.", ex);
			cue = DummySoundBank.DummyCue;
			return false;
		}
	}

	public virtual void PlayAll(string cueName, GameLocation location, Vector2? position, int? pitch, SoundContext context)
	{
		if (CanSkipSoundSync(location, position, context))
		{
			PlayLocal(cueName, location, position, pitch, context, out var _);
		}
		else
		{
			location.netAudio.Fire(cueName, position, pitch, context);
		}
	}

	public void SetPitch(ICue cue, float pitch, bool forcePitch = true)
	{
		if (cue == null)
		{
			return;
		}
		cue.SetVariable("Pitch", pitch);
		if (!forcePitch)
		{
			return;
		}
		try
		{
			if (!cue.IsPitchBeingControlledByRPC)
			{
				cue.Pitch = Utility.Lerp(-1f, 1f, pitch / 2400f);
			}
		}
		catch
		{
		}
	}

	public virtual bool CanSkipSoundSync(GameLocation location, Vector2? position, SoundContext context)
	{
		if (!LocalMultiplayer.IsLocalMultiplayer(is_local_only: true))
		{
			return false;
		}
		if (Game1.eventUp && context == SoundContext.NPC)
		{
			return false;
		}
		if (ShouldPlayLocal(context) && GetVolumeForDistance(location, position) > 0f)
		{
			return true;
		}
		if (location != null)
		{
			bool someoneCanHear = false;
			foreach (Game1 gameInstance in GameRunner.instance.gameInstances)
			{
				if (gameInstance.instanceGameLocation?.NameOrUniqueName == location.NameOrUniqueName)
				{
					someoneCanHear = true;
					break;
				}
			}
			if (someoneCanHear && position.HasValue && position != Vector2.Zero)
			{
				someoneCanHear = false;
				GameRunner.instance.ExecuteForInstances(delegate
				{
					if (!someoneCanHear && ShouldPlayLocal(context) && GetVolumeForDistance(location, position) > 0f)
					{
						someoneCanHear = true;
					}
				});
			}
			return someoneCanHear;
		}
		return true;
	}

	protected virtual void LogSoundImpl(string cueName, GameLocation location, Vector2? position, int? pitch, float volume, SoundContext context, string skipReason = null)
	{
		bool num = skipReason != null;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Played sound '").Append(cueName).Append("'");
		if (location == null)
		{
			stringBuilder.Append(" everywhere");
		}
		else
		{
			stringBuilder.Append(" in ").Append(location.NameOrUniqueName);
			if (position.HasValue)
			{
				stringBuilder.Append(" (").Append(position.Value.X).Append(", ")
					.Append(position.Value.Y)
					.Append(")");
			}
		}
		if (pitch.HasValue)
		{
			stringBuilder.Append(" with pitch ").Append(pitch.Value);
		}
		if (!num && volume < 1f)
		{
			stringBuilder.Append(" with distance").Append(volume);
		}
		if (num)
		{
			stringBuilder.Append(" (").Append(skipReason).Append(")");
		}
		Game1.log.Debug(stringBuilder.ToString());
	}
}
