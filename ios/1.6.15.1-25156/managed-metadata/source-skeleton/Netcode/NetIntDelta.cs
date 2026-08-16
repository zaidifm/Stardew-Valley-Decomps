using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetIntDelta : NetField<int, NetIntDelta>
{
	private int networkValue;

	public int DirtyThreshold;

	public int? Minimum;

	public int? Maximum;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetIntDelta()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetIntDelta(int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int fixRange(int value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(int newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override int interpolate(int startValue, int endValue, float factor)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ReadFull(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteFull(BinaryWriter writer)
	{
	}
}
