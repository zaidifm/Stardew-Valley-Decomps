using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Machines;

public class MachineLight
{
	[ContentSerializer(Optional = true)]
	public float Radius = 1f;

	[ContentSerializer(Optional = true)]
	public string Color;
}
