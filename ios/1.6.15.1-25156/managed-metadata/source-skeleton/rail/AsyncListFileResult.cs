using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class AsyncListFileResult : EventBase
{
	public List<RailStreamFileInfo> file_list;

	public uint try_list_file_num;

	public uint all_file_num;

	public uint start_index;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncListFileResult()
	{
	}
}
