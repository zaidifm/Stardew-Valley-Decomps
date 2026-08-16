using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Network;

namespace StardewValley;

[Obsolete("All locations allow animals now, so there's no need to check for this interface anymore.")]
public interface IAnimalLocation
{
	NetLongDictionary<FarmAnimal, NetRef<FarmAnimal>> Animals
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool CheckPetAnimal(Vector2 position, Farmer who);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool CheckPetAnimal(Rectangle rect, Farmer who);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool CheckInspectAnimal(Vector2 position, Farmer who);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool CheckInspectAnimal(Rectangle rect, Farmer who);
}
