using System.Runtime.CompilerServices;

namespace rail;

public class AsyncRenameStreamFileResult : EventBase
{
	public string old_filename;

	public string new_filename;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncRenameStreamFileResult()
	{
	}
}
