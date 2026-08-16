using System.Runtime.CompilerServices;

namespace rail;

public class RailSpaceWorkSyncProgress
{
	public float progress;

	public ulong finished_bytes;

	public ulong total_bytes;

	public EnumRailSpaceWorkSyncState current_state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailSpaceWorkSyncProgress()
	{
	}
}
