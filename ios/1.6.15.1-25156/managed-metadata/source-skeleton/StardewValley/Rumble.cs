using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

[InstanceStatics]
public static class Rumble
{
	internal static float rumbleStrength;

	internal static float rumbleTimerMax;

	internal static float rumbleTimerCurrent;

	internal static float rumbleDuringFade;

	internal static float maxRumbleDuringFade;

	internal static bool isRumbling;

	internal static bool fade;

	private static bool RumbleEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void update(float milliseconds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void stopRumbling()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void rumble(float leftPower, float rightPower, float milliseconds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void rumble(float power, float milliseconds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void rumbleAndFade(float power, float milliseconds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool SetVibration(PlayerIndex playerIndex, float leftMotorPower, float rightMotorPower)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
