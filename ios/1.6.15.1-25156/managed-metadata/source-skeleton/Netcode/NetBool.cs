using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public sealed class NetBool : NetField<bool, NetBool>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetBool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetBool(bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(bool newValue)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Implicitly casting NetBool to bool can have unintuitive behavior. Use the Value field instead.")]
	public static implicit operator bool(NetBool netField)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
