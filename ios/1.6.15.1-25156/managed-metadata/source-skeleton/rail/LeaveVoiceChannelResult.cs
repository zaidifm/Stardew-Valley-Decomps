using System.Runtime.CompilerServices;

namespace rail;

public class LeaveVoiceChannelResult : EventBase
{
	public RailVoiceChannelID voice_channel_id;

	public EnumRailVoiceLeaveChannelReason reason;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeaveVoiceChannelResult()
	{
	}
}
