using System.Runtime.CompilerServices;

namespace rail;

public interface IRailStatisticHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailPlayerStats CreatePlayerStats(RailID player);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailGlobalStats GetGlobalStats();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetNumberOfPlayer(string user_data);
}
