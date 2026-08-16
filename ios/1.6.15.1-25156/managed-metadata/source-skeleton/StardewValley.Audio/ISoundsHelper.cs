using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Audio;

public interface ISoundsHelper
{
	bool LogSounds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ShouldPlayLocal(SoundContext context);

	[MethodImpl(MethodImplOptions.NoInlining)]
	float GetVolumeForDistance(GameLocation location, Vector2? position);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool PlayLocal(string cueName, GameLocation location, Vector2? position, int? pitch, SoundContext context, out ICue cue);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void PlayAll(string cueName, GameLocation location, Vector2? position, int? pitch, SoundContext context);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void SetPitch(ICue cue, float pitch, bool forcePitch = true);
}
