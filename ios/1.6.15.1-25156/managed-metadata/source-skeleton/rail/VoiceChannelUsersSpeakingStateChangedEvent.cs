using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class VoiceChannelUsersSpeakingStateChangedEvent : EventBase
{
	public RailVoiceChannelID voice_channel_id;

	public List<RailVoiceChannelUserSpeakingState> users_speaking_state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VoiceChannelUsersSpeakingStateChangedEvent()
	{
	}
}
