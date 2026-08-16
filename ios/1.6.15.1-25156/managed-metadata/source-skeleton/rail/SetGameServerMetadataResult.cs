using System.Runtime.CompilerServices;

namespace rail;

public class SetGameServerMetadataResult : EventBase
{
	public RailID game_server_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SetGameServerMetadataResult()
	{
	}
}
