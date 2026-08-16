using System.Runtime.CompilerServices;

namespace rail;

public class RailSmallObjectState
{
	public EnumRailSmallObjectUpdateState update_state;

	public uint index;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailSmallObjectState()
	{
	}
}
