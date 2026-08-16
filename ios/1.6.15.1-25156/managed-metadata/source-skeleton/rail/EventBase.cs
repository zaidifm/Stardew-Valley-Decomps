using System.Runtime.CompilerServices;

namespace rail;

public class EventBase
{
	public RailResult result;

	public RailGameID game_id;

	public string user_data;

	public RailID rail_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EventBase()
	{
	}
}
