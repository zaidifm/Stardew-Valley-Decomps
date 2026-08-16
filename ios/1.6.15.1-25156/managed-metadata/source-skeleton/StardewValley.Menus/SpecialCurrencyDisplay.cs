using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.BellsAndWhistles;

namespace StardewValley.Menus;

public class SpecialCurrencyDisplay
{
	public class CurrencyDisplayType
	{
		public string key;

		public NetIntDelta field;

		public Action<int> playSound;

		public Action<SpriteBatch, Vector2> drawIcon;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurrencyDisplayType()
		{
		}
	}

	public class CurrencyRenderInfo
	{
		public CurrencyDisplayType currency;

		public MoneyDial moneyDial;

		public float slidePosition;

		public Func<bool> keepOpen;

		public float timeToLive;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurrencyRenderInfo(CurrencyDisplayType currency, Func<bool> keepOpen = null, float timeToLive = 5f)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCurrencyChanged(int oldValue, int newValue)
		{
		}
	}

	public const string currency_walnuts = "walnuts";

	public const string currency_qiGems = "qiGems";

	public const int defaultSeconds = 5;

	public Dictionary<string, CurrencyDisplayType> registeredCurrencyDisplays;

	public readonly List<CurrencyRenderInfo> displayedCurrencies;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Register(string key, NetIntDelta field, Action<int> playSound = null, Action<SpriteBatch, Vector2> drawIcon = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShowCurrency(string currency, Func<bool> keepOpen = null, float timeToLive = 5f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HideCurrency(string currency, bool immediate = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCurrencyChange(NetIntDelta field, int oldValue, int newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Unregister(string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Cleanup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawIcon(string currency, SpriteBatch b, Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlaySound(string currency, int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetUpperLeft(float slidePosition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Draw(SpriteBatch b, Vector2 drawPosition, MoneyDial moneyDial, int displayedValue, Texture2D drawSpriteTexture, Rectangle drawSpriteSourceRect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Draw(SpriteBatch b, Vector2 drawPosition, int displayedValue, Texture2D drawSpriteTexture, Rectangle drawSpriteSourceRect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpecialCurrencyDisplay()
	{
	}
}
