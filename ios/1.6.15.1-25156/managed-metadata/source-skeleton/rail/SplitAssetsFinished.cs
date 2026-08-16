using System.Runtime.CompilerServices;

namespace rail;

public class SplitAssetsFinished : EventBase
{
	public ulong source_asset;

	public uint to_quantity;

	public ulong new_asset_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SplitAssetsFinished()
	{
	}
}
