using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendPlayedGameInfo
{
	public bool in_room;

	public List<ulong> room_id_list;

	public RailID friend_id;

	public List<ulong> game_server_id_list;

	public RailGameID game_id;

	public bool in_game_server;

	public RailFriendPlayedGamePlayState friend_played_game_play_state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendPlayedGameInfo()
	{
	}
}
