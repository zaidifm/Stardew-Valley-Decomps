using System.Runtime.CompilerServices;

namespace rail;

public class RailCoinInfo
{
	public string name;

	public string icon_url;

	public string description;

	public RailCurrencyExchangeCoinRate exchange_rate;

	public uint coin_class_id;

	public string metadata;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailCoinInfo()
	{
	}
}
