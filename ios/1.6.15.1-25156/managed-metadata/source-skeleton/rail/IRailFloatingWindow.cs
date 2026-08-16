using System.Runtime.CompilerServices;

namespace rail;

public interface IRailFloatingWindow
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncShowRailFloatingWindow(EnumRailWindowType window_type, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncCloseRailFloatingWindow(EnumRailWindowType window_type, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetNotifyWindowPosition(EnumRailNotifyWindowType window_type, RailWindowLayout layout);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncShowStoreWindow(ulong id, RailStoreOptions options, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsFloatingWindowAvailable();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncShowDefaultGameStoreWindow(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetNotifyWindowEnable(EnumRailNotifyWindowType window_type, bool enable);
}
