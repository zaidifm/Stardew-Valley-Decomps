using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using StardewValley.Menus;

namespace StardewValley;

public class Options
{
	public enum ItemStowingModes
	{
		Off,
		GamepadOnly,
		Both
	}

	public enum GamepadModes
	{
		Auto,
		ForceOn,
		ForceOff
	}

	public const float minZoom = 0.75f;

	public const float maxZoom = 2f;

	public const float minUIZoom = 0.75f;

	public const float maxUIZoom = 1.5f;

	public const int toggleAutoRun = 0;

	public const int musicVolume = 1;

	public const int soundVolume = 2;

	public const int toggleDialogueTypingSounds = 3;

	public const int toggleFullscreen = 4;

	public const int screenResolution = 6;

	public const int showPortraitsToggle = 7;

	public const int showMerchantPortraitsToggle = 8;

	public const int menuBG = 9;

	public const int toggleFootsteps = 10;

	public const int alwaysShowToolHitLocationToggle = 11;

	public const int hideToolHitLocationWhenInMotionToggle = 12;

	public const int windowMode = 13;

	public const int pauseWhenUnfocused = 14;

	public const int pinToolbar = 15;

	public const int toggleRumble = 16;

	public const int ambientOnly = 17;

	public const int zoom = 18;

	public const int zoomButtonsToggle = 19;

	public const int ambientVolume = 20;

	public const int footstepVolume = 21;

	public const int invertScrollDirectionToggle = 22;

	public const int snowTransparencyToggle = 23;

	public const int screenFlashToggle = 24;

	public const int toggleHardwareCursor = 26;

	public const int toggleShowPlacementTileGamepad = 27;

	public const int stowingModeSelect = 28;

	public const int toggleSnappyMenus = 29;

	public const int toggleIPConnections = 30;

	public const int serverMode = 31;

	public const int toggleFarmhandCreation = 32;

	public const int toggleShowAdvancedCraftingInformation = 34;

	public const int toggleMPReadyStatus = 35;

	public const int mapScreenshot = 36;

	public const int toggleVsync = 37;

	public const int gamepadModeSelect = 38;

	public const int uiScaleSlider = 39;

	public const int moveBuildingPermissions = 40;

	public const int slingshotModeSelect = 41;

	public const int biteChime = 42;

	public const int toggleMuteAnimalSounds = 43;

	public const int toggleUseChineseSmoothFont = 44;

	public const int dialogueFontToggle = 45;

	public const int toggleUseAlternateFont = 46;

	public const int input_actionButton = 7;

	public const int input_cancelButton = 9;

	public const int input_useToolButton = 10;

	public const int input_moveUpButton = 11;

	public const int input_moveRightButton = 12;

	public const int input_moveDownButton = 13;

	public const int input_moveLeftButton = 14;

	public const int input_menuButton = 15;

	public const int input_runButton = 16;

	public const int input_chatButton = 17;

	public const int input_journalButton = 18;

	public const int input_mapButton = 19;

	public const int input_slot1 = 20;

	public const int input_slot2 = 21;

	public const int input_slot3 = 22;

	public const int input_slot4 = 23;

	public const int input_slot5 = 24;

	public const int input_slot6 = 25;

	public const int input_slot7 = 26;

	public const int input_slot8 = 27;

	public const int input_slot9 = 28;

	public const int input_slot10 = 29;

	public const int input_slot11 = 30;

	public const int input_slot12 = 31;

	public const int input_toolbarSwap = 32;

	public const int input_emoteButton = 33;

	public const float defaultZoomLevel = 1f;

	public const int defaultLightingQuality = 8;

	public const float defaultSplitScreenZoomLevel = 1.5f;

	public bool autoRun;

	public bool dialogueTyping;

	public bool showPortraits;

	public bool showMerchantPortraits;

	public bool showMenuBackground;

	public bool playFootstepSounds;

	public bool alwaysShowToolHitLocation;

	public bool hideToolHitLocationWhenInMotion;

	public bool pauseWhenOutOfFocus;

	public bool pinToolbarToggle;

	public bool mouseControls;

	public bool gamepadControls;

	public bool rumble;

	public bool ambientOnlyToggle;

	public bool zoomButtons;

	public bool invertScrollDirection;

	public bool screenFlash;

	public bool showPlacementTileForGamepad;

	public bool snappyMenus;

	public bool showAdvancedCraftingInformation;

	public bool showMPEndOfNightReadyStatus;

	public bool muteAnimalSounds;

	public bool vsyncEnabled;

	public bool fullscreen;

	public bool windowedBorderlessFullscreen;

	public bool showClearBackgrounds;

	public bool useChineseSmoothFont;

	public bool useAlternateFont;

	[DontLoadDefaultSetting]
	public bool ipConnectionsEnabled;

	[DontLoadDefaultSetting]
	public bool enableServer;

	[DontLoadDefaultSetting]
	public bool enableFarmhandCreation;

	protected bool _hardwareCursor;

	public ItemStowingModes stowingMode;

	[DontLoadDefaultSetting]
	public GamepadModes gamepadMode;

	public bool useLegacySlingshotFiring;

	public float musicVolumeLevel;

	public float soundVolumeLevel;

	public float footstepVolumeLevel;

	public float ambientVolumeLevel;

	public float snowTransparency;

	public float dialogueFontScale;

	[XmlIgnore]
	public float baseZoomLevel;

	[DontLoadDefaultSetting]
	[XmlElement("zoomLevel")]
	public float singlePlayerBaseZoomLevel;

