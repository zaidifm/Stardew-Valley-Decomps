using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailAssets : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRequestAllAssets(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult QueryAssetInfo(ulong asset_id, RailAssetInfo asset_info);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncUpdateAssetsProperty(List<RailAssetProperty> asset_property_list, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncDirectConsumeAssets(List<RailAssetItem> assets, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncStartConsumeAsset(ulong asset_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncUpdateConsumeProgress(ulong asset_id, string progress, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncCompleteConsumeAsset(ulong asset_id, uint quantity, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncExchangeAssets(List<RailAssetItem> old_assets, RailProductItem to_product_info, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncExchangeAssetsTo(List<RailAssetItem> old_assets, RailProductItem to_product_info, ulong add_to_exist_assets, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSplitAsset(ulong source_asset, uint to_quantity, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSplitAssetTo(ulong source_asset, uint to_quantity, ulong add_to_asset, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncMergeAsset(List<RailAssetItem> source_assets, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncMergeAssetTo(List<RailAssetItem> source_assets, ulong add_to_asset, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SerializeAssetsToBuffer(out string buffer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SerializeAssetsToBuffer(List<ulong> assets, out string buffer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult DeserializeAssetsFromBuffer(RailID assets_owner, string buffer, List<RailAssetInfo> assets_info);
}
