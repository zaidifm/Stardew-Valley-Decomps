using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Audio;

namespace StardewValley;

public interface ICue : IDisposable
{
	bool IsStopped
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool IsStopping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool IsPlaying
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool IsPaused
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Play();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Pause();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Resume();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Stop(AudioStopOptions options);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void SetVariable(string var, int val);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void SetVariable(string var, float val);

	[MethodImpl(MethodImplOptions.NoInlining)]
	float GetVariable(string var);
}
