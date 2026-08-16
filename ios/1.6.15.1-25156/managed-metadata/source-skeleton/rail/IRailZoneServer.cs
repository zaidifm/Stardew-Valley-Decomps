using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailZoneServer : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailZoneID GetZoneID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetZoneNameLanguages(List<string> languages);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetZoneName(string language_filter, out string zone_name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetZoneDescriptionLanguages(List<string> languages);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetZoneDescription(string language_filter, out string zone_description);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGameServerAddresses(List<string> server_addresses);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetZoneMetadatas(List<RailKeyValue> key_values);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetChildrenZoneIDs(List<RailZoneID> zone_ids);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsZoneVisiable();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsZoneJoinable();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetZoneEnableStartTime();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetZoneEnableEndTime();
}
