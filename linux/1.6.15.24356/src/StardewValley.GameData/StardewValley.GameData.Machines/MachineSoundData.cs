using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Machines;

public class MachineSoundData
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public int Delay;
}
