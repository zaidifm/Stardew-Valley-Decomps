using System.Runtime.CompilerServices;

namespace rail;

public interface IRailHttpSessionHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailHttpSession CreateHttpSession();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailHttpResponse CreateHttpResponse(string http_response_data);
}
