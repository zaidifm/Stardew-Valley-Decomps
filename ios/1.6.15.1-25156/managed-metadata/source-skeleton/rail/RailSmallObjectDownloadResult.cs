using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailSmallObjectDownloadResult : EventBase
{
	public List<RailSmallObjectDownloadInfo> download_infos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailSmallObjectDownloadResult()
	{
	}
}
