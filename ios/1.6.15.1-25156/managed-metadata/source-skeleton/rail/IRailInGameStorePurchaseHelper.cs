using System.Runtime.CompilerServices;

namespace rail;

public interface IRailInGameStorePurchaseHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncShowPaymentWindow(string order_id, string user_data);
}
