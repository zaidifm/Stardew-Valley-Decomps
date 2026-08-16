using System.Runtime.CompilerServices;

namespace rail;

public class StartConsumeAssetsFinished : EventBase
{
	public ulong asset_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StartConsumeAssetsFinished()
	{
	}
}
