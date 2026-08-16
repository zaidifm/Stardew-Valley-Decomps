using System.Runtime.CompilerServices;

namespace rail;

public class RailCoins
{
	public float total_price;

	public string zone_id;

	public uint coin_class_id;

	public uint quantity;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailCoins()
	{
	}
}
