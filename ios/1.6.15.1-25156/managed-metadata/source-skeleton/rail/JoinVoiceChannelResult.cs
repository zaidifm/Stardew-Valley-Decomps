using System.Runtime.CompilerServices;

namespace rail;

public class JoinVoiceChannelResult : EventBase
{
	public RailVoiceChannelID already_joined_channel_id;

	public RailVoiceChannelID voice_channel_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JoinVoiceChannelResult()
	{
	}
}
