using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace StardewValley.ConsoleAsync;

public class AsyncOperationManager
{
	private static AsyncOperationManager _instance;

	private List<IAsyncOperation> _pendingOps;

	private List<IAsyncOperation> _tempOps;

	private List<IAsyncOperation> _doneOps;

	public static AsyncOperationManager Use
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AsyncOperationManager()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPending(Task task, Action<GenericResult> doneAction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPending(Action workAction, Action<GenericResult> doneAction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPending(IAsyncOperation op)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}
}
