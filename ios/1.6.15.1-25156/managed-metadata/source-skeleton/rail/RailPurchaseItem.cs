using System.Runtime.CompilerServices;

namespace rail;

public class RailPurchaseItem
{
	public string product_id;

	public uint quantity;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailPurchaseItem()
	{
	}
}
