using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Audio;

public class LoopingCueManager
{
	private Dictionary<string, ICue> playingCues;

	private List<string> cuesToStop;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameLocation currentLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopAll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LoopingCueManager()
	{
	}
}
