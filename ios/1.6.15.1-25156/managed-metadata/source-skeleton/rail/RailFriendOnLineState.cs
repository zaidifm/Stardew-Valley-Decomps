using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendOnLineState
{
	public RailID friend_rail_id;

	public uint game_define_game_playing_state;

	public EnumRailPlayerOnLineState friend_online_state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendOnLineState()
	{
	}
}
