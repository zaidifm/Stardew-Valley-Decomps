using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.FloorsAndPaths;

public class FloorPathData
{
	public string Id;

	public string ItemId;

	public string Texture;

	public Point Corner;

	public string WinterTexture;

	public Point WinterCorner;

	public string PlacementSound;

	[ContentSerializer(Optional = true)]
	public string RemovalSound;

	[ContentSerializer(Optional = true)]
	public int RemovalDebrisType = 14;

	public string FootstepSound;

	[ContentSerializer(Optional = true)]
	public FloorPathConnectType ConnectType;

	[ContentSerializer(Optional = true)]
	public FloorPathShadowType ShadowType;

	[ContentSerializer(Optional = true)]
	public int CornerSize = 4;

	[ContentSerializer(Optional = true)]
	public float FarmSpeedBuff = -1f;
}
