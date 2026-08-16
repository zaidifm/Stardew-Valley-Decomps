using System.Runtime.CompilerServices;

namespace rail;

public class RailKeyValue
{
	public string value;

	public string key;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailKeyValue()
	{
	}
}
