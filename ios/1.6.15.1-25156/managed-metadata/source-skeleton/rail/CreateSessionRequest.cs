using System.Runtime.CompilerServices;

namespace rail;

public class CreateSessionRequest : EventBase
{
	public RailID local_peer;

	public RailID remote_peer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreateSessionRequest()
	{
	}
}
