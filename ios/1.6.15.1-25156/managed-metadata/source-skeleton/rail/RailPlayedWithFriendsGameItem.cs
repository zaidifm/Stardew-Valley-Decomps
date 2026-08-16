using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailPlayedWithFriendsGameItem
{
	public List<RailGameID> game_ids;

	public RailID rail_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailPlayedWithFriendsGameItem()
	{
	}
}
