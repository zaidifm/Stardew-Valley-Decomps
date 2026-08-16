using System;
using Microsoft.Xna.Framework.Audio;

namespace StardewValley;

public class DummySoundBank : ISoundBank, IDisposable
{
	internal static readonly ICue DummyCue = new DummyCue();

	public bool IsInUse => false;

	public bool IsDisposed => true;

	public bool Exists(string name)
	{
		return true;
	}

	public ICue GetCue(string name)
	{
		return DummyCue;
	}

	public void PlayCue(string name)
	{
	}

	public void PlayCue(string name, AudioListener listener, AudioEmitter emitter)
	{
	}

	public void AddCue(CueDefinition definition)
	{
	}

	public CueDefinition GetCueDefinition(string name)
	{
		return null;
	}

	public void Dispose()
	{
	}
}
