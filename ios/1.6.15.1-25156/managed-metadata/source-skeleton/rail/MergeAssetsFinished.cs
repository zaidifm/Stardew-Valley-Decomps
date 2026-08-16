using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class MergeAssetsFinished : EventBase
{
	public List<RailAssetItem> source_assets;

	public ulong new_asset_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MergeAssetsFinished()
	{
	}
}
