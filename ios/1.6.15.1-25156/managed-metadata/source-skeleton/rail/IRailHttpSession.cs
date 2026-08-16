using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailHttpSession : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetRequestMethod(RailHttpSessionMethod method);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetParameters(List<RailKeyValue> parameters);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetPostBodyContent(string body_content);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetRequestTimeOut(uint timeout_secs);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetRequestHeaders(List<string> headers);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSendRequest(string url, string user_data);
}
