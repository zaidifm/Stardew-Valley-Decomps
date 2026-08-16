using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetByte : NetField<byte, NetByte>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetByte()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetByte(byte value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(byte newValue)
	{
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
