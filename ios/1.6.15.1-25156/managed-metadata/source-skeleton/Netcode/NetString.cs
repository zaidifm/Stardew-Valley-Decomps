using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetString : NetField<string, NetString>
{
	public delegate string FilterString(string newValue);

	[CompilerGenerated]
	private FilterString m_FilterStringEvent;

	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public event FilterString FilterStringEvent
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
	public NetString()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetString(string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(string newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(string substr)
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
	[Obsolete("Implicitly casting NetString to string can have unintuitive behavior. Use the Value field instead.")]
	public static implicit operator string(NetString netField)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
