using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class NumberSelectionMenu : IClickableMenu
{
	public delegate void behaviorOnNumberSelect(int number, int price, Farmer who);

	public const int region_leftButton = 101;

	public const int region_rightButton = 102;

	public const int region_okButton = 103;

	public const int region_cancelButton = 104;

	private string message;

	protected int price;

	protected int minValue;

	protected int maxValue;

	protected int currentValue;

	protected int priceShake;

	protected int heldTimer;

	private behaviorOnNumberSelect behaviorFunction;

	protected TextBox numberSelectedBox;

	public ClickableTextureComponent leftButton;

	public ClickableTextureComponent rightButton;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent cancelButton;

	private int buttonY;

	private int buttonY2;

	private Vector2 textSize;

	private SliderBar quantitySlider;

	private bool quantitySliderHeld;

	private ClickableTextureComponent _selectedButton;

	protected virtual Vector2 centerPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NumberSelectionMenu(string message, behaviorOnNumberSelect behaviorOnSelection, int price = -1, int minValue = 0, int maxValue = 99, int defaultNumber = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickLeftArrowButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickRightArrowButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gamePadButtonHeld(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickOKButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
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
}
