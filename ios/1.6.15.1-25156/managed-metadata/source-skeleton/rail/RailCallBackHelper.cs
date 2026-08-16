using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailCallBackHelper
{
	private static volatile RailCallBackHelper instance_;

	private static readonly object locker_;

	private static Dictionary<RAILEventID, RailEventCallBackHandler> eventHandlers_;

	private static RailEventCallBackFunction delegate_;

	public static RailCallBackHelper Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RailCallBackHelper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterCallback(RAILEventID event_id, RailEventCallBackHandler handler)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterCallback(RAILEventID event_id, RailEventCallBackHandler handler)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterCallback(RAILEventID event_id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterAllCallback()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[MonoPInvokeCallback(typeof(RailEventCallBackFunction))]
	public static void OnRailCallBack(RAILEventID event_id, nint data)
	{
	}
}
