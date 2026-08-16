using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailPurchaseItemsInfo
{
	public string server_id;

	public string zone_id;

	public List<RailPurchaseItem> items;

	public RailThirdPartyAccountPurchaseInfo thirdparty_account_info;

	public string role_id;

	public string metadata;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailPurchaseItemsInfo()
	{
	}
}
