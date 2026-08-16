using System.Runtime.CompilerServices;

namespace rail;

public class UpdateConsumeAssetsFinished : EventBase
{
	public ulong asset_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UpdateConsumeAssetsFinished()
	{
	}
}
