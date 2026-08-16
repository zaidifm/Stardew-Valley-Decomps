using System.Runtime.CompilerServices;

namespace rail;

public interface IRailApps
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsGameInstalled(RailGameID game_id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQuerySubscribeWishPlayState(RailGameID game_id, string user_data);
}
