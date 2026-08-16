using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class MobileFarmChooser : IClickableMenu
{
	private enum CarouselAlignment
	{
		Left,
		Center,
		Right
	}

	public List<ClickableTextureComponent> farmTypeButtons;

	private float widthMod;

	private float heightMod;

	private int startX;

	private int buttonY;

	private int farmButtonSpacing;

	private int numFarmTypeButtons;

	private int farmButtonWidth;

	private int farmButtonHeight;

	private Rectangle nameBox;

	private Rectangle descBox;

	private Rectangle okPos;

	private Rectangle backPos;

	private string nameString;

	private string descString;

	private Vector2 nameSize;

	private Vector2 descSize;

	private bool isStandaloneScreen;

	private TextBox farmnameBox;

	private Rectangle farmBoxRect;

	private ClickableTextureComponent okButton;

	private ClickableTextureComponent backButton;

	private ClickableTextureComponent coopHelpButton;

	private ClickableTextureComponent coopHelpOkButton;

	private int farmNameSuffixLength;

	private string farmNameSuffix;

	private string farmMessage;

	private string coopHelpString;

	private string noneString;

	private string normalDiffString;

	private string toughDiffString;

	private string hardDiffString;

	private string superDiffString;

	private string sharedWalletString;

	private string separateWalletString;

	private CharacterCustomization.Source source;

	private Rectangle leftSelectButtonPos;

	private Rectangle rightSelectButtonPos;

	private ClickableTextureComponent leftSelectButton;

	private ClickableTextureComponent rightSelectButton;

	public List<ClickableComponent> labels;

	public List<ClickableComponent> leftSelectionButtons;

	public List<ClickableComponent> rightSelectionButtons;

	private ClickableComponent startingCabinsLabel;

	private ClickableComponent cabinLayoutLabel;

	private ClickableComponent difficultyModifierLabel;

	private ClickableComponent walletsLabel;

	public List<ClickableTextureComponent> cabinLayoutButtons;

	public bool showingCoopHelp;

	private bool isHost;

	private bool skipIntro;

	protected Dictionary<int, ClickableComponent> farmTypeButtonLookup;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileFarmChooser(int x, int y, int width, int height, CharacterCustomization.Source source, bool isStandaloneScreen = true, bool skipIntro = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string getNameOfDifficulty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void optionButtonClick(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void selectionClick(string name, int change)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
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
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canLeaveMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
