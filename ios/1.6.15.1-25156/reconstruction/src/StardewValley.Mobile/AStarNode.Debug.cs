using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugTileClear()
	{
		DebugObjectParentSheetIndexOnTile();
		_ = TileClear;
	}
}
