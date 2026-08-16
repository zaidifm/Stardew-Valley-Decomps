using System.Runtime.CompilerServices;

namespace rail;

public interface IRailThirdPartyAccountLoginHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncAutoLogin(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncLogin(RailThirdPartyAccountLoginOptions options, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetAccountInfo(RailThirdPartyAccountInfo account_info);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRequestMobileAutoLoginCode(RailRequestMobileAutoLoginCodeOptions options, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRefreshToken(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetChannelID(out string channel_id);
}
