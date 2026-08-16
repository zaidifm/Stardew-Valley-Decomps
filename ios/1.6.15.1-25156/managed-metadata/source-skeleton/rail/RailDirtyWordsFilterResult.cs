using System.Runtime.CompilerServices;

namespace rail;

public class RailDirtyWordsFilterResult : EventBase
{
	public bool has_dirty_words;

	public string input_words;

	public string output_words;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailDirtyWordsFilterResult()
	{
	}
}
