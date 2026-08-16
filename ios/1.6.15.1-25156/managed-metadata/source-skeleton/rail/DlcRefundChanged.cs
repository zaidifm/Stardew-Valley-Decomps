using System.Runtime.CompilerServices;

namespace rail;

public class DlcRefundChanged : EventBase
{
	public RailDlcID dlc_id;

	public EnumRailGameRefundState refund_state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DlcRefundChanged()
	{
	}
}
