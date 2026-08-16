using System.Runtime.CompilerServices;

namespace rail;

public class RailTextInputResult : EventBase
{
	public string content;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailTextInputResult()
	{
	}
}
