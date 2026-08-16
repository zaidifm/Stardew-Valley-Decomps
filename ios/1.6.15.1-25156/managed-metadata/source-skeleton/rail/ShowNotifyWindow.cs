using System.Runtime.CompilerServices;

namespace rail;

public class ShowNotifyWindow : EventBase
{
	public EnumRailNotifyWindowType window_type;

	public string json_content;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShowNotifyWindow()
	{
	}
}
