using System.Runtime.CompilerServices;

namespace rail;

public class RailProductItem
{
	public uint product_id;

	public uint quantity;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailProductItem()
	{
	}
}
