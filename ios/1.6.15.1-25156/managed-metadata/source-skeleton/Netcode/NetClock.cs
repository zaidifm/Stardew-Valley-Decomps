using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetClock
{
	public NetVersion netVersion;

	public int LocalId;

	public int InterpolationTicks;

	public List<bool> blanks;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetClock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AddNewPeer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePeer(int id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public uint GetLocalTick()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Tick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
