using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailInGameCoinRequestCoinInfoResponse : EventBase
{
	public List<RailCoinInfo> coin_infos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailInGameCoinRequestCoinInfoResponse()
	{
	}
}
