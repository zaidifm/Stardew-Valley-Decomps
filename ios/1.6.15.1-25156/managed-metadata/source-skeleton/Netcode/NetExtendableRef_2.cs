using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetExtendableRef<T, TSelf> : NetRefBase<T, TSelf> where T : class, INetObject<INetSerializable> where TSelf : NetExtendableRef<T, TSelf>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetExtendableRef()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetExtendableRef(T value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ForEachChild(Action<INetSerializable> childAction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReadValueFull(T value, BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReadValueDelta(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void clearValueParent(T targetValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setValueParent(T targetValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void targetValueChanged(T oldValue, T newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteValueFull(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteValueDelta(BinaryWriter writer)
	{
	}
}
