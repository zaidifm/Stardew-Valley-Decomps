using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class VoiceChannelMemeberChangedEvent : EventBase
{
	public RailVoiceChannelID voice_channel_id;

	public List<RailID> member_ids;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VoiceChannelMemeberChangedEvent()
	{
	}
}
