using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailGameServerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetGameServerPlayerList(RailID gameserver_rail_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetGameServerList(uint start_index, uint end_index, List<GameServerListFilter> alternative_filters, List<GameServerListSorter> sorter, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options, string game_server_name, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options, string game_server_name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailGameServer AsyncCreateGameServer();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetFavoriteGameServers(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetFavoriteGameServers();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncAddFavoriteGameServer(RailID game_server_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncAddFavoriteGameServer(RailID game_server_id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRemoveFavoriteGameServer(RailID game_server_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRemoveFavoriteGameServer(RailID game_server_id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncReportGameServerInfo(RailReportGameServerInfoOptions options, string user_data);
}
