using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class EmojiMenu : IClickableMenu
{
	public const int EMOJI_SIZE = 9;

	private Texture2D chatBoxTexture;

	private Texture2D emojiTexture;

	private ChatBox chatBox;

	private List<ClickableComponent> emojiSelectionButtons;

	private int pageStartIndex;

	private ClickableComponent upArrow;

	private ClickableComponent downArrow;

	private ClickableComponent sendArrow;

	public static int totalEmojis;

	public static int totalVisibleEmojis;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmojiMenu(ChatBox chatBox, Texture2D emojiTexture, Texture2D chatBoxTexture)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void leftClick(int x, int y, ChatBox cb)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void upArrowPressed(int amountToScroll = 30)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void downArrowPressed(int amountToScroll = 30)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveScrollWheelAction(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
