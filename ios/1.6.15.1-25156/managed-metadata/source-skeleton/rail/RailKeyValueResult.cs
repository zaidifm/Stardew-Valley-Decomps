using System.Runtime.CompilerServices;

namespace rail;

public class RailKeyValueResult
{
	public RailResult error_code;

	public string value;

	public string key;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailKeyValueResult()
	{
	}
}
