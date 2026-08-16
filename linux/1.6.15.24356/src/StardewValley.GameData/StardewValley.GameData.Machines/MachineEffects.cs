using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Machines;

public class MachineEffects
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public List<MachineSoundData> Sounds;

	[ContentSerializer(Optional = true)]
	public int Interval = 100;

	[ContentSerializer(Optional = true)]
	public List<int> Frames;

	[ContentSerializer(Optional = true)]
	public int ShakeDuration = -1;

	[ContentSerializer(Optional = true)]
	public List<TemporaryAnimatedSpriteDefinition> TemporarySprites;
}
