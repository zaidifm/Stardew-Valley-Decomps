using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class DirectConsumeAssetsFinished : EventBase
{
	public List<RailAssetItem> assets;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DirectConsumeAssetsFinished()
	{
	}
}
