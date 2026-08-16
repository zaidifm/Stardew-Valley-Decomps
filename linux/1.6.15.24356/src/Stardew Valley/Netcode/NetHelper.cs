using StardewValley;

namespace Netcode;

internal static class NetHelper
{
	public static void LogWarning(string message)
	{
		Game1.log.Warn(message);
	}

	public static void LogVerbose(string message)
	{
		Game1.log.Verbose(message);
	}
}
