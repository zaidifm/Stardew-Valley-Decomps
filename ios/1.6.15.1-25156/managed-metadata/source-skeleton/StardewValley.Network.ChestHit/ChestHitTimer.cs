using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Network.ChestHit;

public sealed class ChestHitTimer
{
	public int Milliseconds;

	public int SavedTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChestHitTimer()
	{
	}
}
