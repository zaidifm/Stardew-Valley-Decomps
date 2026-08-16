using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Audio;

namespace StardewValley.Audio;

public class AudioCategoryWrapper : IAudioCategory
{
	private AudioCategory audioCategory;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioCategoryWrapper(AudioCategory category)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVolume(float volume)
	{
	}
}
