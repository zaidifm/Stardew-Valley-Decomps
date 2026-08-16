using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public abstract class Client : IBandwidthMonitor
{
	public const int connectionTimeout = 45000;

	public bool hasHandshaked;

	public bool readyToPlay;

	public bool timedOut;

	public bool connectionStarted;

	public string serverName;

	public string connectionMessage;

	public Multiplayer.DisconnectType pendingDisconnect;

	protected BandwidthLogger bandwidthLogger;

	protected long? timeoutTime;

	public List<Farmer> availableFarmhands;

	public Dictionary<long, string> userNames;

	public BandwidthLogger BandwidthLogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void connectImpl();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void disconnect(bool neatly = true);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void receiveMessagesImpl();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void sendMessage(OutgoingMessage message);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract string getUserID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract string getHostUserName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float GetPingToHost()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getUserName(long farmerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void connect()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveMessages()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void processIncomingMessage(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveUserNameUpdate(BinaryReader msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveAvailableFarmhands(BinaryReader msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool PopulatePlatformData(Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void sendPlayerIntroduction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void setUpGame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveServerIntroduction(BinaryReader msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void sendMessages()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void sendMessage(byte which, params object[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Client()
	{
	}
}
