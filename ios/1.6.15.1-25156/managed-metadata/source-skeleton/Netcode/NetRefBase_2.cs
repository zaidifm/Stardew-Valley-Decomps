using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Netcode;

public abstract class NetRefBase<T, TSelf> : NetField<T, TSelf> where T : class where TSelf : NetRefBase<T, TSelf>
{
	private enum RefDeltaType : byte
	{
		ChildDelta,
		Reassigned
	}

	public delegate void ConflictResolveEvent(T rejected, T accepted);

	public XmlSerializer Serializer;

	private RefDeltaType deltaType;

	protected NetVersion reassigned;

	[CompilerGenerated]
	private ConflictResolveEvent m_OnConflictResolve;

	public event ConflictResolveEvent OnConflictResolve
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
	public NetRefBase()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetRefBase(T value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SetParent(INetSerializable parent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void CleanImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkReassigned()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(T newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private T createType(Type type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected T ReadType(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void WriteType(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void serialize(BinaryWriter writer, XmlSerializer serializer = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private T deserialize(BinaryReader reader, XmlSerializer serializer = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void ReadValueFull(T value, BinaryReader reader, NetVersion version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void ReadValueDelta(BinaryReader reader, NetVersion version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void WriteValueFull(BinaryWriter writer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void WriteValueDelta(BinaryWriter writer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void writeBaseValue(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private T readBaseValue(BinaryReader reader, NetVersion version)
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
	public override void ReadFull(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteFull(BinaryWriter writer)
	{
	}
}
