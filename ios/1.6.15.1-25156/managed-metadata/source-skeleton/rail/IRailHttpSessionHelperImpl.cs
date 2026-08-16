using System.Runtime.CompilerServices;

namespace rail;

public class IRailHttpSessionHelperImpl : RailObject, IRailHttpSessionHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailHttpSessionHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailHttpSessionHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailHttpSession CreateHttpSession()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailHttpResponse CreateHttpResponse(string http_response_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
