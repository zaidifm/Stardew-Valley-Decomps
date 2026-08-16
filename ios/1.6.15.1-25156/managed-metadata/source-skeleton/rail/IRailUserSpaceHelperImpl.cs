using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class IRailUserSpaceHelperImpl : RailObject, IRailUserSpaceHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailUserSpaceHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailUserSpaceHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncGetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, RailQueryWorkFileOptions options)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncGetMyFavoritesWorks(uint offset, uint max_works, EnumRailSpaceWorkType type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, RailQueryWorkFileOptions options)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncQuerySpaceWorks(RailSpaceWorkFilter filter, uint offset, uint max_works)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncSubscribeSpaceWorks(List<SpaceWorkID> ids, bool subscribe, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailSpaceWork OpenSpaceWork(SpaceWorkID id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailSpaceWork CreateSpaceWork(EnumRailSpaceWorkType type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult GetMySubscribedWorks(uint offset, uint max_works, EnumRailSpaceWorkType type, QueryMySubscribedSpaceWorksResult result)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual uint GetMySubscribedWorksCount(EnumRailSpaceWorkType type, out RailResult result)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncRemoveSpaceWork(SpaceWorkID id, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncModifyFavoritesWorks(List<SpaceWorkID> ids, EnumRailModifyFavoritesSpaceWorkType modify_flag, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncVoteSpaceWork(SpaceWorkID id, EnumRailSpaceWorkVoteValue vote, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncSearchSpaceWork(RailSpaceWorkSearchFilter filter, RailQueryWorkFileOptions options, List<EnumRailSpaceWorkType> types, uint offset, uint max_works, EnumRailSpaceWorkOrderBy order_by, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncRateSpaceWork(SpaceWorkID id, EnumRailSpaceWorkRateValue mark, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncQuerySpaceWorksInfo(List<SpaceWorkID> ids, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
