using System;
using System.Runtime.InteropServices;
using System.Text;

namespace StardewValley.NativeClipboard;

internal abstract class SdlClipboard
{
	private static SdlClipboard PlatformClipboard;

	protected string PlatformName;

	internal static readonly ClipboardPlatformType Platform;

	static SdlClipboard()
	{
		Platform = GetPlatformType();
		switch (Platform)
		{
		case ClipboardPlatformType.Linux:
			PlatformClipboard = new LinuxSdlClipboard();
			break;
		case ClipboardPlatformType.OSX:
			PlatformClipboard = new OsxSdlClipboard();
			break;
		case ClipboardPlatformType.Windows:
			PlatformClipboard = new WindowsSdlClipboard();
			break;
		default:
			PlatformClipboard = null;
			break;
		}
	}

	public static string GetText()
	{
		if (PlatformClipboard == null)
		{
			return null;
		}
		IntPtr textImpl;
		try
		{
			textImpl = PlatformClipboard.GetTextImpl();
		}
		catch (Exception)
		{
			return null;
		}
		if (textImpl == IntPtr.Zero)
		{
			return null;
		}
		int i;
		for (i = 0; Marshal.ReadByte(textImpl, i) != 0; i++)
		{
		}
		if (i == 0)
		{
			return null;
		}
		byte[] array = new byte[i];
		Marshal.Copy(textImpl, array, 0, i);
		try
		{
			return Encoding.UTF8.GetString(array, 0, i);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static bool SetText(string text)
	{
		if (PlatformClipboard == null)
		{
			return false;
		}
		if (text == null)
		{
			return false;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		IntPtr intPtr = Marshal.AllocHGlobal(bytes.Length + 1);
		try
		{
			Marshal.Copy(bytes, 0, intPtr, bytes.Length);
			Marshal.WriteByte(intPtr, bytes.Length, 0);
			int num;
			try
			{
				num = PlatformClipboard.SetTextImpl(intPtr);
			}
			catch (Exception)
			{
				return false;
			}
			return num == 0;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	private static ClipboardPlatformType GetPlatformType()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
		{
			return ClipboardPlatformType.Linux;
		}
		if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
		{
			return ClipboardPlatformType.OSX;
		}
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			return ClipboardPlatformType.Windows;
		}
		return ClipboardPlatformType.Unknown;
	}

	protected virtual IntPtr GetTextImpl()
	{
		throw new NotImplementedException("GetClipboardText() for " + PlatformName + " is not provided on this platform!");
	}

	protected virtual int SetTextImpl(IntPtr text)
	{
		throw new NotImplementedException("SetClipboardText(...) for " + PlatformName + " is not provided on this platform!");
	}
}
