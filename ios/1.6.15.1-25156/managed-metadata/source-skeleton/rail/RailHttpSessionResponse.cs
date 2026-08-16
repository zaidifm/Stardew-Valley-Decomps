using System.Runtime.CompilerServices;

namespace rail;

public class RailHttpSessionResponse : EventBase
{
	public string http_response_data;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailHttpSessionResponse()
	{
	}
}
