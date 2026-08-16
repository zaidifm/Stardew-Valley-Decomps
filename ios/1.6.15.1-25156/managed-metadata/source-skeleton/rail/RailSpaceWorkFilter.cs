using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailSpaceWorkFilter
{
	public List<EnumRailWorkFileClass> classes;

	public List<EnumRailSpaceWorkType> type;

	public List<RailID> collector_list;

	public List<RailID> subscriber_list;

	public List<RailID> creator_list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailSpaceWorkFilter()
	{
	}
}
