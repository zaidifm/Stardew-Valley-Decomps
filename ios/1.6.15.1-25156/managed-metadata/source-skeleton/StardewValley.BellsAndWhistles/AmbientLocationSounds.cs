using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.BellsAndWhistles;

[InstanceStatics]
public class AmbientLocationSounds
{
	public const int sound_babblingBrook = 0;

	public const int sound_cracklingFire = 1;

	public const int sound_engine = 2;

	public const int sound_cricket = 3;

	public const int sound_waterfall = 4;

	public const int sound_waterfall_big = 5;

	public const int numberOfSounds = 6;

	public const float doNotPlay = 9999999f;

	internal static Dictionary<Vector2, int> sounds;

	internal static int updateTimer;

	internal static int farthestSoundDistance;

	internal static float[] shortestDistanceForCue;

	internal static ICue babblingBrook;

	internal static ICue cracklingFire;

	internal static ICue engine;

	internal static ICue cricket;

	internal static ICue waterfall;

	internal static ICue waterfallBig;

	internal static float volumeOverrideForLocChange;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitShared()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void changeSpecificVariable(string variableName, float value, int whichSound)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addSound(Vector2 tileLocation, int whichSound)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeSound(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void onLocationLeave()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AmbientLocationSounds()
	{
	}
}
