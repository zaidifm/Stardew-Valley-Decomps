using System.Runtime.CompilerServices;

namespace rail;

public class VoiceChannelInviteEvent : EventBase
{
	public string channel_name;

	public RailVoiceChannelID voice_channel_id;

	public string inviter_name;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VoiceChannelInviteEvent()
	{
	}
}
