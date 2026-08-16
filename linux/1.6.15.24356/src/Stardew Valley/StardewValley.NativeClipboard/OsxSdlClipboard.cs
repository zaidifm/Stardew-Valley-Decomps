namespace StardewValley.NativeClipboard;

internal sealed class OsxSdlClipboard : SdlClipboard
{
	public OsxSdlClipboard()
	{
		PlatformName = "OSX";
	}
}
