using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class UserSpaceDownloadResult : EventBase
{
	public uint total_results;

	public List<RailUserSpaceDownloadResult> results;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserSpaceDownloadResult()
	{
	}
}
