using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

public class HairStyleMetadata
{
	public Texture2D texture;

	public int tileX;

	public int tileY;

	public bool usesUniqueLeftSprite;

	public int coveredIndex;

	public bool isBaldStyle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HairStyleMetadata()
	{
	}
}
