using System.Runtime.CompilerServices;

namespace rail;

public class RailDirtyWordsFilterOption
{
	public string input_words;

	public bool use_full_dirty_words;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailDirtyWordsFilterOption()
	{
	}
}
