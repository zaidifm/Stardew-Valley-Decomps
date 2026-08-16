using System.Runtime.CompilerServices;

namespace rail;

public class VoiceChannelPushToTalkKeyChangedEvent : EventBase
{
	public uint push_to_talk_hot_key;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VoiceChannelPushToTalkKeyChangedEvent()
	{
	}
}
