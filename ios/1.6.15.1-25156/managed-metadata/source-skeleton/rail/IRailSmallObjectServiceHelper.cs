using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailSmallObjectServiceHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncDownloadObjects(List<uint> indexes, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetObjectContent(uint index, out string content);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryObjectState(string user_data);
}
