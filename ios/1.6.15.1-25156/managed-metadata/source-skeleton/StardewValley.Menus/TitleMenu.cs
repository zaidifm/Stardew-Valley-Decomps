using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class TitleMenu : IClickableMenu, IDisposable
{
	[NonInstancedStatic]
	public static bool SkipSplashScreens;

	internal const string secretMpLeaf = "UUDDLRLR";

	internal const string mpLeafLookup = "DURLL";

	internal int secretMpLeafIdx;

	internal bool triggeredLeafMp;

	private float leafFlashAlpha;

	private float widthMod;

	private float heightMod;

	private int logoPixelZoom;

	private int logoYPosition;

	public static bool PromptedEmergencySave;

	public const int region_muteMusic = 81111;

	public const int region_windowedButton = 81112;

	public const int region_aboutButton = 81113;

	public const int region_backButton = 81114;

	public const int region_newButton = 81115;

	public const int region_loadButton = 81116;

	public const int region_coopButton = 81119;

	public const int region_exitButton = 81117;

	public const int region_languagesButton = 81118;

	public const int fadeFromWhiteDuration = 1000;

	public const int viewportFinalPosition = -1000;

	public const int logoSwipeDuration = 1000;

	public static int numberOfButtons;

	public const int spaceBetweenButtons = 8;

	public const float bigCloudDX = 0.1f;

	public const float mediumCloudDX = 0.2f;

	public const float smallCloudDX = 0.3f;

	public const float bgmountainsParallaxSpeed = 0.66f;

	public const float mountainsParallaxSpeed = 1f;

	public const float foregroundJungleParallaxSpeed = 2f;

	public const float cloudsParallaxSpeed = 0.5f;

	public static int pixelZoom;

	public const string titleButtonsTextureName = "Minigames\\TitleButtons";

	[CompilerGenerated]
	private static Action m_OnCreatedNewCharacter;

	public LocalizedContentManager menuContent;

	public Texture2D cloudsTexture;

	public Texture2D titleButtonsTexture;

	public bool specialSurprised;

	public float specialSurprisedTimeStamp;

	private Texture2D amuzioTexture;

	private List<float> bigClouds;

	private List<float> smallClouds;

	private TemporaryAnimatedSpriteList tempSprites;

	private TemporaryAnimatedSpriteList behindSignTempSprites;

	public List<ClickableTextureComponent> buttons;

	public ClickableTextureComponent backButton;

	public ClickableTextureComponent muteMusicButton;

	public ClickableTextureComponent aboutButton;

	public ClickableTextureComponent languageButton;

	public ClickableTextureComponent windowedButton;

	public ClickableComponent skipButton;

	protected bool _movedCursor;

	public TemporaryAnimatedSpriteList birds;

	private Rectangle eRect;

	private Rectangle screwRect;

	private Rectangle cornerRect;

	private Rectangle r_hole_rect;

	private Rectangle r_hole_rect2;

	private List<Rectangle> leafRects;

	[InstancedStatic]
	internal static IClickableMenu _subMenu;

	public readonly StartupPreferences startupPreferences;

	public int globalXOffset;

	public float viewportY;

	public float viewportDY;

	public float logoSwipeTimer;

	public float globalCloudAlpha;

	public float cornerClickEndTimer;

	public float cornerClickParrotTimer;

	public float cornerClickSoundEffectTimer;

	private bool? hasRoomAnotherFarm;

	public int fadeFromWhiteTimer;

	public int pauseBeforeViewportRiseTimer;

	public int buttonsToShow;

	public int showButtonsTimer;

	public int logoFadeTimer;

	public int logoSurprisedTimer;

	public int clicksOnE;

	public int clicksOnLeaf;

	public int clicksOnScrew;

	public int cornerClicks;

	public int buttonsDX;

	public bool titleInPosition;

	public bool isTransitioningButtons;

	public bool shades;

	public bool cornerPhaseHolding;

	public bool showCornerClickEasterEgg;

	public bool transitioningCharacterCreationMenu;

	private int amuzioTimer;

	[NonInstancedStatic]
	private static int windowNumber;

	public string startupMessage;

	public Color startupMessageColor;

	public string debugSaveFileToTry;

	private int bCount;

	private string whichSubMenu;

	private int quitTimer;

	private bool transitioningFromLoadScreen;

	[NonInstancedStatic]
	public static int ticksUntilLanguageLoad;

	private bool disposedValue;

	public static IClickableMenu subMenu
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool HasActiveUser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static event Action OnCreatedNewCharacter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReturnToMainTitleScreen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceSubmenu(IClickableMenu menu)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TitleMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool checkForAndLoadEmergencySave()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool alternativeTitleGraphic()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void applyPreferences()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLanguageChange(LocalizedContentManager.LanguageCode code)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void skipToTitleButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpIcons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void populateLeafRects()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateSecretMpLeaf(int leafIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool overrideSnappyMenuCursorMovementBan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons button)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gamePadButtonHeld(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void backButtonPressed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateHasRoomAnotherFarm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CloseSubMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void performButtonAction(string which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addRightLeafGust()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldShrinkLogo()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addLeftLeafGust()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void createdNewCharacter(bool skipIntro)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void moveFeatures(int dx, int dy)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveScrollWheelAction(int direction)
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
	protected bool ShouldAllowInteraction()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool ShouldDrawCursor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void showButterflies()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~TitleMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
	}
}
