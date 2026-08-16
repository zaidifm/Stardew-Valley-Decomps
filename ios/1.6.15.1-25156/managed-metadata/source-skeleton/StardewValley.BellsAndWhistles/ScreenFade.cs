using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.BellsAndWhistles;

public class ScreenFade
{
	public bool globalFade;

	public bool fadeIn;

	public bool fadeToBlack;

	public bool nonWarpFade;

	public float fadeToBlackAlpha;

	public float globalFadeSpeed;

	private const float fadeToFudge = 0.1f;

	private Game1.afterFadeFunction afterFade;

	private Func<bool> onFadeToBlackComplete;

	private Action onFadedBackInComplete;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScreenFade(Func<bool> onFadeToBlack, Action onFadeIn)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateFade(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFadeAlpha(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeScreenToBlack(float startAlpha = 0f, bool stopMovement = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeClear(float startAlpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GlobalFadeToBlack(Game1.afterFadeFunction afterFade = null, float fadeSpeed = 0.02f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GlobalFadeToClear(Game1.afterFadeFunction afterFade = null, float fadeSpeed = 0.02f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateGlobalFade()
	{
	}
}
