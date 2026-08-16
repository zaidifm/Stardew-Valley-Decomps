using System.Runtime.CompilerServices;

namespace rail;

public interface IRailGroupChatHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryGroupsInfo(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailGroupChat AsyncOpenGroupChat(string group_id, string user_data);
}
