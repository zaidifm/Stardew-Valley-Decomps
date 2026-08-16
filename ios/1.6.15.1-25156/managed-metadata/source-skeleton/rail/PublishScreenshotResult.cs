using System.Runtime.CompilerServices;

namespace rail;

public class PublishScreenshotResult : EventBase
{
	public SpaceWorkID work_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PublishScreenshotResult()
	{
	}
}
