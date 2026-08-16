using System.Runtime.CompilerServices;

namespace rail;

public class PlayerGetGamePurchaseKeyResult : EventBase
{
	public string purchase_key;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerGetGamePurchaseKeyResult()
	{
	}
}
