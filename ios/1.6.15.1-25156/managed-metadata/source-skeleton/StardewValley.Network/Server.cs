using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public abstract class Server : IBandwidthMonitor
{
	internal IGameServer gameServer;

	protected BandwidthLogger bandwidthLogger;

	public abstract int connectionsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	public bool LogBandwidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public BandwidthLogger BandwidthLogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Server(IGameServer gameServer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void initialize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void setPrivacy(ServerPrivacy privacy);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void stopServer();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void receiveMessages();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void sendMessage(long peerId, OutgoingMessage message);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract bool connected();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canAcceptIPConnections()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canOfferInvite()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void offerInvite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getInviteCode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool PopulatePlatformData(Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getUserId(long farmerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool hasUserId(string userId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float getPingToClient(long farmerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isConnectionActive(string connectionId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onConnect(string connectionId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDisconnect(string connectionId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract string getUserName(long farmerId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void setLobbyData(string key, string value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void kick(long disconnectee)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playerDisconnected(long disconnectee)
	{
	}
}
