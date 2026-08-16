using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class GetGameServerPlayerListResult : EventBase
{
	public RailID game_server_id;

	public List<GameServerPlayerInfo> server_player_info;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetGameServerPlayerListResult()
	{
	}
}
