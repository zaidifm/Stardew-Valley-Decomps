using System.Runtime.CompilerServices;

namespace rail;

public class RailVoiceChannelUserSpeakingState
{
	public EnumRailVoiceChannelUserSpeakingLimit speaking_limit;

	public RailID user_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailVoiceChannelUserSpeakingState()
	{
	}
}
