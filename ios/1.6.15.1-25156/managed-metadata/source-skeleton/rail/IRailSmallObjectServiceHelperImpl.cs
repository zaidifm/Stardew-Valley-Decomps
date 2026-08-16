using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class IRailSmallObjectServiceHelperImpl : RailObject, IRailSmallObjectServiceHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailSmallObjectServiceHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailSmallObjectServiceHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncDownloadObjects(List<uint> indexes, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult GetObjectContent(uint index, out string content)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncQueryObjectState(string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
