using System.Runtime.CompilerServices;

namespace rail;

public class DlcUninstallFinished : EventBase
{
	public RailDlcID dlc_id;

	public new RailResult result;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DlcUninstallFinished()
	{
	}
}
