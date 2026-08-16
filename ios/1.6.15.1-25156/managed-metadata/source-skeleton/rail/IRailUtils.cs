using System.Runtime.CompilerServices;

namespace rail;

public interface IRailUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetTimeCountSinceGameLaunch();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetTimeCountSinceComputerLaunch();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetTimeFromServer();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncGetImageData(string image_path, uint scale_to_width, uint scale_to_height, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void GetErrorString(RailResult result, out string error_string);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult DirtyWordsFilter(string words, bool replace_sensitive, RailDirtyWordsCheckResult check_result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	EnumRailPlatformType GetRailPlatformType();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetLaunchAppParameters(EnumRailLaunchAppType app_type, out string parameter);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetPlatformLanguageCode(out string language_code);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetWarningMessageCallback(RailWarningMessageCallbackFunction callback);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetCountryCodeOfCurrentLoggedInIP(out string country_code);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetMachineGUID(out string machine_guid);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncDirtyWordsFilter(RailDirtyWordsFilterOption option, string user_data);
}
