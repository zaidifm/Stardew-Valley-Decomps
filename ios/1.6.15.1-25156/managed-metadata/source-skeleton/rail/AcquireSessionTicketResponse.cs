using System.Runtime.CompilerServices;

namespace rail;

public class AcquireSessionTicketResponse : EventBase
{
	public uint ticket_expire_time;

	public RailSessionTicket session_ticket;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AcquireSessionTicketResponse()
	{
	}
}
