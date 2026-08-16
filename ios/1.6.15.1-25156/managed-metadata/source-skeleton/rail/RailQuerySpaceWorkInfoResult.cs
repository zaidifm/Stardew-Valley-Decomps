using System.Runtime.CompilerServices;

namespace rail;

public class RailQuerySpaceWorkInfoResult
{
	public RailSpaceWorkDescriptor spacework_descriptor;

	public RailResult error_code;

	public SpaceWorkID id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailQuerySpaceWorkInfoResult()
	{
	}
}
