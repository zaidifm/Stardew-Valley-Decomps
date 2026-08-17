using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	public bool bubbleChecked;

	private AStarNode _searchAStarNode;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetBubbleIDRecursively(int bubbleID, bool two = false)
	{
		if (bubbleChecked)
			return false;

		bubbleChecked = true;
		if (this.bubbleID != 0 && !TileClear)
			return false;

		if (two)
			bubbleID2 = bubbleID;
		else
			this.bubbleID = bubbleID;

		_searchAStarNode = _aStarGraph.FetchAStarNode(x, y - 1);
		if (_searchAStarNode != null)
			_searchAStarNode.SetBubbleIDRecursively(bubbleID, two);

		_searchAStarNode = _aStarGraph.FetchAStarNode(x, y + 1);
		if (_searchAStarNode != null)
			_searchAStarNode.SetBubbleIDRecursively(bubbleID, two);

		_searchAStarNode = _aStarGraph.FetchAStarNode(x - 1, y);
		if (_searchAStarNode != null)
			_searchAStarNode.SetBubbleIDRecursively(bubbleID, two);

		_searchAStarNode = _aStarGraph.FetchAStarNode(x + 1, y);
		if (_searchAStarNode != null)
			_searchAStarNode.SetBubbleIDRecursively(bubbleID, two);

		_searchAStarNode = null;
		return true;
	}
}
