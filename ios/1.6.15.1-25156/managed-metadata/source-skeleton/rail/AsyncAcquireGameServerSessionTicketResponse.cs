using System.Runtime.CompilerServices;

namespace rail;

public class AsyncAcquireGameServerSessionTicketResponse : EventBase
{
	public RailSessionTicket session_ticket;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncAcquireGameServerSessionTicketResponse()
	{
	}
}
