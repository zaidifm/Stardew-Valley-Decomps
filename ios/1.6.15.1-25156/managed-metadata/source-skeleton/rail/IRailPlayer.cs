using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailPlayer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool AlreadyLoggedIn();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailID GetRailID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetPlayerDataPath(out string path);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncAcquireSessionTicket(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncStartSessionWithPlayer(RailSessionTicket player_ticket, RailID player_rail_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void TerminateSessionOfPlayer(RailID player_rail_id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void AbandonSessionTicket(RailSessionTicket session_ticket);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetPlayerName(out string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	EnumRailPlayerOwnershipType GetPlayerOwnershipType();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetGamePurchaseKey(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsGameRevenueLimited();

	[MethodImpl(MethodImplOptions.NoInlining)]
	float GetRateOfGameRevenue();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryPlayerBannedStatus(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetAuthenticateURL(RailGetAuthenticateURLOptions options, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetPlayerMetadata(List<string> keys, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetEncryptedGameTicket(string set_metadata, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailPlayerAccountType GetPlayerAccountType();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetAuthenticateCode(RailGetAuthenticateCodeOptions options, string user_data);
}
