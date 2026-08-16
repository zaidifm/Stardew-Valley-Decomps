using System.Runtime.CompilerServices;
using AVKit;
using Foundation;
using UIKit;

namespace StardewValley.iOS;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
	public const string BundleId = "com.chucklefish.stardewvalley";

	private AVPlayerViewController _controller;

	private static string NSUserActivityTypeBrowsingWeb;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ContinueUserActivity(UIApplication application, NSUserActivity userActivity, UIApplicationRestorationHandler completionHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnResignActivation(UIApplication application)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DidEnterBackground(UIApplication application)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FinishLongRunningTask(nint taskID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WillEnterForeground(UIApplication application)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnActivated(UIApplication application)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WillTerminate(UIApplication application)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckToCopySaveGames()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopySaveGame(string saveGameID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDiskFullDialogue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AppDelegate()
	{
	}
}
