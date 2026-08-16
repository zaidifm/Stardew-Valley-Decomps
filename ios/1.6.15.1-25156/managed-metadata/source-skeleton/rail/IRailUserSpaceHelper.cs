using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailUserSpaceHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSubscribeSpaceWorks(List<SpaceWorkID> ids, bool subscribe, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailSpaceWork OpenSpaceWork(SpaceWorkID id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailSpaceWork CreateSpaceWork(EnumRailSpaceWorkType type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, QueryMySubscribedSpaceWorksResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetMySubscribedWorksCount(EnumRailSpaceWorkType type, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRemoveSpaceWork(SpaceWorkID id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncModifyFavoritesWorks(List<SpaceWorkID> ids, EnumRailModifyFavoritesSpaceWorkType modify_flag, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncVoteSpaceWork(SpaceWorkID id, EnumRailSpaceWorkVoteValue vote, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSearchSpaceWork(RailSpaceWorkSearchFilter filter, RailQueryWorkFileOptions options, List<EnumRailSpaceWorkType> types, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRateSpaceWork(SpaceWorkID id, EnumRailSpaceWorkRateValue mark, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQuerySpaceWorksInfo(List<SpaceWorkID> ids, string user_data);
}
