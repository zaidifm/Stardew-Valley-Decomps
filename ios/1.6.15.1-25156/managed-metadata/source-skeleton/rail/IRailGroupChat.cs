using System.Runtime.CompilerServices;

namespace rail;

public interface IRailGroupChat : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetGroupInfo(RailGroupInfo group_info);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult OpenGroupWindow();
}
