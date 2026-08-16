using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public class GameServer : IGameServer, IBandwidthMonitor
{
	internal List<Server> servers;

	private Dictionary<Action, Func<bool>> pendingGameAvailableActions;

	private readonly HashSet<string> pendingAvailableFarmhands;

	private List<Action> completedPendingActions;

	private List<string> bannedUsers;

	protected bool _wasConnected;

	protected bool _isLocalMultiplayerInitiatedServer;

	public int connectionsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public GameServer(bool local_multiplayer = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isConnectionActive(string connectionId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onConnect(string connectionID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDisconnect(string connectionID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLocalMultiplayerInitiatedServer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateLocalOnlyFlag()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getInviteCode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getUserName(long farmerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float getPingToClient(long farmerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void initialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setPrivacy(ServerPrivacy privacy)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void stopServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveMessages()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sendMessage(long peerId, OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canAcceptIPConnections()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canOfferInvite()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void offerInvite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool anyServerConnected()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool connected()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sendMessage(long peerId, byte messageType, Farmer sourceFarmer, params object[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sendMessages()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void startServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void initializeHost()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sendServerIntroduction(long peer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void kick(long disconnectee)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ban(long farmerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void playerDisconnected(long disconnectee)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isGameAvailable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool whenGameAvailable(Action action, Func<bool> customAvailabilityCheck = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rejectFarmhandRequest(string userId, string connectionId, NetFarmerRoot farmer, Action<OutgoingMessage> sendMessage)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isUserBanned(string userID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool authCheck(string userID, Farmer farmhand)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFarmhandAvailable(Farmer farmhand)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkFarmhandRequest(string userId, string connectionId, NetFarmerRoot farmer, Action<OutgoingMessage> sendMessage, Action approve)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sendAvailableFarmhands(string userId, string connectionId, Action<OutgoingMessage> sendMessage)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetServer<T>() where T : Server
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sendLocation(long peer, GameLocation location, bool force_current = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void warpFarmer(Farmer farmer, short x, short y, string name, bool isStructure)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void processIncomingMessage(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rebroadcastClientMessage(IncomingMessage message, long peerID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setLobbyData(string key, string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool unclaimedFarmhandsExist()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateLobbyData()
	{
	}
}
