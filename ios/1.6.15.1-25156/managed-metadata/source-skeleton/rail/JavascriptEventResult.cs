using System.Runtime.CompilerServices;

namespace rail;

public class JavascriptEventResult : EventBase
{
	public string event_name;

	public string event_value;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JavascriptEventResult()
	{
	}
}
