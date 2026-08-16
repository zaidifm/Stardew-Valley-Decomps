using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Audio;

namespace StardewValley;

public interface ISoundBank : IDisposable
{
	bool IsInUse
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool IsDisposed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	ICue GetCue(string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void PlayCue(string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void PlayCue(string name, AudioListener listener, AudioEmitter emitter);
}
