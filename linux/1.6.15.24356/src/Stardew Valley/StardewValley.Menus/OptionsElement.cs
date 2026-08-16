using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.BellsAndWhistles;

namespace StardewValley.Menus;

public class OptionsElement : IScreenReadable
{
	public enum Style
	{
		Default,
		OptionLabel
	}

	public const int defaultX = 8;

	public const int defaultY = 4;

	public const int defaultPixelWidth = 9;

	public Rectangle bounds;

	public string label;

	public int whichOption;

	public bool greyedOut;

	public Vector2 labelOffset = Vector2.Zero;

	public Style style;

	public string ScreenReaderText { get; set; }

	public string ScreenReaderDescription { get; set; }

	public bool ScreenReaderIgnore { get; set; }

	public OptionsElement(string label)
	{
		this.label = label;
		bounds = new Rectangle(32, 16, 36, 36);
		whichOption = -1;
	}

	public OptionsElement(string label, int x, int y, int width, int height, int whichOption = -1)
	{
		if (x == -1)
		{
			x = 32;
		}
		if (y == -1)
		{
			y = 16;
		}
		bounds = new Rectangle(x, y, width, height);
		this.label = label;
		this.whichOption = whichOption;
	}

	public OptionsElement(string label, Rectangle bounds, int whichOption)
	{
		this.whichOption = whichOption;
		this.label = label;
		this.bounds = bounds;
	}

	public virtual void receiveLeftClick(int x, int y)
	{
	}

	public virtual void leftClickHeld(int x, int y)
	{
	}

	public virtual void leftClickReleased(int x, int y)
	{
	}

	public virtual void receiveKeyPress(Keys key)
	{
	}

	public virtual void draw(SpriteBatch b, int slotX, int slotY, IClickableMenu context = null)
	{
		if (style == Style.OptionLabel)
		{
			Utility.drawTextWithShadow(b, label, Game1.dialogueFont, new Vector2(slotX + bounds.X + (int)labelOffset.X, slotY + bounds.Y + (int)labelOffset.Y + 12), greyedOut ? (Game1.textColor * 0.33f) : Game1.textColor, 1f, 0.1f);
			return;
		}
		if (whichOption == -1)
		{
			SpriteText.drawString(b, label, slotX + bounds.X + (int)labelOffset.X, slotY + bounds.Y + (int)labelOffset.Y + 56 - SpriteText.getHeightOfString(label), 999, -1, 999, 1f, 0.1f);
			return;
		}
		int num = slotX + bounds.X + bounds.Width + 8 + (int)labelOffset.X;
		int num2 = slotY + bounds.Y + (int)labelOffset.Y;
		string text = label;
		SpriteFont spriteFont = Game1.dialogueFont;
		if (context != null)
		{
			int num3 = context.width - 64;
			int xPositionOnScreen = context.xPositionOnScreen;
			if (spriteFont.MeasureString(label).X + (float)num > (float)(num3 + xPositionOnScreen))
			{
				int width = num3 + xPositionOnScreen - num;
				spriteFont = Game1.smallFont;
				text = Game1.parseText(label, spriteFont, width);
				num2 -= (int)((spriteFont.MeasureString(text).Y - spriteFont.MeasureString("T").Y) / 2f);
			}
		}
		Utility.drawTextWithShadow(b, text, spriteFont, new Vector2(num, num2), greyedOut ? (Game1.textColor * 0.33f) : Game1.textColor, 1f, 0.1f);
	}
}
