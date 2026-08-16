using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class ButtonTutorialMenu : IClickableMenu
{
	public const int move_run_check = 0;

	public const int useTool_menu = 1;

	public const float movementSpeed = 0.2f;

	public new const int width = 42;

	public new const int height = 109;

	private int timerToclose;

	private int which;

	internal static int current;

	private int myID;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ButtonTutorialMenu(int which)
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
