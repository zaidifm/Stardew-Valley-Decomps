using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Audio;

namespace StardewValley.Audio;

internal class DummyAudioEngine : IAudioEngine, IDisposable
{
	private IAudioCategory category;

	public AudioEngine Engine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsDisposed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IAudioCategory GetCategory(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DummyAudioEngine()
	{
	}
}
