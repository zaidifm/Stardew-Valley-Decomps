using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetEvent0 : AbstractNetSerializable
{
	public delegate void Event();

	[CompilerGenerated]
	private Event m_onEvent;

	public readonly NetInt Counter;

	private int currentCount;

	public event Event onEvent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetEvent0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetEvent0(bool interpolate = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fire()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Poll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ReadFull(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteFull(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ForEachChild(Action<INetSerializable> childAction)
	{
	}
}
