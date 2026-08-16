using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Audio;

namespace StardewValley;

public class CueWrapper : ICue, IDisposable
{
	private Cue cue;

	public bool IsStopped
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsStopping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsPlaying
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsPaused
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CueWrapper(Cue cue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Play()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Pause()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Resume()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop(AudioStopOptions options)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVariable(string var, int val)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVariable(string var, float val)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetVariable(string var)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
	}
}
