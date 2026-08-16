using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public class LoopbackServer : Server
{
	private struct Packet
	{
		public LoopbackClient client;

		public IncomingMessage message;
	}

	private bool _connected;

	private readonly List<Packet> _incoming;

	private readonly BinaryReader _packetReader;

	private readonly BinaryWriter _packetWriter;

	private readonly MemoryStream _packetStream;

	private readonly List<LoopbackClient> _connecting;

	private readonly List<LoopbackClient> _connections;

	private readonly List<LoopbackClient> _disconnections;

	protected readonly Bimap<long, LoopbackClient> peers;

	public override int connectionsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static LoopbackServer Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LoopbackServer(IGameServer gameServer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isConnectionActive(string connectionID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getUserId(long farmerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool hasUserId(string userId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getUserName(long farmerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override float getPingToClient(long farmerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void setPrivacy(ServerPrivacy privacy)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canAcceptIPConnections()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool connected()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void stopServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveMessages()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void kick(long disconnectee)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void playerDisconnected(long disconnectee)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void parseDataMessageFromClient(LoopbackClient peer, IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void sendMessage(long peerId, OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sendMessage(LoopbackClient connection, OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void setLobbyData(string key, string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void clientConnect(LoopbackClient client)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void clientMessage(LoopbackClient client, OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void clientDisconnect(LoopbackClient client)
	{
	}
}
