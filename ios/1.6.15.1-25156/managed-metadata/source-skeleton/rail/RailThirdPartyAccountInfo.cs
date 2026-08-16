using System.Runtime.CompilerServices;

namespace rail;

public class RailThirdPartyAccountInfo
{
	public bool real_name_auth;

	public string ext_str;

	public string open_id;

	public string user_name;

	public string picture_url;

	public string pf_key;

	public string token;

	public string pf;

	public uint token_expire_time;

	public uint error_code;

	public string error_msg;

	public string channel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailThirdPartyAccountInfo()
	{
	}
}
