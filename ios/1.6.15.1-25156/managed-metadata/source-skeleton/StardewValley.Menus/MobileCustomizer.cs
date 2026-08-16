using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Characters;
using StardewValley.Objects;

namespace StardewValley.Menus;

public class MobileCustomizer : IClickableMenu
{
	public const int region_nameBox = 536;

	public const int region_farmNameBox = 537;

	public const int colorPickerTimerDelay = 100;

	private int currentShirt;

	private int currentHair;

	private int currentAccessory;

	private int colorPickerTimer;

	public MobileColorPicker pantsColorPicker;

	public MobileColorPicker hairColorPicker;

	public MobileColorPicker eyeColorPicker;

	public List<ClickableComponent> labels;

	public ClickableTextureComponent topLeftSelectButton;

	public ClickableTextureComponent topRightSelectButton;

	public ClickableTextureComponent bottomLeftSelectButton;

	public ClickableTextureComponent bottomRightSelectButton;

	public List<ClickableComponent> genderButtons;

	public List<ClickableComponent> appearanceButtons;

	public List<ClickableComponent> colorPickerCCs;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent skipIntroButton;

	public ClickableTextureComponent randomButton;

	public ClickableTextureComponent advancedOptionsButton;

	private TextBox nameBox;

	private TextBox farmnameBox;

	private TextBox favThingBox;

	public ClickableComponent nameBoxCC;

	public ClickableComponent farmnameBoxCC;

	public ClickableComponent favThingBoxCC;

	private bool skipIntro;

	private string hoverText;

	private string hoverTitle;

	private CharacterCustomization.Source source;

	private int numAppearanceButtons;

	private int currentAppearanceButton;

	private bool showNotFinishedMessage;

	private int notFinishedTimer;

	private const int NOT_FINISHED_COUNT = 3000;

	private MobileColorPicker _sliderOpTarget;

	private MobileColorPicker lastHeldColorPicker;

	private Action _sliderAction;

	private readonly Action _recolorEyesAction;

	private readonly Action _recolorPantsAction;

	private readonly Action _recolorHairAction;

	private float widthMod;

	private float heightMod;

	private Rectangle portraitBackBox;

	private Rectangle nameBoxRect;

	private Rectangle faveBoxRect;

	private Rectangle farmBoxRect;

	private Rectangle toolsBackBox;

	private Rectangle okPos;

	private string farmNameSuffix;

	private int farmNameSuffixLength;

	private Vector2 portraitPos;

	private Vector2 dicePos;

	private Vector2 back1Pos;

	private Vector2 forward1Pos;

	private Vector2 catPos;

	private Vector2 dogPos;

	private Vector2 malePos;

	private Vector2 femalePos;

	private Vector2 sliderTextLeftPos;

	private Vector2 sliderTextRightPos;

	private Rectangle topLeftSelectPos;

	private Rectangle topRightSelectPos;

	private Rectangle bottomLeftSelectPos;

	private Rectangle bottomRightSelectPos;

	private string[] buttonLabels;

	private SliderBar selectSlider;

	private SliderBar animalSlider;

	private SliderBar currentSelectedBar;

	private int[] numOptions;

	private int[] oldSliderValue;

	private bool holdingSlider;

	private string nameMessage;

	private string faveMessage;

	private string farmMessage;

	private MobileFarmChooser farmChooser;

	private const float widthModThreshold = 0.95f;

	private int tempPlayerHair;

	private Color tempPlayerHairColor;

	private int tempPlayerShirt;

	private int templPlayerAccessory;

	private Color tempPlayerEyeColor;

	private Color tempPlayerPantsColor;

	private int tempPlayerSkinColor;

	private int animalSliderWidth;

	protected bool _isDyeMenu;

	protected Farmer _displayFarmer;

	protected Clothing _itemToDye;

	private int _tempSkin;

	private int _tempShirt;

	private Texture2D skinColors;

	private Color[] skinColorsData;

	private Color _actualSkinColor;

	private bool isModifyingExistingPet;

	private bool petChanged;

	private Texture2D shirtsTexture;

	private bool haveReceivedLeftClick;

	private int timesRandom;

	protected List<KeyValuePair<string, string>> _petTypesAndBreeds;

	private bool InTutorial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DyeItem(Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farmer GetOrCreateDisplayFarmer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpSkinColorData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color getSkinColor(int which)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpShirts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileCustomizer(int x, int y, int width, int height, CharacterCustomization.Source source = CharacterCustomization.Source.NewGame, Clothing item = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetAllButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool petHasChanges(Pet pet)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void optionButtonClick(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setSliderPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetCurrentShirtIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetCurrentPantIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetCurrentHairIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCurrentHairIndex(int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void selectionClick(int change)
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
	public void ShowAdvancedOptions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected List<KeyValuePair<string, string>> GetPetTypesAndBreeds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetValidClothingIds<TData>(string equippedId, IDictionary<string, TData> data, Func<TData, bool> canChooseDuringCharacterCustomization)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetValidPantsIds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetValidShirtIds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
