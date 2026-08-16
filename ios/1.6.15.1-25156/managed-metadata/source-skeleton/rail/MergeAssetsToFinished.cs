using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class MergeAssetsToFinished : EventBase
{
	public ulong merge_to_asset_id;

	public List<RailAssetItem> source_assets;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MergeAssetsToFinished()
	{
	}
}
