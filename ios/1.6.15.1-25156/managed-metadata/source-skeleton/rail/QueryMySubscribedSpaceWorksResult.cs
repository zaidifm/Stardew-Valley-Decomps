using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class QueryMySubscribedSpaceWorksResult
{
	public uint total_available_works;

	public EnumRailSpaceWorkType spacework_type;

	public List<RailSpaceWorkDescriptor> spacework_descriptors;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QueryMySubscribedSpaceWorksResult()
	{
	}
}
