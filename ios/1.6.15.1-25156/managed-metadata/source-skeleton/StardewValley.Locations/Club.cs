using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Locations;

public class Club : GameLocation
{
	public static int timesPlayedCalicoJack;

	public static int timesPlayedSlots;

	private string coinBuffer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Club()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Club(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void checkForMusic(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawOverlays(SpriteBatch b)
	{
	}
}
