using System.Runtime.CompilerServices;

namespace rail;

public interface IRailPlayerStats : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailID GetRailID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRequestStats(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetStatValue(string name, out int data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetStatValue(string name, out double data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetStatValue(string name, int data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetStatValue(string name, double data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult UpdateAverageStatValue(string name, double data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncStoreStats(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ResetAllStats();
}
