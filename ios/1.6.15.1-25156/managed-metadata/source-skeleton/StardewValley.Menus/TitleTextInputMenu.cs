using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class TitleTextInputMenu : NamingMenu
{
	public ClickableTextureComponent pasteButton;

	public const int region_pasteButton = 105;

	public string context;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TitleTextInputMenu(string title, doneNamingBehavior b, string default_text = "", string context = "", bool filterInput = true)
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
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
