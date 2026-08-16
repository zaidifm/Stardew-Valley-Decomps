using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailUsersInfoData : EventBase
{
	public List<PlayerPersonalInfo> user_info_list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailUsersInfoData()
	{
	}
}
