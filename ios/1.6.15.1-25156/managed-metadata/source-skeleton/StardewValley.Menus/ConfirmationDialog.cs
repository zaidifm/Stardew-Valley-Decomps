using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class ConfirmationDialog : IClickableMenu
{
	public delegate void behavior(Farmer who);

	public const int region_okButton = 101;

	public const int region_cancelButton = 102;

	protected string message;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent cancelButton;

	protected behavior onConfirm;

	protected behavior onCancel;

	private bool active;

	private Rectangle box;

	private bool okHeld;

	private bool cancelHeld;

	private ClickableTextureComponent _selectedButton;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConfirmationDialog(string message, behavior onConfirm, behavior onCancel = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void closeDialog(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void confirm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void cancel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
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
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}
}
