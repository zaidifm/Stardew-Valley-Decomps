using System.Runtime.CompilerServices;

namespace rail;

public class DlcOwnershipChanged : EventBase
{
	public RailDlcID dlc_id;

	public bool is_active;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DlcOwnershipChanged()
	{
	}
}
