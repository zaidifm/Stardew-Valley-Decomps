using System.Runtime.CompilerServices;
using xTile.Layers;
using xTile.Tiles;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		string result = string.Concat("AStarNode -> x:", x, ", y:", y, "\n");
		for (int layerIndex = 0; layerIndex < _aStarGraph.map.Layers.Count; layerIndex++)
		{
			Layer layer = _aStarGraph.map.Layers[layerIndex];
			Tile tile = layer.Tiles[x, y];
			if (tile == null)
			{
				result = string.Concat(result, "layer: ", layerIndex, ", tile:null\n");
				continue;
			}

			result = string.Concat(result, "layer: ", layerIndex, ", tile:", tile.ToString(), "\n");
			foreach (var property in tile.TileIndexProperties)
			{
				result = string.Concat(
					result,
					"TileIndexProperties: ",
					property.Key,
					" = ",
					property.Value.ToString(),
					"\n");
			}

			foreach (var property in tile.Properties)
			{
				result = string.Concat(
					result,
					"Properties: ",
					property.Key,
					" = ",
					property.Value.ToString(),
					"\n");
			}
		}
		return result;
	}
}
