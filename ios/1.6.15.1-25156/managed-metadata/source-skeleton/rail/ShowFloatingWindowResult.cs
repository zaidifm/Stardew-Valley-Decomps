using System.Runtime.CompilerServices;

namespace rail;

public class ShowFloatingWindowResult : EventBase
{
	public EnumRailWindowType window_type;

	public bool is_show;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShowFloatingWindowResult()
	{
	}
}
