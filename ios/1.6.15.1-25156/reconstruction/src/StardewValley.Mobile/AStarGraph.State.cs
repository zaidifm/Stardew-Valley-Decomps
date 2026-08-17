using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

public partial class AStarGraph
{
	public AStarNode FarmerAStarNode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return FetchAStarNode(
				(int)(Game1.player.position.X / 64f),
				(int)(Game1.player.position.Y / 64f));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(GameLocation gameLocation)
	{
		this.gameLocation = gameLocation;
		map = gameLocation.map;

		int width = map.Layers[0].LayerWidth;
		int height = map.Layers[0].LayerHeight;
		_aStarNodeArray = new AStarNode[width, height];
		for (int x = 0; x < width; x++)
		{
			for (int y = 0; y < height; y++)
				_aStarNodeArray[x, y] = new AStarNode(this, x, y);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AStarNode FetchNeighbourNodeThatIsPassible(int x, int y)
	{
		AStarNode node = FetchAStarNode(x + 1, y);
		if (node != null && node.isTilePassable() && node.TileClear)
			return node;

		node = FetchAStarNode(x - 1, y);
		if (node != null && node.isTilePassable() && node.TileClear)
			return node;

		node = FetchAStarNode(x, y + 1);
		if (node != null && node.isTilePassable() && node.TileClear)
			return node;

		node = FetchAStarNode(x, y - 1);
		if (node != null && node.isTilePassable() && node.TileClear)
			return node;

		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetBubbles(bool one = true, bool two = false)
	{
		if (map == null)
			return;

		int width = map.Layers[0].LayerWidth;
		int height = map.Layers[0].LayerHeight;
		for (int x = 0; x < width; x++)
		{
			for (int y = 0; y < height; y++)
			{
				AStarNode node = _aStarNodeArray[x, y];
				node.bubbleChecked = false;
				if (one)
					node.bubbleID = -1;
				if (two)
					node.bubbleID2 = -1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void mergeBubbleID2IntoBubbleID()
	{
		int width = map.Layers[0].LayerWidth;
		int height = map.Layers[0].LayerHeight;
		for (int x = 0; x < width; x++)
		{
			for (int y = 0; y < height; y++)
			{
				AStarNode node = _aStarNodeArray[x, y];
				if (node.bubbleID2 == 0)
				{
					node.bubbleID = 0;
					node.bubbleID2 = -1;
				}
				node.bubbleChecked = false;
			}
		}
	}
}
