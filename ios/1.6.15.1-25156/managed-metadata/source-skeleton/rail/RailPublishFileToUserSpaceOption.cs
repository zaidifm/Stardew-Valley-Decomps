using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailPublishFileToUserSpaceOption
{
	public RailKeyValue key_value;

	public string description;

	public List<string> tags;

	public EnumRailSpaceWorkShareLevel level;

	public string version;

	public string preview_path_filename;

	public EnumRailSpaceWorkType type;

	public string space_work_name;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailPublishFileToUserSpaceOption()
	{
	}
}
