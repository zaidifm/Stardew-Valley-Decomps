using System.Runtime.CompilerServices;

namespace StardewValley.Locations;

public class MineInfo
{
	public int platformContainersLeft;

	public int chestsLeft;

	public int coalCartsLeft;

	public int elevator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MineInfo()
	{
	}
}
