using Microsoft.Xna.Framework;

namespace StardewValley.Audio;

public interface ISoundsHelper
{
	bool LogSounds { get; set; }

	bool ShouldPlayLocal(SoundContext context);

	float GetVolumeForDistance(GameLocation location, Vector2? position);

	bool PlayLocal(string cueName, GameLocation location, Vector2? position, int? pitch, SoundContext context, out ICue cue);

	void PlayAll(string cueName, GameLocation location, Vector2? position, int? pitch, SoundContext context);

	void SetPitch(ICue cue, float pitch, bool forcePitch = true);
}
