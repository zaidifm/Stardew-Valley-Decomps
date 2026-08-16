using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

public class MobileKeyStates
{
	public WalkDirection lastWalkDirection;

	public bool realTapHeld;

	public bool useToolButtonPressed;

	public bool useToolButtonReleased;

	public bool useToolHeld;

	public bool actionButtonPressed;

	public bool moveUpPressed;

	public bool moveDownPressed;

	public bool moveLeftPressed;

	public bool moveRightPressed;

	public bool moveUpReleased;

	public bool moveRightReleased;

	public bool moveDownReleased;

	public bool moveLeftReleased;

	public bool moveUpHeld;

	public bool moveRightHeld;

	public bool moveDownHeld;

	public bool moveLeftHeld;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopMoving()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetDirections()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetLeftOrRightClickButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Debug()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugLine()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMovePressed(WalkDirection walkDirection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPressed(bool up, bool down, bool left, bool right)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUp(bool up)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDown(bool down)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLeft(bool left)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRight(bool right)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUseTool(bool useTool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateReleasedStates()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileKeyStates()
	{
	}
}
