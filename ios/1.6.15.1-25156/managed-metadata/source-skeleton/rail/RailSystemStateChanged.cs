using System.Runtime.CompilerServices;

namespace rail;

public class RailSystemStateChanged : EventBase
{
	public RailSystemState state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailSystemStateChanged()
	{
	}
}
