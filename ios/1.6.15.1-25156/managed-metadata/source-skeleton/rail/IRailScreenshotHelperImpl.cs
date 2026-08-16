using System.Runtime.CompilerServices;

namespace rail;

public class IRailScreenshotHelperImpl : RailObject, IRailScreenshotHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailScreenshotHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailScreenshotHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailScreenshot CreateScreenshotWithRawData(byte[] rgb_data, uint len, uint width, uint height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailScreenshot CreateScreenshotWithLocalImage(string image_file, string thumbnail_file)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AsyncTakeScreenshot(string user_data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HookScreenshotHotKey(bool hook)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsScreenshotHotKeyHooked()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
