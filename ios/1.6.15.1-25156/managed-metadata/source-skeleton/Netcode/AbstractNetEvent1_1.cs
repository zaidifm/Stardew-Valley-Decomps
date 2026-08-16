using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public abstract class AbstractNetEvent1<T> : AbstractNetSerializable
{
	public class EventRecording
	{
		public T arg;

		public uint timestamp;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EventRecording(T arg, uint timestamp)
		{
		}
	}

	public delegate void Event(T arg);

	[CompilerGenerated]
	private Event m_onEvent;

	public bool InterpolationWait;

	private List<EventRecording> outgoingEvents;

	private List<EventRecording> incomingEvents;

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
	public bool HasPendingEvent(Predicate<T> match)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fire(T arg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Poll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract T readEventArg(BinaryReader reader, NetVersion version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void writeEventArg(BinaryWriter writer, T arg);

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
	protected override void CleanImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteFull(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AbstractNetEvent1()
	{
	}
}
