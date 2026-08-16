using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public class LoopbackClient : Client
{
	private static uint _nextClientId;

	private readonly string _clientId;

	private LoopbackServer _host;

	private readonly BinaryReader _packetReader;

	private readonly BinaryWriter _packetWriter;

	private readonly MemoryStream _packetStream;

	private readonly List<IncomingMessage> _incoming;

	public string id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool isConnected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LoopbackClient()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getUserID()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override float GetPingToHost()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string getHostUserName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void connectImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void disconnect(bool neatly = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool validateProtocol(string version)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void receiveMessagesImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void sendMessage(OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void serverMessage(OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void serverDisconnect()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void serverKicked()
	{
	}
}
