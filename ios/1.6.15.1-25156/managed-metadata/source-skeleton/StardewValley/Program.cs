using System;
using System.Runtime.CompilerServices;
using System.Text;
using StardewValley.Network.Compress;
using StardewValley.SDKs;

namespace StardewValley;

public static class Program
{
	public enum LogType
	{
		Error,
		Disconnect
	}

	public const int build_steam = 0;

	public const int build_gog = 1;

	public const int build_rail = 2;

	public const int build_gdk = 3;

	public static bool GameTesterMode;

	public static bool releaseBuild;

	public static bool enableCheats;

	public const int buildType = 0;

	private static SDKHelper _sdk;

	internal static readonly INetCompression defaultCompression;

	internal static INetCompression netCompression;

	public static Game1 gamePtr;

	public static bool handlingException;

	public static bool hasTriedToPrintLog;

	public static bool successfullyPrintedLog;

	internal static SDKHelper sdk
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLocalAppDataFolder(string subfolder = null, bool createIfMissing = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetAppDataFolder(string subfolder = null, bool createIfMissing = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDebugLogPath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSavesFolder()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string WriteLog(LogType logType, string message, bool append = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AppendDiagnostics(StringBuilder sb)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void handleException(object sender, UnhandledExceptionEventArgs args)
	{
	}
}
