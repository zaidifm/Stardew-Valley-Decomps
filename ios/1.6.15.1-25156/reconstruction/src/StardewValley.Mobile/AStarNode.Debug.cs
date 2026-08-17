using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugTileClear()
	{
		DebugObjectParentSheetIndexOnTile();
		_ = TileClear;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugObjectParentSheetIndexOnTile()
	{
		if (_aStarGraph.gameLocation.objects.TryGetValue(new Vector2(x, y), out Object value))
		{
			Log.It(string.Concat(
				"obj.parentSheetIndex:",
				value.parentSheetIndex?.ToString(),
				", ",
				value.ToString()));
		}
	}
}
