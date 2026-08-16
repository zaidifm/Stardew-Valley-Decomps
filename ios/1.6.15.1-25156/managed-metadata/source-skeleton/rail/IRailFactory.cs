using System.Runtime.CompilerServices;

namespace rail;

public interface IRailFactory
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailPlayer RailPlayer();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailUsersHelper RailUsersHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailFriends RailFriends();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailFloatingWindow RailFloatingWindow();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailBrowserHelper RailBrowserHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailInGamePurchase RailInGamePurchase();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailInGameCoin RailInGameCoin();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailRoomHelper RailRoomHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailGameServerHelper RailGameServerHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailStorageHelper RailStorageHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailUserSpaceHelper RailUserSpaceHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailStatisticHelper RailStatisticHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailLeaderboardHelper RailLeaderboardHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailAchievementHelper RailAchievementHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailNetwork RailNetworkHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailApps RailApps();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailGame RailGame();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailUtils RailUtils();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailAssetsHelper RailAssetsHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailDlcHelper RailDlcHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailScreenshotHelper RailScreenshotHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailVoiceHelper RailVoiceHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailSystemHelper RailSystemHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailTextInputHelper RailTextInputHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailIMEHelper RailIMETextInputHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailHttpSessionHelper RailHttpSessionHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailSmallObjectServiceHelper RailSmallObjectServiceHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailZoneServerHelper RailZoneServerHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailGroupChatHelper RailGroupChatHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailInGameStorePurchaseHelper RailInGameStorePurchaseHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailInGameActivityHelper RailInGameActivityHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailAntiAddictionHelper RailAntiAddictionHelper();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailThirdPartyAccountLoginHelper RailThirdPartyAccountLoginHelper();
}
