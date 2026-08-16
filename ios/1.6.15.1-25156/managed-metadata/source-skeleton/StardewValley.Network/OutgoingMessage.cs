using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public struct OutgoingMessage
{
	private byte messageType;

	private long farmerID;

	private object[] data;

	public byte MessageType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public long FarmerID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Farmer SourceFarmer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ReadOnlyCollection<object> Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OutgoingMessage(byte messageType, long farmerID, params object[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OutgoingMessage(byte messageType, Farmer sourceFarmer, params object[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OutgoingMessage(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(BinaryWriter writer)
	{
	}
}
