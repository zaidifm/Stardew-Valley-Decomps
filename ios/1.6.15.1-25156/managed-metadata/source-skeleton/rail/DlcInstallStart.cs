using System.Runtime.CompilerServices;

namespace rail;

public class DlcInstallStart : EventBase
{
	public RailDlcID dlc_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DlcInstallStart()
	{
	}
}
