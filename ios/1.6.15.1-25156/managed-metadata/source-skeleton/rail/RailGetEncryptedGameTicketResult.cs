using System.Runtime.CompilerServices;

namespace rail;

public class RailGetEncryptedGameTicketResult : EventBase
{
	public string encrypted_game_ticket;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailGetEncryptedGameTicketResult()
	{
	}
}
