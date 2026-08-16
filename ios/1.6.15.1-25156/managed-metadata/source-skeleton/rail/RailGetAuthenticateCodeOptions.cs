using System.Runtime.CompilerServices;

namespace rail;

public class RailGetAuthenticateCodeOptions
{
	public string redirect_uri;

	public ulong client_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailGetAuthenticateCodeOptions()
	{
	}
}
