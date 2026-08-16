using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class AsyncModifyFavoritesWorksResult : EventBase
{
	public List<SpaceWorkID> success_ids;

	public List<SpaceWorkID> failure_ids;

	public EnumRailModifyFavoritesSpaceWorkType modify_flag;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncModifyFavoritesWorksResult()
	{
	}
}
