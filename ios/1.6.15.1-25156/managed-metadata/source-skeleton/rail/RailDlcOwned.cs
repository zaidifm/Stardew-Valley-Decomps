using System.Runtime.CompilerServices;

namespace rail;

public class RailDlcOwned
{
	public bool is_owned;

	public RailDlcID dlc_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailDlcOwned()
	{
	}
}
