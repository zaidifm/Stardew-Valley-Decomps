using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class UserSpaceDownloadProgress : EventBase
{
	public List<RailUserSpaceDownloadProgress> progress;

	public uint total_progress;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserSpaceDownloadProgress()
	{
	}
}
