using System.Runtime.CompilerServices;

namespace rail;

public class AsyncDeleteStreamFileResult : EventBase
{
	public string filename;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncDeleteStreamFileResult()
	{
	}
}
