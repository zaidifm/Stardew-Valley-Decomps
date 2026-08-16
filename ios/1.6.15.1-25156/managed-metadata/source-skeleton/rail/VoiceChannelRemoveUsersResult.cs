using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class VoiceChannelRemoveUsersResult : EventBase
{
	public List<RailID> success_ids;

	public RailVoiceChannelID voice_channel_id;

	public List<RailID> failed_ids;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VoiceChannelRemoveUsersResult()
	{
	}
}
