using System.Runtime.CompilerServices;

namespace rail;

public interface IRailGlobalStats : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRequestGlobalStats(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGlobalStatValue(string name, out long data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGlobalStatValue(string name, out double data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGlobalStatValueHistory(string name, long[] global_stats_data, uint data_size, out int num_global_stats);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGlobalStatValueHistory(string name, double[] global_stats_data, uint data_size, out int num_global_stats);
}
