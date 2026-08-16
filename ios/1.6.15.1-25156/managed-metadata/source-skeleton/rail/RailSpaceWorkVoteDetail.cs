using System.Runtime.CompilerServices;

namespace rail;

public class RailSpaceWorkVoteDetail
{
	public EnumRailSpaceWorkRateValue vote_value;

	public uint voted_players;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailSpaceWorkVoteDetail()
	{
	}
}
