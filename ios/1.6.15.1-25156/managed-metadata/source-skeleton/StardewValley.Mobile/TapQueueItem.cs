using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

public struct TapQueueItem
{
	public int mouseX;

	public int mouseY;

	public int viewportX;

	public int viewportY;

	public int tileX;

	public int tileY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TapQueueItem(int mouseX, int mouseY, int viewportX, int viewportY, int tileX, int tileY)
	{
	}
}
