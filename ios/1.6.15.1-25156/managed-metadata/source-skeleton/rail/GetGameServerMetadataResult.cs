using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class GetGameServerMetadataResult : EventBase
{
	public RailID game_server_id;

	public List<RailKeyValue> key_value;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetGameServerMetadataResult()
	{
	}
}
