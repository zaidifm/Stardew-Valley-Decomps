using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetDouble : NetField<double, NetDouble>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDouble()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDouble(double value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(double newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override double interpolate(double startValue, double endValue, float factor)
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
