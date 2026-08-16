using System.Runtime.CompilerServices;

namespace rail;

public class NetworkCreateRawSessionFailed : EventBase
{
	public RailID local_peer;

	public RailGamePeer remote_game_peer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkCreateRawSessionFailed()
	{
	}
}
