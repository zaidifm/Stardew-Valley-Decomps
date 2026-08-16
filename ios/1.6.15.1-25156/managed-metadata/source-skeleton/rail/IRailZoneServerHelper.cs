using System.Runtime.CompilerServices;

namespace rail;

public interface IRailZoneServerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailZoneID GetPlayerSelectedZoneID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailZoneID GetRootZoneID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailZoneServer OpenZoneServer(RailZoneID zone_id, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSwitchPlayerSelectedZone(RailZoneID zone_id);
}
