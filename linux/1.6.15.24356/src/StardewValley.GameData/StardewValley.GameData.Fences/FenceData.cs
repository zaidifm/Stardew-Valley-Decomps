using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Fences;

public class FenceData
{
	public int Health;

	[ContentSerializer(Optional = true)]
	public float RepairHealthAdjustmentMinimum;

	[ContentSerializer(Optional = true)]
	public float RepairHealthAdjustmentMaximum;

	public string Texture;

	public string PlacementSound;

	[ContentSerializer(Optional = true)]
	public string RemovalSound;

	[ContentSerializer(Optional = true)]
	public List<string> RemovalToolIds = new List<string>();

	[ContentSerializer(Optional = true)]
	public List<string> RemovalToolTypes = new List<string>();

	[ContentSerializer(Optional = true)]
	public int RemovalDebrisType = 14;

	[ContentSerializer(Optional = true)]
	public Vector2 HeldObjectDrawOffset = new Vector2(0f, -20f);

	[ContentSerializer(Optional = true)]
	public float LeftEndHeldObjectDrawX = -1f;

	[ContentSerializer(Optional = true)]
	public float RightEndHeldObjectDrawX;
}
