using System.Runtime.CompilerServices;

namespace rail;

public class RailGamePeer
{
	public RailID peer;

	public RailGameID game_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailGamePeer()
	{
	}
}
