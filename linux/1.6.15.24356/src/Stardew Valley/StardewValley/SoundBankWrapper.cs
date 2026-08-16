using System;
using Microsoft.Xna.Framework.Audio;

namespace StardewValley;

public class SoundBankWrapper : ISoundBank, IDisposable
{
	private string DefaultCueName = "shiny4";

	private SoundBank soundBank;

	public bool IsInUse => soundBank.IsInUse;

	public bool IsDisposed => soundBank.IsDisposed;

	public SoundBankWrapper(SoundBank soundBank)
	{
		this.soundBank = soundBank;
	}

	public ICue GetCue(string name)
	{
		if (!Exists(name))
		{
			Game1.log.Error("Can't get audio ID '" + name + "' because it doesn't exist.");
			name = DefaultCueName;
		}
		return new CueWrapper(soundBank.GetCue(name));
	}

	public void PlayCue(string name)
	{
		if (!Exists(name))
		{
			Game1.log.Error("Can't play audio ID '" + name + "' because it doesn't exist.");
			name = DefaultCueName;
		}
		soundBank.PlayCue(name);
	}

	public void PlayCue(string name, AudioListener listener, AudioEmitter emitter)
	{
		soundBank.PlayCue(name, listener, emitter);
	}

	public void Dispose()
	{
		soundBank.Dispose();
	}

	public void AddCue(CueDefinition definition)
	{
		soundBank.AddCue(definition);
	}

	public bool Exists(string name)
	{
		return soundBank.Exists(name);
	}

	public CueDefinition GetCueDefinition(string name)
	{
		return soundBank.GetCueDefinition(name);
	}
}
