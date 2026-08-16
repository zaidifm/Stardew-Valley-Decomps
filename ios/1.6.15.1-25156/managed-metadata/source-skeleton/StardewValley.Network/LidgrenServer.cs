using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Lidgren.Network;

namespace StardewValley.Network;

public class LidgrenServer : HookableServer
{
	public const int defaultPort = 24642;

	public NetServer server;

	private HashSet<NetConnection> introductionsSent;

	protected Bimap<long, NetConnection> peers;

	public override int connectionsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LidgrenServer(IGameServer gameServer)
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
	public static bool IsLocal(string host_name_or_address)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveMessages()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sendVersionInfo(NetIncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void statusChanged(NetIncomingMessage message)
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
	protected virtual void parseDataMessageFromClient(NetIncomingMessage dataMsg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getConnectionId(NetConnection connection)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void sendMessage(long peerId, OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void sendMessage(NetConnection connection, OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void setLobbyData(string key, string value)
	{
	}
}
