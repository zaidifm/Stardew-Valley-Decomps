using Microsoft.Xna.Framework;

namespace StardewValley.Network.ChestHit;

public sealed class ChestHitTimer
{
	public int Milliseconds;

	public int SavedTime = -1;

	public void Update(GameTime time)
	{
		if (Milliseconds > 0)
		{
			Milliseconds -= (int)time.ElapsedGameTime.TotalMilliseconds;
		}
	}
}
