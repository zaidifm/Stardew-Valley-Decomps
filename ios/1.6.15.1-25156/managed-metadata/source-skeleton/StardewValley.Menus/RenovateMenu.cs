using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class RenovateMenu : IClickableMenu
{
	public const int region_okButton = 101;

	public const int region_randomButton = 103;

	public static int menuHeight;

	public static int menuWidth;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent hovered;

	private bool freeze;

	protected HouseRenovation _renovation;

	protected string _oldLocation;

	protected Point _oldPosition;

	protected int _selectedIndex;

	protected int _animatingIndex;

	protected int _buildAnimationTimer;

	protected int _buildAnimationCount;

	private int _lastTapX;

	private int _lastTapY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RenovateMenu(HouseRenovation renovation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldClampGamePadCursor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetupForReturn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FinalizeReturn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetupForRenovationPlacement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AnimateRenovation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CompleteRenovation(int selected_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool overrideSnappyMenuCursorMovementBan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons button)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TestToPan(int x, int y)
	{
	}
}
