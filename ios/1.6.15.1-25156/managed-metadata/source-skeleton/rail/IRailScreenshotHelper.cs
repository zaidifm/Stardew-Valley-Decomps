using System.Runtime.CompilerServices;

namespace rail;

public interface IRailScreenshotHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailScreenshot CreateScreenshotWithRawData(byte[] rgb_data, uint len, uint width, uint height);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailScreenshot CreateScreenshotWithLocalImage(string image_file, string thumbnail_file);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void AsyncTakeScreenshot(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void HookScreenshotHotKey(bool hook);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsScreenshotHotKeyHooked();
}
