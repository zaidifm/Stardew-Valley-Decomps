using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailVoiceChannel : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailVoiceChannelID GetVoiceChannelID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetVoiceChannelName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	EnumRailVoiceChannelJoinState GetJoinState();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncJoinVoiceChannel(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncLeaveVoiceChannel(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetUsers(List<RailID> user_list);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncAddUsers(List<RailID> user_list, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRemoveUsers(List<RailID> user_list, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult CloseChannel();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetSelfSpeaking(bool speaking);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsSelfSpeaking();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncSetUsersSpeakingState(List<RailVoiceChannelUserSpeakingState> users_speaking_state, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetUsersSpeakingState(List<RailVoiceChannelUserSpeakingState> users_speaking_state);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetSpeakingUsers(List<RailID> speaking_users, List<RailID> not_speaking_users);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsOwner();
}
