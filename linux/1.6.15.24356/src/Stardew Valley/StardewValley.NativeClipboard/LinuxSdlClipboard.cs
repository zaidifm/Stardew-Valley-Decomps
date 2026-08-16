using System;
using System.Runtime.InteropServices;

namespace StardewValley.NativeClipboard;

internal sealed class LinuxSdlClipboard : SdlClipboard
{
	[DllImport("libSDL2-2.0.so.0", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr SDL_GetClipboardText();

	[DllImport("libSDL2-2.0.so.0", CallingConvention = CallingConvention.Cdecl)]
	private static extern int SDL_SetClipboardText(IntPtr text);

	public LinuxSdlClipboard()
	{
		PlatformName = "Linux";
	}

	protected override IntPtr GetTextImpl()
	{
		return SDL_GetClipboardText();
	}

	protected override int SetTextImpl(IntPtr text)
	{
		return SDL_SetClipboardText(text);
	}
}
