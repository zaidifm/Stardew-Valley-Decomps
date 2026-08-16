using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class VoiceChannelSpeakingUsersChangedEvent : EventBase
{
	public List<RailID> speaking_users;

	public RailVoiceChannelID voice_channel_id;

	public List<RailID> not_speaking_users;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VoiceChannelSpeakingUsersChangedEvent()
	{
	}
}
