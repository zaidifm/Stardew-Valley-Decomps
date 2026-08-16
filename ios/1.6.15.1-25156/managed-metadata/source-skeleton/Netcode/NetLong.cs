using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetLong : NetField<long, NetLong>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLong()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLong(long value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(long newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override long interpolate(long startValue, long endValue, float factor)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReadDelta(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteDelta(BinaryWriter writer)
	{
	}
}
