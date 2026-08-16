using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class GetGameServerListResult : EventBase
{
	public List<GameServerInfo> server_info;

	public uint total_num;

	public uint start_index;

	public uint end_index;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetGameServerListResult()
	{
	}
}
