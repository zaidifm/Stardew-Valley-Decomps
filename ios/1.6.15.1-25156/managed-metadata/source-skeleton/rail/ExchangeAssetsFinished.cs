using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class ExchangeAssetsFinished : EventBase
{
	public List<RailAssetItem> old_assets;

	public List<RailGeneratedAssetItem> new_asset_item_list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExchangeAssetsFinished()
	{
	}
}
