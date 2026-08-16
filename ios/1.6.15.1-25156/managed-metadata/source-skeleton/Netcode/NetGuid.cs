using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetGuid : NetField<Guid, NetGuid>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetGuid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetGuid(Guid value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(Guid newValue)
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
