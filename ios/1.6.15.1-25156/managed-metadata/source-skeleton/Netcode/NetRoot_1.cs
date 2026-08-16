using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetRoot<T> : NetRef<T>, INetRoot where T : class, INetObject<INetSerializable>
{
	private Dictionary<long, int> connections;

	public NetClock Clock
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool Dirty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetRoot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetRoot(T value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TickTree()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(BinaryReader reader, NetVersion _)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ReadFull(BinaryReader reader, NetVersion _)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static NetRoot<T> Connect(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadConnectionPacket(BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateConnectionPacket(BinaryWriter writer, long? connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disconnect(long connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual NetRoot<T> Clone()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloneInto(NetRef<T> netref)
	{
	}
}
