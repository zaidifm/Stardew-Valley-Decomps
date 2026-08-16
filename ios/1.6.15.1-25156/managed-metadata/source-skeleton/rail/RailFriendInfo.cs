using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendInfo
{
	public RailID friend_rail_id;

	public EnumRailFriendType friend_type;

	public RailFriendOnLineState online_state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendInfo()
	{
	}
}
