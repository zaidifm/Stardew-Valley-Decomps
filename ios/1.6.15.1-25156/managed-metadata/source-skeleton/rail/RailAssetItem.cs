using System.Runtime.CompilerServices;

namespace rail;

public class RailAssetItem
{
	public ulong asset_id;

	public uint quantity;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailAssetItem()
	{
	}
}
