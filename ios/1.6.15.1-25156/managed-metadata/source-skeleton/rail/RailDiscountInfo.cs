using System.Runtime.CompilerServices;

namespace rail;

public class RailDiscountInfo
{
	public PurchaseProductDiscountType type;

	public uint start_time;

	public float off;

	public float discount_price;

	public uint end_time;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailDiscountInfo()
	{
	}
}
