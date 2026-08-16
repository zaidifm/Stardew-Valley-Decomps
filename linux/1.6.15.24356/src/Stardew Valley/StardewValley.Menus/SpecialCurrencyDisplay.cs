using System;
using System.Collections.Generic;
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
	}

	public class CurrencyRenderInfo
	{
		public CurrencyDisplayType currency;

		public MoneyDial moneyDial = new MoneyDial(3)
		{
			onPlaySound = null
		};

		public float slidePosition;

		public Func<bool> keepOpen;

		public float timeToLive;

		public CurrencyRenderInfo(CurrencyDisplayType currency, Func<bool> keepOpen = null, float timeToLive = 5f)
		{
			this.currency = currency;
			this.keepOpen = keepOpen;
			this.timeToLive = timeToLive;
			moneyDial.currentValue = currency.field.TargetValue;
			moneyDial.previousTargetValue = currency.field.Value;
			moneyDial.onPlaySound = currency.playSound;
		}

		public void OnCurrencyChanged(int oldValue, int newValue)
		{
			timeToLive = Math.Max(timeToLive, 5f);
			moneyDial.currentValue = oldValue;
			moneyDial.onPlaySound?.Invoke(newValue - oldValue);
		}
	}

	public const string currency_walnuts = "walnuts";

	public const string currency_qiGems = "qiGems";

	public const int defaultSeconds = 5;

	public Dictionary<string, CurrencyDisplayType> registeredCurrencyDisplays = new Dictionary<string, CurrencyDisplayType>();

	public readonly List<CurrencyRenderInfo> displayedCurrencies = new List<CurrencyRenderInfo>();

	public virtual void Register(string key, NetIntDelta field, Action<int> playSound = null, Action<SpriteBatch, Vector2> drawIcon = null)
	{
		if (registeredCurrencyDisplays.ContainsKey(key))
		{
			Unregister(key);
		}
		playSound = playSound ?? ((Action<int>)delegate(int delta)
		{
			PlaySound(key, delta);
		});
		drawIcon = drawIcon ?? ((Action<SpriteBatch, Vector2>)delegate(SpriteBatch b, Vector2 position)
		{
			DrawIcon(key, b, position);
		});
		registeredCurrencyDisplays[key] = new CurrencyDisplayType
		{
			key = key,
			field = field,
			playSound = playSound,
			drawIcon = drawIcon
		};
		field.fieldChangeVisibleEvent += OnCurrencyChange;
	}

	public virtual void ShowCurrency(string currency, Func<bool> keepOpen = null, float timeToLive = 5f)
	{
		if (currency == null)
		{
			return;
		}
		foreach (CurrencyRenderInfo displayedCurrency in displayedCurrencies)
		{
			if (displayedCurrency.currency.key == currency)
			{
				displayedCurrency.keepOpen = keepOpen ?? displayedCurrency.keepOpen;
				displayedCurrency.timeToLive = Math.Max(displayedCurrency.timeToLive, timeToLive);
				return;
			}
		}
		if (registeredCurrencyDisplays.TryGetValue(currency, out var value))
		{
			displayedCurrencies.Add(new CurrencyRenderInfo(value, keepOpen, timeToLive));
		}
		else
		{
			Game1.log.Warn("Can't show unknown currency type '" + currency + "'.");
		}
	}

	public virtual void HideCurrency(string currency, bool immediate = true)
	{
		if (immediate)
		{
			displayedCurrencies.RemoveAll((CurrencyRenderInfo p) => p.currency.key == currency);
			return;
		}
		foreach (CurrencyRenderInfo displayedCurrency in displayedCurrencies)
		{
			if (displayedCurrency.currency.key == currency)
			{
				displayedCurrency.keepOpen = null;
				displayedCurrency.timeToLive = 0f;
			}
		}
	}

	public virtual void OnCurrencyChange(NetIntDelta field, int oldValue, int newValue)
	{
		if (Game1.gameMode != 3 || oldValue == newValue)
		{
			return;
		}
		foreach (CurrencyRenderInfo displayedCurrency in displayedCurrencies)
		{
			if ((object)displayedCurrency.currency.field == field)
			{
				displayedCurrency.OnCurrencyChanged(oldValue, newValue);
				return;
			}
		}
		foreach (CurrencyDisplayType value in registeredCurrencyDisplays.Values)
		{
			if ((object)value.field == field)
			{
				CurrencyRenderInfo currencyRenderInfo = new CurrencyRenderInfo(value);
				currencyRenderInfo.OnCurrencyChanged(oldValue, newValue);
				displayedCurrencies.Add(currencyRenderInfo);
				return;
			}
		}
		Game1.log.Warn("Can't show currency change for unknown field '" + field.Name + "'.");
	}

	public virtual void Unregister(string key)
	{
		HideCurrency(key);
		if (registeredCurrencyDisplays.TryGetValue(key, out var value))
		{
			value.field.fieldChangeVisibleEvent -= OnCurrencyChange;
			registeredCurrencyDisplays.Remove(key);
		}
	}

	public virtual void Cleanup()
	{
		foreach (string item in new List<string>(registeredCurrencyDisplays.Keys))
		{
			Unregister(item);
		}
	}

	public virtual void DrawIcon(string currency, SpriteBatch b, Vector2 position)
	{
		if (!(currency == "walnuts"))
		{
			if (currency == "qiGems")
			{
				b.Draw(Game1.objectSpriteSheet, position, Game1.getSourceRectForStandardTileSheet(Game1.objectSpriteSheet, 858, 16, 16), Color.White, 0f, Vector2.Zero, 4f, SpriteEffects.None, 0f);
			}
		}
		else
		{
			b.Draw(Game1.objectSpriteSheet, position, Game1.getSourceRectForStandardTileSheet(Game1.objectSpriteSheet, 73, 16, 16), Color.White, 0f, Vector2.Zero, 4f, SpriteEffects.None, 0f);
		}
	}

	public virtual void PlaySound(string currency, int direction)
	{
		if (currency == "walnuts")
		{
			Game1.playSound("goldenWalnut");
		}
	}

	public virtual void Update(GameTime time)
	{
		for (int i = 0; i < displayedCurrencies.Count; i++)
		{
			CurrencyRenderInfo currencyRenderInfo = displayedCurrencies[i];
			bool flag = currencyRenderInfo.keepOpen?.Invoke() ?? false;
			if (!flag)
			{
				currencyRenderInfo.keepOpen = null;
				currencyRenderInfo.timeToLive -= (float)time.ElapsedGameTime.TotalSeconds;
				if (currencyRenderInfo.timeToLive < 0f)
				{
					currencyRenderInfo.timeToLive = 0f;
				}
			}
			float num = (float)time.ElapsedGameTime.TotalSeconds / 0.5f;
			currencyRenderInfo.slidePosition += ((flag || currencyRenderInfo.timeToLive > 0f) ? num : (0f - num));
			currencyRenderInfo.slidePosition = Utility.Clamp(currencyRenderInfo.slidePosition, 0f, 1f);
			if (!flag && currencyRenderInfo.timeToLive <= 0f && currencyRenderInfo.slidePosition <= 0f)
			{
				displayedCurrencies.RemoveAt(i);
				i--;
			}
		}
	}

	public Vector2 GetUpperLeft(float slidePosition)
	{
		return new Vector2(16f, (int)Utility.Lerp(-26f, 0f, slidePosition) * 4);
	}

	public virtual void Draw(SpriteBatch b)
	{
		if (displayedCurrencies.Count == 0)
		{
			return;
		}
		int num = 0;
		foreach (CurrencyRenderInfo displayedCurrency in displayedCurrencies)
		{
			MoneyDial moneyDial = displayedCurrency.moneyDial;
			Vector2 upperLeft = GetUpperLeft(displayedCurrency.slidePosition);
			if (num > 0)
			{
				upperLeft.X += num;
			}
			Rectangle value = new Rectangle(48, 176, 52, 26);
			b.Draw(Game1.mouseCursors2, upperLeft, value, Color.White, 0f, Vector2.Zero, 4f, SpriteEffects.None, 0f);
			num += value.Width * 4;
			int target = displayedCurrency.currency.field.Value;
			if (displayedCurrency.slidePosition < 0.5f)
			{
				target = moneyDial.previousTargetValue;
			}
			moneyDial.draw(b, upperLeft + new Vector2(108f, 40f), target);
			displayedCurrency.currency.drawIcon?.Invoke(b, upperLeft + new Vector2(4f, 6f) * 4f);
		}
	}

	public static void Draw(SpriteBatch b, Vector2 drawPosition, MoneyDial moneyDial, int displayedValue, Texture2D drawSpriteTexture, Rectangle drawSpriteSourceRect)
	{
		if (moneyDial != null && moneyDial.numDigits > 3)
		{
			b.Draw(Game1.mouseCursors_1_6, drawPosition, new Rectangle(42, 0, 57, 26), Color.White, 0f, Vector2.Zero, 4f, SpriteEffects.None, 0f);
		}
		else
		{
			b.Draw(Game1.mouseCursors2, drawPosition, new Rectangle(48, 176, 52, 26), Color.White, 0f, Vector2.Zero, 4f, SpriteEffects.None, 0f);
		}
		moneyDial?.draw(b, drawPosition + new Vector2(108f, 40f), displayedValue);
		b.Draw(drawSpriteTexture, drawPosition + new Vector2(4f, 6f) * 4f, drawSpriteSourceRect, Color.White, 0f, Vector2.Zero, 4f, SpriteEffects.None, 0f);
	}

	public static void Draw(SpriteBatch b, Vector2 drawPosition, int displayedValue, Texture2D drawSpriteTexture, Rectangle drawSpriteSourceRect)
	{
		b.Draw(Game1.mouseCursors2, drawPosition, new Rectangle(48, 176, 52, 26), Color.White, 0f, Vector2.Zero, 4f, SpriteEffects.None, 0f);
		int num = 3;
		int num2 = 0;
		int num3 = (int)Math.Pow(10.0, num - 1);
		bool flag = false;
		for (int i = 0; i < num; i++)
		{
			int num4 = displayedValue / num3 % 10;
			if (num4 > 0 || i == num - 1)
			{
				flag = true;
			}
			if (flag)
			{
				b.Draw(Game1.mouseCursors, drawPosition + new Vector2(108f, 40f) + new Vector2(num2, 0f), new Rectangle(286, 502 - num4 * 8, 5, 8), Color.Maroon, 0f, Vector2.Zero, 4f, SpriteEffects.None, 1f);
			}
			num2 += 24;
			num3 /= 10;
		}
		b.Draw(drawSpriteTexture, drawPosition + new Vector2(4f, 6f) * 4f, drawSpriteSourceRect, Color.White, 0f, Vector2.Zero, 4f, SpriteEffects.None, 0f);
	}
}
