using System.Runtime.CompilerServices;

namespace rail;

public class RailThirdPartyAccountRefreshTokenResult : EventBase
{
	public RailThirdPartyAccountInfo account_info;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailThirdPartyAccountRefreshTokenResult()
	{
	}
}
