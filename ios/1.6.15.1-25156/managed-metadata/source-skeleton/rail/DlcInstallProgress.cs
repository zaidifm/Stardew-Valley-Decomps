using System.Runtime.CompilerServices;

namespace rail;

public class DlcInstallProgress : EventBase
{
	public RailDlcInstallProgress progress;

	public RailDlcID dlc_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DlcInstallProgress()
	{
	}
}
