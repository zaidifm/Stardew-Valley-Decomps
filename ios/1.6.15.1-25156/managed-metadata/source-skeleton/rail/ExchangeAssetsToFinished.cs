using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class ExchangeAssetsToFinished : EventBase
{
	public ulong exchange_to_asset_id;

	public RailProductItem to_product_info;

	public List<RailAssetItem> old_assets;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExchangeAssetsToFinished()
	{
	}
}
