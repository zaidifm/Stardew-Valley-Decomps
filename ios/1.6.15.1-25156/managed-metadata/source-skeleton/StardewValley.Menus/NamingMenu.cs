using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class NamingMenu : IClickableMenu
{
	public delegate void doneNamingBehavior(string s);

	public const int region_okButton = 101;

	public const int region_doneNamingButton = 102;

	public const int region_randomButton = 103;

	public const int region_namingBox = 104;

	public ClickableTextureComponent doneNamingButton;

	public ClickableTextureComponent randomButton;

	public TextBox textBox;

	public ClickableComponent textBoxCC;

	public doneNamingBehavior doneNaming;

	public string title;

	public int minLength;

	public bool FilterInput;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NamingMenu(doneNamingBehavior b, string title, string defaultName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void textBoxEnter(TextBox sender)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons button)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
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
}
