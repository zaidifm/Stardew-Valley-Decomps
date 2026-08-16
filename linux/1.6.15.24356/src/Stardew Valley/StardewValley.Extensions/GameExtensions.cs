using System.Collections.Generic;
using Netcode;
using StardewValley.Network;

namespace StardewValley.Extensions;

public static class GameExtensions
{
	public static void Add(this IDictionary<string, LightSource> dictionary, LightSource lightSource)
	{
		if (lightSource != null)
		{
			if (string.IsNullOrWhiteSpace(lightSource.Id))
			{
				lightSource.Id = $"LightSource_TempId_{Game1.random.Next()}";
				Game1.log.Warn("Light source has no ID; assigning ID '" + lightSource.Id + "'.");
			}
			dictionary[lightSource.Id] = lightSource;
		}
	}

	public static void AddLight(this NetStringDictionary<LightSource, NetRef<LightSource>> dictionary, LightSource lightSource)
	{
		if (lightSource != null)
		{
			if (string.IsNullOrWhiteSpace(lightSource.Id))
			{
				lightSource.Id = $"LightSource_TempId_{Game1.random.Next()}";
				Game1.log.Warn("Light source has no ID; assigning ID '" + lightSource.Id + "'.");
			}
			dictionary[lightSource.Id] = lightSource;
		}
	}
}
