using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetInt : NetField<int, NetInt>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetInt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetInt(int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(int newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new bool Equals(NetInt other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(int other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	[Obsolete("Implicitly casting NetInt to int can have unintuitive behavior. Use the Value field instead.")]
	public static implicit operator int(NetInt netField)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
