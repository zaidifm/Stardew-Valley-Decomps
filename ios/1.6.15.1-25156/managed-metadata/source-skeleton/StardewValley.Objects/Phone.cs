using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Objects;

[InstanceStatics]
public class Phone : Object
{
	public static List<IPhoneHandler> PhoneHandlers;

	public const int RING_DURATION = 600;

	public const int RING_CYCLE_TIME = 1800;

	public static Random r;

	internal static bool _phoneSoundPlaying;

	public static int ringingTimer;

	public static string whichPhoneCall;

	public static long lastRunTick;

	public static long lastMinutesElapsedTick;

	public static int intervalsToRing;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Phone()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Phone(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HandleIncomingCall(string callId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool minutesElapsed(int minutes)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsRinging()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Ring(string callId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StopRinging()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void HangUp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Action GetIncomingCallAction(string callId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}
}
