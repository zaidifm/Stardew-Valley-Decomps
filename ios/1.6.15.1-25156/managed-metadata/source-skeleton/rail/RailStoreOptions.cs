using System.Runtime.CompilerServices;

namespace rail;

public class RailStoreOptions
{
	public int window_margin_top;

	public int window_margin_left;

	public EnumRailStoreType store_type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailStoreOptions()
	{
	}
}
