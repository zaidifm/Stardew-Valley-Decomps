using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StardewValley.Network;

namespace StardewValley;

public class MultipleMutexRequest
{
	protected int _reportedCount;

	protected List<NetMutex> _acquiredLocks;

	protected List<NetMutex> _mutexList;

	protected Action<MultipleMutexRequest> _onSuccess;

	protected Action<MultipleMutexRequest> _onFailure;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MultipleMutexRequest(List<NetMutex> mutexes, Action<MultipleMutexRequest> success_callback = null, Action<MultipleMutexRequest> failure_callback = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MultipleMutexRequest(NetMutex[] mutexes, Action<MultipleMutexRequest> success_callback = null, Action<MultipleMutexRequest> failure_callback = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _RequestMutexes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _OnLockAcquired(NetMutex mutex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _OnLockFailed(NetMutex mutex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _Finalize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseLocks()
	{
	}
}
