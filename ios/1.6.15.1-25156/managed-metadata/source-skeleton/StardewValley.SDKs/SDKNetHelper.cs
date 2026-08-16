using System.Runtime.CompilerServices;
using StardewValley.Network;

namespace StardewValley.SDKs;

public interface SDKNetHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetUserID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	Client CreateClient(object lobby);

	[MethodImpl(MethodImplOptions.NoInlining)]
	Client GetRequestedClient();

	[MethodImpl(MethodImplOptions.NoInlining)]
	Server CreateServer(IGameServer gameServer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void AddLobbyUpdateListener(LobbyUpdateListener listener);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void RemoveLobbyUpdateListener(LobbyUpdateListener listener);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void RequestFriendLobbyData();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetLobbyData(object lobby, string key);

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetLobbyOwnerName(object lobby);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SupportsInviteCodes();

	[MethodImpl(MethodImplOptions.NoInlining)]
	object GetLobbyFromInviteCode(string inviteCode);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void ShowInviteDialog(object lobby);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void MutePlayer(string userId, bool mute);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsPlayerMuted(string userId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void ShowProfile(string userId);
}
