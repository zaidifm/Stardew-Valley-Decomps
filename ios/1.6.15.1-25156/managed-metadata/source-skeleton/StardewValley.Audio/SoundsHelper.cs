using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Audio;

public class SoundsHelper : ISoundsHelper
{
	public const float DefaultPitch = 1200f;

	public const float MaxPitch = 2400f;

	public static int MaxDistanceFromScreen;

	private Action<string, GameLocation, Vector2?, int?, float, SoundContext, string> LogSound;

	public virtual bool LogSounds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldPlayLocal(SoundContext context)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float GetVolumeForDistance(GameLocation location, Vector2? position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool PlayLocal(string cueName, GameLocation location, Vector2? position, int? pitch, SoundContext context, out ICue cue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayAll(string cueName, GameLocation location, Vector2? position, int? pitch, SoundContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPitch(ICue cue, float pitch, bool forcePitch = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanSkipSoundSync(GameLocation location, Vector2? position, SoundContext context)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void LogSoundImpl(string cueName, GameLocation location, Vector2? position, int? pitch, float volume, SoundContext context, string skipReason = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoundsHelper()
	{
	}
}
