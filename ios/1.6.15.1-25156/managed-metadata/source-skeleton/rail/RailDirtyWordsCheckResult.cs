using System.Runtime.CompilerServices;

namespace rail;

public class RailDirtyWordsCheckResult
{
	public EnumRailDirtyWordsType dirty_type;

	public string replace_string;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailDirtyWordsCheckResult()
	{
	}
}
