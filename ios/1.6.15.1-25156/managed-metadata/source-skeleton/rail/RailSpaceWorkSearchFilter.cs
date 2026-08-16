using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailSpaceWorkSearchFilter
{
	public string search_text;

	public bool match_all_required_tags;

	public List<RailKeyValue> required_metadata;

	public bool match_all_required_metadata;

	public List<string> required_tags;

	public List<RailKeyValue> excluded_metadata;

	public List<string> excluded_tags;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailSpaceWorkSearchFilter()
	{
	}
}
