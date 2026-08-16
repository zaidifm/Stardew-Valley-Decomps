using System.Runtime.CompilerServices;

namespace rail;

public class RailGameClientNeedUpdate : EventBase
{
	public RailBranchInfo new_branch_info;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailGameClientNeedUpdate()
	{
	}
}
