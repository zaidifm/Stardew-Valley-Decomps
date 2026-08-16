using System.Runtime.CompilerServices;

namespace StardewValley.Audio;

public class DummyAudioCategory : IAudioCategory
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVolume(float volume)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DummyAudioCategory()
	{
	}
}
