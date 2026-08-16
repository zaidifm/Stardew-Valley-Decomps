using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Buildings;

namespace StardewValley.Menus;

public class AnimalQueryMenu : IClickableMenu
{
	private enum Button
	{
		None,
		Move,
		Sell,
		AllowReproduction,
		Cancel,
		Tick
	}

	public const int region_okButton = 101;

	public const int region_love = 102;

	public const int region_sellButton = 103;

	public const int region_moveHomeButton = 104;

	public const int region_noButton = 105;

	public const int region_allowReproductionButton = 106;

	public const int region_fullnessHover = 107;

	public const int region_happinessHover = 108;

	public const int region_loveHover = 109;

	public const int region_textBoxCC = 110;

	public const int region_closeButton = 111;

	public int panelWidth;

	public int buttonWidth;

	public int buttonOffset;

	public int yBoxDepth;

	public int xBoxOff;

	public int yBoxPos;

	public int buttonHeight;

	public int dialogueBoxPad;

	public ClickableComponent moveHomeButton;

	public ClickableComponent sellButton;

	public ClickableComponent allowReproductionButton;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent love;

	public ClickableTextureComponent yesButton;

	public ClickableTextureComponent noButton;

	public ClickableTextureComponent tickButton;

	public ClickableTextureComponent cancelButton;

	private Building _selectedBuilding;

	public int mobTileSize;

	public float widthMod;

	public float heightMod;

	private int _drawAtX;

	private int _drawAtY;

	private int _lastTapX;

	private int _lastTapY;

	private bool tickButtonHeld;

	private bool cancelButtonHeld;

	private bool drawTickButton;

	public new static int width;

	public new static int height;

	private FarmAnimal animal;

	private TextBox textBox;

	private TextBoxEvent e;

	public ClickableComponent fullnessHover;

	public ClickableComponent happinessHover;

	public ClickableComponent loveHover;

	public ClickableComponent textBoxCC;

	private double fullnessLevel;

	private double happinessLevel;

	private double loveLevel;

	private bool confirmingSell;

	private bool movingAnimal;

	private string hoverText;

	private string parentName;

	private bool moveHeld;

	private bool sellHeld;

	private bool pregHeld;

	public ClickableTextureComponent closeButton;

	private Button _selectedButton;

	private bool _clickedCancel;

	private int selectedBuildingIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimalQueryMenu(FarmAnimal animal)
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
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void finishedPlacingAnimal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void prepareForAnimalPlacement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void prepareForReturnFromPlacement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
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
	private void OnClickYes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickNo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool overrideSnappyMenuCursorMovementBan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTickButtonBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCancelButtonBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetOKButtonBounds(bool movingAnimal = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickTickButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickCancelButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickSell()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickMove()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickAllowPregnancy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TestToPan(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnhighlightBuildings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HighlightSelectedBuilding()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
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
}
