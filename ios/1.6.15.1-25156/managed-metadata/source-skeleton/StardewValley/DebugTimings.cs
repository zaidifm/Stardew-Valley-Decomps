using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

public class DebugTimings
{
	private static readonly Vector2 DrawPos;

	private readonly Stopwatch StopwatchDraw;

	private readonly Stopwatch StopwatchUpdate;

	private double LastTimingDraw;

	private double LastTimingUpdate;

	private float DrawTextWidth;

	private bool Active;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Toggle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartDrawTimer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopDrawTimer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartUpdateTimer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopUpdateTimer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DebugTimings()
	{
	}
}
