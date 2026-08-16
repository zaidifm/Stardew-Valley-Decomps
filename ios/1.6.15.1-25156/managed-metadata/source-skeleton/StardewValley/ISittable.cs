using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

public interface ISittable
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsSittingHere(Farmer who);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool HasSittingFarmers();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void RemoveSittingFarmer(Farmer farmer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	int GetSittingFarmerCount();

	[MethodImpl(MethodImplOptions.NoInlining)]
	List<Vector2> GetSeatPositions(bool ignore_offsets = false);

	[MethodImpl(MethodImplOptions.NoInlining)]
	Vector2? GetSittingPosition(Farmer who, bool ignore_offsets = false);

	[MethodImpl(MethodImplOptions.NoInlining)]
	Vector2? AddSittingFarmer(Farmer who);

	[MethodImpl(MethodImplOptions.NoInlining)]
	int GetSittingDirection();

	[MethodImpl(MethodImplOptions.NoInlining)]
	Rectangle GetSeatBounds();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsSeatHere(GameLocation location);
}
