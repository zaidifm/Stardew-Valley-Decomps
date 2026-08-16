using System.Runtime.CompilerServices;

namespace StardewValley.Audio;

public interface IAudioCategory
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	void SetVolume(float volume);
}
