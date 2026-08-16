using System.Runtime.CompilerServices;

namespace rail;

public class ShareStorageToSpaceWorkResult : EventBase
{
	public SpaceWorkID space_work_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShareStorageToSpaceWorkResult()
	{
	}
}
