using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Menus;

namespace StardewValley.Mobile;

public class VirtualJoypad : IClickableMenu
{
	private const int MIN_JOYSTICK_MOVE_THRESHOLD = 20;

	public ControlType mostRecentlyUsedControlType;

	public ClickableTextureComponent buttonToggleJoypad;

	public ClickableTextureComponent joystick;

	public ClickableTextureComponent buttonA;

	public ClickableTextureComponent buttonB;

	public long buttonATouchStartTime;

	public bool buttonAHeld;

	public bool buttonBHeld;

	public bool justUsedSlingshot;

	private int _maxJoystickMoveRadius;

	private Point _joystickStartPosition;

	private Point _joystickTapPoint;

	private Point _joystickLastTapPoint;

	private Vector2 _centerOfJoystick;

	private ClickableComponent _selectedButton;

	private int _lastWeaponControl;

	private bool _showJoypad;

	private bool _joystickWasJustHeld;

	private bool _joystickHeld;

	public const int DEFAULT_JOYSTICK_DIAMETER = 185;

	public const int DEFAULT_BUTTON_A_DIAMETER = 111;

	public const int DEFAULT_BUTTON_B_DIAMETER = 111;

	public const int DEFAULT_INVISIBLE_BUTTON_WIDTH = 200;

	private const int ADJUSTER_PANEL_HEIGHT = 244;

	public const int MIN_BUTTON_SIZE = 20;

	public const int MAX_BUTTON_SIZE = 300;

	private bool _adjustmentMode;

	private Point _initialJoystickPosition;

	private Point _initialButtonAPosition;

	private Point _initialButtonBPosition;

	private int _initialJoystickSize;

	private int _initialButtonASize;

	private int _initialButtonBSize;

	public ClickableTextureComponent buttonTick;

	public ClickableTextureComponent buttonCancel;

	public OptionsSlider sizeSlider;

	public OptionsButton buttonDefaults;

	public float buttonAlpha;

	private Rectangle _joystickSourceRect;

	private ClickableTextureComponent radioButtonJoystick;

	private ClickableTextureComponent radioButtonButtonA;

	private ClickableTextureComponent radioButtonButtonB;

	private int _selectedBoxX;

	private int _lastMouseX;

	private int _lastMouseY;

	private bool _leftButtonDown;

	private double _joystickAngle;

	private const int TICKS_BEFORE_BUTTON_B = 2500000;

	private const int TICKS_BEFORE_RESET = 2000000;

	private bool _touchingJoystick;

	private bool _touchingButtonA;

	private bool _touchingButtonB;

	private const int PULL_THRESHOLD = 10;

	private float buttonFadeAlpha;

	private float buttonFadeStep;

	public bool joystickWasJustHeld
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool joystickHeld
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

	public bool adjustmentMode
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

	public int sizeJoystick
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

	public int sizeButtonA
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

	public int sizeButtonB
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

	public Point positionJoystick
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

	public Point positionButtonA
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

	public Point positionButtonB
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

	public int screenWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int screenHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private float joystickScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private float buttonAScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private float buttonBScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private string settingsStr
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector2 PositionFromStart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool showJoystick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public double joystickAngle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool showJoypad
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

	public bool TouchingTwoOrMoreButtons
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool TouchingJoystickOrButton
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool ButtonAPressed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool ButtonBPressed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Vector2 GrabTile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
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
	public VirtualJoypad()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateAdjusterControls()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSetToDefaults()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckToSetDefaults()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetJoystickDefaults()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetButtonADefaults()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetButtonBDefaults()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateJoystickAndButtonsSizePositionAndScale()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateJoystickAndButtonsStartPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetAttackJoystickStartPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetInvisbleJoystickBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetInvisbleJoystickBoundsOneButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TappedInvisibleAttackButtonA(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TappedInvisibleAttackButtonB(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TappedInvisibleSingleAttackButton(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnTapInvisibleJoystick(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnTapJoystick(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TappedButtonA(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TappedButtonB(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTapHeldJoystick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateJoystick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BackupSizeAndPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RevertSizeAndPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
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
	private void UpdateSliderPosition(int currentMouseX, int currentMouseY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateButtonSizes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateButtonScales()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveButtonPositions(int currentMouseX, int currentMouseY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateButtonToogleBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckForManualWeaponControlTaps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckForTapAttackJoystick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckForTapJoystickAndButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetGrabTile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawAndUpdateToggleShowJoypadButton(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawJustToggleShowJoypadButton(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void drawToggleShowJoypadButton(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void drawJoystickAndButtons(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void drawAdjusters(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetJoypad()
	{
	}
}
