using System.Runtime.CompilerServices;

namespace rail;

public interface IRailVoiceHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailVoiceChannel AsyncCreateVoiceChannel(CreateVoiceChannelOption options, string channel_name, string user_data, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailVoiceChannel OpenVoiceChannel(RailVoiceChannelID voice_channel_id, string channel_name, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	EnumRailVoiceChannelSpeakerState GetSpeakerState();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult MuteSpeaker();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ResumeSpeaker();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetupVoiceCapture(RailVoiceCaptureOption options, RailCaptureVoiceCallback callback);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetupVoiceCapture(RailVoiceCaptureOption options);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult StartVoiceCapturing(uint duration_milliseconds, bool repeat);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult StartVoiceCapturing(uint duration_milliseconds);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult StartVoiceCapturing();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult StopVoiceCapturing();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetCapturedVoiceData(byte[] buffer, uint buffer_length, out uint encoded_bytes_written);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult DecodeVoice(byte[] encoded_buffer, uint encoded_length, byte[] pcm_buffer, uint pcm_buffer_length, out uint pcm_buffer_written);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetVoiceCaptureSpecification(RailVoiceCaptureSpecification spec);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult EnableInGameVoiceSpeaking(bool can_speaking);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetPlayerNicknameInVoiceChannel(string nickname);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetPushToTalkKeyInVoiceChannel(uint push_to_talk_hot_key);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetPushToTalkKeyInVoiceChannel();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ShowOverlayUI(bool show);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetMicroVolume(uint volume);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetSpeakerVolume(uint volume);
}
