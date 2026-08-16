using System.Runtime.CompilerServices;

namespace rail;

public class StartSessionWithPlayerResponse : EventBase
{
	public RailID remote_rail_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StartSessionWithPlayerResponse()
	{
	}
}
