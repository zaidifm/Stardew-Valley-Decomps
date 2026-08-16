using System.Runtime.CompilerServices;

namespace rail;

public class CreateSessionFailed : EventBase
{
	public RailID local_peer;

	public RailID remote_peer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreateSessionFailed()
	{
	}
}