	[DontLoadDefaultSetting]
	public float localCoopBaseZoomLevel;

	[DontLoadDefaultSetting]
	[XmlElement("uiScale")]
	public float singlePlayerDesiredUIScale;

	[DontLoadDefaultSetting]
	public float localCoopDesiredUIScale;

	[XmlIgnore]
	public float baseUIScale;

	public int preferredResolutionX;

	public int preferredResolutionY;

	[DontLoadDefaultSetting]
	public ServerPrivacy serverPrivacy;

	public InputButton[] actionButton;

	public InputButton[] cancelButton;

	public InputButton[] useToolButton;

	public InputButton[] moveUpButton;

	public InputButton[] moveRightButton;

	public InputButton[] moveDownButton;

	public InputButton[] moveLeftButton;

	public InputButton[] menuButton;

	public InputButton[] runButton;

	public InputButton[] tmpKeyToReplace;

	public InputButton[] chatButton;

	public InputButton[] mapButton;

	public InputButton[] journalButton;

	public InputButton[] inventorySlot1;

	public InputButton[] inventorySlot2;

	public InputButton[] inventorySlot3;

	public InputButton[] inventorySlot4;

	public InputButton[] inventorySlot5;

	public InputButton[] inventorySlot6;

	public InputButton[] inventorySlot7;

	public InputButton[] inventorySlot8;

	public InputButton[] inventorySlot9;

	public InputButton[] inventorySlot10;

	public InputButton[] inventorySlot11;

	public InputButton[] inventorySlot12;

	public InputButton[] toolbarSwap;

	public InputButton[] emoteButton;

	[XmlIgnore]
	public bool optionsDirty;

	[XmlIgnore]
	private XmlSerializer defaultSettingsSerializer;

	private int appliedLightingQuality;

	public const int menuMargin = 133;

	public const int toolbarPaddingX = 134;

	public const int toggleVerticalToolbar = 135;

	public const int toggleAutoAttack = 136;

	public const int toggleGreenSquaresGuide = 137;

	public const int toggleVibrate = 138;

	public const int selectWeaponControl = 139;

	public const int toggleJoypadButtonVisibility = 140;

	public const int toggleBiggerNumberFont = 141;

	public const int toggleAutoSave = 142;

	public const int adjustSizeJoystick = 143;

	public const int adjustSizeButtonA = 144;

	public const int adjustSizeButtonB = 145;

	public const int adjustInvisibleButtonWidth = 146;

	public const int togglePinchZoom = 147;

	public const int adjustToolbarSlotSize = 148;

	public const int adjustDateTimeScale = 149;

	public const int toggleCameraButton = 150;

	public const int useBiggerFonts = 151;

	public bool verticalToolbar;

	public bool autoAttack;

	public bool greenSquaresGuide;

	public bool vibrations;

	public bool bigNumbers;

	public bool bigFonts;

	public bool autoSave;

	public int xEdge;

	public int toolbarPadding;

	public int weaponControl;

	public bool showToggleJoypadButton;

	public bool pinchZoom;

	public int invisibleButtonWidth;

	public int daysSinceReviewRequest;

	public bool reviewGiven;

	public int toolbarSlotSize;

	public float dateTimeScale;

	public int lastSeenBuildNumber;

	public bool showCameraButton;

	public SerializableDictionary<int, int[]> joystickConfigs;

	public int sizeJoystick;

	public int sizeButtonA;

	public int sizeButtonB;

	public Point positionJoystick;

	public Point positionButtonA;

	public Point positionButtonB;

	public bool hardwareCursor
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

	public int lightingQuality
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public float zoomLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public float desiredBaseZoomLevel
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

	[XmlIgnore]
	public float desiredUIScale
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

	[XmlIgnore]
	public float uiScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool allowStowing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool SnappyMenus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int joystickSize
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

	public int buttonASize
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

	public int buttonBSize
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

	public Point joystickPosition
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

	public Point buttonAPosition
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

	public Point buttonBPosition
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Options()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetFilePathForDefaultOptions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadDefaultOptions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SaveDefaultOptions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void platformClampValues()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FetchZoom()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Keys getFirstKeyboardKeyFromInputButtonList(InputButton[] inputButton)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void reApplySetOptions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setToDefaults()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setControlsToDefault()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getNameOfOptionFromIndex(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeCheckBoxOption(int which, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForBiggerFontSwap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeSliderOption(int which, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadChineseFonts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setBackgroundMode(string setting)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setStowingMode(string setting)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setSlingshotMode(string setting)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setBiteChime(string setting)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setGamepadMode(string setting)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setMoveBuildingPermissions(string setting)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setServerMode(string setting)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setWindowedOption(string setting)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setWindowedOption(int setting)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeDropDownOption(int which, string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isKeyInUse(Keys key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<InputButton> getAllUsedInputButtons()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setCheckBoxToProperValue(OptionsCheckbox checkbox)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setPlusMinusToProperValue(OptionsPlusMinus plusMinus)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setSliderToProperValue(OptionsSlider slider)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool doesInputListContain(InputButton[] list, Keys key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeInputListenerValue(int whichListener, Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setInputListenerToProperValue(OptionsInputListener inputListener)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setDropDownToProperValue(OptionsDropDown dropDown)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isCurrentlyWindowedBorderless()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isCurrentlyFullscreen()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isCurrentlyWindowed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPositionJoystick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPositionButtonA(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPositionButtonB(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setJoystickConfigsToDefault()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setToDefaults_Mobile()
	{
	}
}
