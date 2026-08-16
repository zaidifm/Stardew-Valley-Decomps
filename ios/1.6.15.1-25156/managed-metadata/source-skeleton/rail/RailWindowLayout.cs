using System.Runtime.CompilerServices;

namespace rail;

public class RailWindowLayout
{
	public uint x_margin;

	public uint y_margin;

	public EnumRailNotifyWindowPosition position_type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailWindowLayout()
	{
	}
}
