using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailGetPlayerMetadataResult : EventBase
{
	public List<RailKeyValue> key_values;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailGetPlayerMetadataResult()
	{
	}
}
