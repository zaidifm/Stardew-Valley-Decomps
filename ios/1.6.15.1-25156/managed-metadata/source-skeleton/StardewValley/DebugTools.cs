using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

public static class DebugTools
{
	private static int _mainThreadId;

	private const string CommentFormat = "#----------------------------------------------------------------------------#";

	public static DebugMetricsComponent _metrics;

	private static bool _noFpsCap;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string FormatDivider(string label = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Conditional("VALIDATE_MAIN_THREAD_ENABLED")]
	public static void ValidateIsMainThread(bool req)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsMainThread()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Assert(bool expression, string failureMessage)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GameConstructed(Game game)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GameLoadContent(Game game)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void BeforeGameInitialize(Game game)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void BeforeGameUpdate(Game game, ref GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void BeforeGameDraw(Game game, ref GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CheckInput(Game game)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ApplyNoFpsCap(bool nocap)
	{
	}
}
