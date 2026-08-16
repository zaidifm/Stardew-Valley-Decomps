using System.Runtime.CompilerServices;

namespace rail;

public class AsyncUpdateMetadataResult : EventBase
{
	public EnumRailSpaceWorkType type;

	public SpaceWorkID id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncUpdateMetadataResult()
	{
	}
}
