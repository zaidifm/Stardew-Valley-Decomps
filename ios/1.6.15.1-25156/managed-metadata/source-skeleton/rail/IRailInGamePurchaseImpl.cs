using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class IRailInGamePurchaseImpl : RailObject, IRailInGamePurchase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailInGamePurchaseImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailInGamePurchaseImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncRequestAllPurchasableProducts(string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncRequestAllProducts(string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult GetProductInfo(uint product_id, RailPurchaseProductInfo product)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncPurchaseProducts(List<RailProductItem> cart_items, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncFinishOrder(string order_id, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncPurchaseProductsToAssets(List<RailProductItem> cart_items, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
