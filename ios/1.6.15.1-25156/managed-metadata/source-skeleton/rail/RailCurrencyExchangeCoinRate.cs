using System.Runtime.CompilerServices;

namespace rail;

public class RailCurrencyExchangeCoinRate
{
	public string currency;

	public uint to_exchange_coins;

	public float pay_price;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailCurrencyExchangeCoinRate()
	{
	}
}
