using System.Runtime.CompilerServices;

namespace rail;

public class BrowserRenderNavigateResult : EventBase
{
	public string url;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BrowserRenderNavigateResult()
	{
	}
}
