using System.Runtime.CompilerServices;

namespace rail;

public class RailSessionTicket
{
	public string ticket;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailSessionTicket()
	{
	}
}
