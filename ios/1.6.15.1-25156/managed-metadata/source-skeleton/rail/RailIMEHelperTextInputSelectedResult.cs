using System.Runtime.CompilerServices;

namespace rail;

public class RailIMEHelperTextInputSelectedResult : EventBase
{
	public string content;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailIMEHelperTextInputSelectedResult()
	{
	}
}
