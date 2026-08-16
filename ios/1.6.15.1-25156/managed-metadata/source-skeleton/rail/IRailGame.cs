using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailGame
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailGameID GetGameID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ReportGameContentDamaged(EnumRailGameContentDamageFlag flag);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGameInstallPath(out string app_path);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQuerySubscribeWishPlayState(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetPlayerSelectedLanguageCode(out string language_code);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGameSupportedLanguageCodes(List<string> language_codes);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetGameState(EnumRailGamePlayingState game_state);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGameState(out EnumRailGamePlayingState game_state);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult RegisterGameDefineGamePlayingState(List<RailGameDefineGamePlayingState> game_playing_states);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetGameDefineGamePlayingState(uint game_playing_state);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGameDefineGamePlayingState(out uint game_playing_state);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetBranchBuildNumber(out string build_number);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetCurrentBranchInfo(RailBranchInfo branch_info);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult StartGameTimeCounting(string counting_key);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult EndGameTimeCounting(string counting_key);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailID GetGamePurchasePlayerRailID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetGameEarliestPurchaseTime();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetTimeCountSinceGameActivated();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetTimeCountSinceLastMouseMoved();
}
