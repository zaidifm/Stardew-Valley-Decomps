using System.Runtime.CompilerServices;

namespace rail;

public class CreateVoiceChannelResult : EventBase
{
	public RailVoiceChannelID voice_channel_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreateVoiceChannelResult()
	{
	}
}
