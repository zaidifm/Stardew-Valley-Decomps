using System.Runtime.CompilerServices;

namespace rail;

public class RailThirdPartyAccountLoginOptions
{
	public string code;

	public RailPlayerAccountType account_type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailThirdPartyAccountLoginOptions()
	{
	}
}
