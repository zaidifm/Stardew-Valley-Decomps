using System.Runtime.CompilerServices;

namespace rail;

public class IRailInGameStorePurchaseHelperImpl : RailObject, IRailInGameStorePurchaseHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailInGameStorePurchaseHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailInGameStorePurchaseHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncShowPaymentWindow(string order_id, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
