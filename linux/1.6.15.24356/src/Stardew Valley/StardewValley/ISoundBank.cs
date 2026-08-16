using System;
using Microsoft.Xna.Framework.Audio;

namespace StardewValley;

public interface ISoundBank : IDisposable
{
	bool IsInUse { get; }

	bool IsDisposed { get; }

	ICue GetCue(string name);

	void PlayCue(string name);

	void PlayCue(string name, AudioListener listener, AudioEmitter emitter);

	void AddCue(CueDefinition definition);

	bool Exists(string name);

	CueDefinition GetCueDefinition(string name);
}
