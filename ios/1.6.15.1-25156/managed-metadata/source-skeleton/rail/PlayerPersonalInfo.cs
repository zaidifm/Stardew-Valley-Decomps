using System.Runtime.CompilerServices;

namespace rail;

public class PlayerPersonalInfo
{
	public RailResult error_code;

	public string avatar_url;

	public uint rail_level;

	public RailID rail_id;

	public string rail_name;

	public string email_address;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerPersonalInfo()
	{
	}
}
