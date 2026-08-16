using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class ChatTextBox : TextBox
{
	public IClickableMenu parentMenu;

	public List<ChatSnippet> finalText;

	public float currentWidth;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChatTextBox(Texture2D textBoxTexture, Texture2D caretTexture, SpriteFont font, Color textColor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void reset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setText(string text)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RecieveTextInput(string text)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RecieveTextInput(char inputChar)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RecieveCommandInput(char command)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void backspace()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveEmoji(int emoji)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateWidth()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Draw(SpriteBatch spriteBatch, bool drawShadow = true)
	{
	}
}
