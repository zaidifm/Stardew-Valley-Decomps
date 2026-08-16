using System.Runtime.CompilerServices;

namespace rail;

public class DlcUninstallProgress : EventBase
{
	public string file_name;

	public RailDlcID dlc_id;

	public RailDlcUninstallProgress progress;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DlcUninstallProgress()
	{
	}
}
