using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;

namespace StardewValley;

public class InputState
{
	protected Point _simulatedMousePosition;

	protected List<Keys> _ignoredKeys;

	protected List<Keys> _pressedKeys;

	protected KeyboardState? _keyState;

	protected int _lastKeyStateTick;

	protected KeyboardState _currentKeyboardState;

	protected MouseState _currentMouseState;

	protected GamePadState _currentGamepadState;

	protected TouchCollection _currentTouchState;

	public TouchCollection GetTouchState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateStates()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void IgnoreKeys(Keys[] keys)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual KeyboardState GetKeyboardState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GamePadState GetGamePadState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual MouseState GetMouseState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetMousePosition(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputState()
	{
	}
}
