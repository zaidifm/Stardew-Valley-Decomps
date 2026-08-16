using System.Runtime.CompilerServices;
using Lidgren.Network;

namespace StardewValley.Network;

public class LidgrenClient : HookableClient
{
	public string address;

	public NetClient client;

	private bool serverDiscovered;

	private int maxRetryAttempts;

	private int retryMs;

	private double lastAttemptMs;

	private int retryAttempts;

	private float lastLatencyMs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LidgrenClient(string address)
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
	private void attemptConnection()
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
	private void readLatency(NetIncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void receiveHandshake(NetIncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void statusChanged(NetIncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void clientRemotelyDisconnected(NetConnectionStatus status, string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void sendMessageImpl(OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void sendMessage(OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void parseDataMessageFromServer(NetIncomingMessage dataMsg)
	{
	}
}
