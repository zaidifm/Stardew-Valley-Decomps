using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailGameActivityInfo
{
	public ulong activity_id;

	public List<RailKeyValue> metadata_key_values;

	public uint end_time;

	public uint begin_time;

	public string activity_name;

	public string activity_description;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailGameActivityInfo()
	{
	}
}
