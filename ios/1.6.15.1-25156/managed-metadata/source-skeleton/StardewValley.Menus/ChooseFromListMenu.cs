using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class ChooseFromListMenu : IClickableMenu
{
	public delegate void actionOnChoosingListOption(string s);

	public const int region_backButton = 101;

	public const int region_forwardButton = 102;

	public const int region_okButton = 103;

	public const int region_cancelButton = 104;

	public const int w = 640;

	public const int h = 192;

	public ClickableTextureComponent backButton;

	public ClickableTextureComponent forwardButton;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent cancelButton;

	private List<string> options;

	private int index;

	private actionOnChoosingListOption chooseAction;

	private bool isJukebox;

	private Rectangle nameBox;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChooseFromListMenu(List<string> options, actionOnChoosingListOption chooseAction, bool isJukebox = false, string default_selection = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void FilterJukeboxTracks(List<string> options)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidJukeboxSong(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdatePositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void playSongAction(string s)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}
}
