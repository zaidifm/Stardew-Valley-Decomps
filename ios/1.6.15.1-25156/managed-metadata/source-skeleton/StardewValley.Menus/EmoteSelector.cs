using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class EmoteSelector : IClickableMenu
{
	public Rectangle scrollView;

	public List<ClickableTextureComponent> emoteButtons;

	public ClickableTextureComponent okButton;

	public float scrollY;

	public int emoteIndex;

	protected ClickableTextureComponent _selectedEmote;

	protected ClickableTextureComponent _hoveredEmote;

	protected Texture2D emoteTexture;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmoteSelector(int emote_index, string selected_emote = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RepositionElements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RepositionScrollElements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canLeaveMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void cleanupBeforeExit()
	{
	}
}
