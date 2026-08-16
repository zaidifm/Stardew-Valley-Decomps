using System.Runtime.CompilerServices;

namespace rail;

public class CreateGameServerOptions
{
	public bool has_password;

	public bool enable_team_voice;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreateGameServerOptions()
	{
	}
}
