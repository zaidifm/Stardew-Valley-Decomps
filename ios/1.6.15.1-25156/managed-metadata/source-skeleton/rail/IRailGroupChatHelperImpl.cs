using System.Runtime.CompilerServices;

namespace rail;

public class IRailGroupChatHelperImpl : RailObject, IRailGroupChatHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailGroupChatHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailGroupChatHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncQueryGroupsInfo(string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailGroupChat AsyncOpenGroupChat(string group_id, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
