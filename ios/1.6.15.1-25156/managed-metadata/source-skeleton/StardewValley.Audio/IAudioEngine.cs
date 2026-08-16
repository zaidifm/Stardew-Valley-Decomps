using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Audio;

namespace StardewValley.Audio;

public interface IAudioEngine : IDisposable
{
	bool IsDisposed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	AudioEngine Engine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Update();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IAudioCategory GetCategory(string name);
}
