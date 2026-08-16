using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public interface IGameServer : IBandwidthMonitor
{
	int connectionsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	string getInviteCode();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string getUserName(long farmerId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void setPrivacy(ServerPrivacy privacy);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void stopServer();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void receiveMessages();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void sendMessage(long peerId, OutgoingMessage message);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool canAcceptIPConnections();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool canOfferInvite();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void offerInvite();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool connected();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void sendMessage(long peerId, byte messageType, Farmer sourceFarmer, params object[] data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void sendMessages();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void startServer();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void initializeHost();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void sendServerIntroduction(long peer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void kick(long disconnectee);

	[MethodImpl(MethodImplOptions.NoInlining)]
	string ban(long farmerId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void playerDisconnected(long disconnectee);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool isGameAvailable();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool whenGameAvailable(Action action, Func<bool> customAvailabilityCheck = null);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void checkFarmhandRequest(string userId, string connectionId, NetFarmerRoot farmer, Action<OutgoingMessage> sendMessage, Action approve);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void sendAvailableFarmhands(string userId, string connectionId, Action<OutgoingMessage> sendMessage);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void processIncomingMessage(IncomingMessage message);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void updateLobbyData();

	[MethodImpl(MethodImplOptions.NoInlining)]
	float getPingToClient(long peer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool isUserBanned(string userID);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void onConnect(string connectionID);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void onDisconnect(string connectionID);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsLocalMultiplayerInitiatedServer();
}
