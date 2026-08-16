using System.Runtime.CompilerServices;

namespace rail;

public class RailThirdPartyAccountLoginResult : EventBase
{
	public RailThirdPartyAccountInfo account_info;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailThirdPartyAccountLoginResult()
	{
	}
}
