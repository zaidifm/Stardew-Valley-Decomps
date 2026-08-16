using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StardewValley.GameData;

namespace StardewValley.Audio;

public class AudioCueModificationManager
{
	public Dictionary<string, AudioCueData> cueModificationData;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyAllCueModifications()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetFilePath(string filePath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyCueModification(string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioCueModificationManager()
	{
	}
}
