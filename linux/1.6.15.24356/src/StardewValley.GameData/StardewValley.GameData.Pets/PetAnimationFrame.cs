using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Pets;

public class PetAnimationFrame
{
	public int Frame;

	public int Duration;

	[ContentSerializer(Optional = true)]
	public bool HitGround;

	[ContentSerializer(Optional = true)]
	public bool Jump;

	[ContentSerializer(Optional = true)]
	public string Sound;

	[ContentSerializer(Optional = true)]
	public int SoundRangeFromBorder = -1;

	[ContentSerializer(Optional = true)]
	public int SoundRange = -1;

	[ContentSerializer(Optional = true)]
	public bool SoundIsVoice;
}
