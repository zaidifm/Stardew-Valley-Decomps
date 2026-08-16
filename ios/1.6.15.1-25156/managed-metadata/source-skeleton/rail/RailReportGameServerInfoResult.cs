using System.Runtime.CompilerServices;

namespace rail;

public class RailReportGameServerInfoResult : EventBase
{
	public string server_response;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailReportGameServerInfoResult()
	{
	}
}
