using System.Runtime.CompilerServices;

namespace rail;

public class RailAssetProperty
{
	public ulong asset_id;

	public uint position;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailAssetProperty()
	{
	}
}
