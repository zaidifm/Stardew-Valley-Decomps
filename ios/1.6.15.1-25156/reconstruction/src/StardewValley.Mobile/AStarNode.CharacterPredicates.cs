using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Characters;
using StardewValley.Locations;

namespace StardewValley.Mobile;

public partial class AStarNode
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsAnimals()
	{
		GameLocation location = _aStarGraph.gameLocation;
		if (location is not AnimalHouse && location is not Farm)
			return false;

		foreach (FarmAnimal animal in location.animals.Values)
		{
			Point standingPixel = animal.StandingPixel;
			if (standingPixel.X / 64 == x && standingPixel.Y / 64 == y)
				return true;
		}

		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsNPC()
	{
		GameLocation location = _aStarGraph.gameLocation;

		if (location is Beach beach && beach.oldMariner != null)
		{
			Point standingPixel = beach.oldMariner.StandingPixel;
			if (standingPixel.X / 64 == x && standingPixel.Y / 64 == y)
				return true;
		}

		foreach (NPC npc in location.characters)
		{
			if (npc is Pet pet && pet.isSleepingOnFarmerBed.Value)
				continue;

			Point standingPixel = npc.StandingPixel;
			if (standingPixel.X / 64 == x && standingPixel.Y / 64 == y)
				return true;
		}

		if (location.currentEvent?.actors != null)
		{
			foreach (NPC actor in location.currentEvent.actors)
			{
				Point standingPixel = actor.StandingPixel;
				if (standingPixel.X / 64 == x && standingPixel.Y / 64 == y)
					return true;
			}
		}

		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC FetchNPC()
	{
		GameLocation location = _aStarGraph.gameLocation;

		if (location is Beach beach && beach.oldMariner != null)
		{
			Point standingPixel = beach.oldMariner.StandingPixel;
			if (standingPixel.X / 64 == x && standingPixel.Y / 64 == y)
				return beach.oldMariner;
		}

		foreach (NPC npc in location.characters)
		{
			Point standingPixel = npc.StandingPixel;
			if (standingPixel.X / 64 == x && standingPixel.Y / 64 == y)
				return npc;
		}

		if (location.currentEvent?.actors != null)
		{
			foreach (NPC actor in location.currentEvent.actors)
			{
				Point standingPixel = actor.StandingPixel;
				if (standingPixel.X / 64 == x && standingPixel.Y / 64 == y)
					return actor;
			}
		}

		return null;
	}
}
