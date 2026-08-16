using System.Runtime.CompilerServices;

namespace rail;

public class CompleteConsumeAssetsFinished : EventBase
{
	public RailAssetItem asset_item;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompleteConsumeAssetsFinished()
	{
	}
}
