using System.Runtime.CompilerServices;

namespace rail;

public class BrowserRenderStateChanged : EventBase
{
	public bool can_go_back;

	public bool can_go_forward;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BrowserRenderStateChanged()
	{
	}
}
