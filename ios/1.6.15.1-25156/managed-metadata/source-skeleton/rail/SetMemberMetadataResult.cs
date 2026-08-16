using System.Runtime.CompilerServices;

namespace rail;

public class SetMemberMetadataResult : EventBase
{
	public ulong room_id;

	public RailID member_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SetMemberMetadataResult()
	{
	}
}
