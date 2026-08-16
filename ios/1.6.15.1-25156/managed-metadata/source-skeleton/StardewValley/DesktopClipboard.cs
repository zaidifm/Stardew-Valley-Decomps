using System.Runtime.CompilerServices;

namespace StardewValley;

public class DesktopClipboard
{
	public const bool IsAvailable = false;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetText(ref string output)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SetText(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesktopClipboard()
	{
	}
}
