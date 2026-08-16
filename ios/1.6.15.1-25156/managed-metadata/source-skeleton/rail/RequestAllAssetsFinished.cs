using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RequestAllAssetsFinished : EventBase
{
	public List<RailAssetInfo> assetinfo_list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequestAllAssetsFinished()
	{
	}
}
