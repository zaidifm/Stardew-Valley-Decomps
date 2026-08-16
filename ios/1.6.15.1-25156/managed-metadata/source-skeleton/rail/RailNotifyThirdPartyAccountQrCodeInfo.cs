using System.Runtime.CompilerServices;

namespace rail;

public class RailNotifyThirdPartyAccountQrCodeInfo : EventBase
{
	public string qr_code_url;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailNotifyThirdPartyAccountQrCodeInfo()
	{
	}
}
