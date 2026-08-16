using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Network;

public sealed class NetDirection : NetField<int, NetDirection>
{
	public NetPosition Position;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDirection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDirection(int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(int newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool setUpInterpolation(int oldValue, int newValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getInterpolatedDirection()
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
}
