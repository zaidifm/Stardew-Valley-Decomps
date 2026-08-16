using System.Runtime.CompilerServices;

namespace rail;

public class BrowserRenderTitleChanged : EventBase
{
	public string new_title;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BrowserRenderTitleChanged()
	{
	}
}
