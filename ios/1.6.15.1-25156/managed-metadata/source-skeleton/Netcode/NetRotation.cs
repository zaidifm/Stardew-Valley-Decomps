using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetRotation : NetField<float, NetRotation>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetRotation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetRotation(float value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(float newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override float interpolate(float startValue, float endValue, float factor)
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
