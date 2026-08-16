using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Audio;

namespace StardewValley;

public class DummySoundBank : ISoundBank, IDisposable
{
	internal static readonly ICue DummyCue;

	public bool IsInUse
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsDisposed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Exists(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICue GetCue(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayCue(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayCue(string name, AudioListener listener, AudioEmitter emitter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DummySoundBank()
	{
	}
}
