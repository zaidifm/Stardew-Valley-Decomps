using System.Runtime.CompilerServices;

namespace rail;

public class RailGetAuthenticateCodeResult : EventBase
{
	public uint code_expire_time;

	public string code;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailGetAuthenticateCodeResult()
	{
	}
}
