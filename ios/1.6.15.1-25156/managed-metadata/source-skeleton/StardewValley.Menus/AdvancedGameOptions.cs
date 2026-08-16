using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class AdvancedGameOptions : IClickableMenu
{
	public int itemsPerPage;

	private string hoverText;

	public List<ClickableComponent> optionSlots;

	public int currentItemIndex;

	private ClickableTextureComponent upArrow;

	private ClickableTextureComponent downArrow;

	private ClickableTextureComponent scrollBar;

	public ClickableTextureComponent okButton;

	public List<Action> applySettingCallbacks;

	public Dictionary<OptionsElement, string> tooltips;

	public int ID_okButton;

	private bool scrolling;

	private int _dragStartIndex;

	private int? _dragScrollY;

	public List<OptionsElement> options;

	private Rectangle scrollBarBounds;

	internal static int _lastSelectedIndex;

	internal static int _lastCurrentItemIndex;

	protected int _lastHoveredIndex;

	protected int _hoverDuration;

	private OptionsDropDown _selectedDropdown;

	private int _selectedDropdownIndex;

	public const int WINDOW_WIDTH = 800;

	public const int WINDOW_HEIGHT = 500;

	public bool initialMonsterSpawnAtValue;

	private int optionsSlotHeld;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AdvancedGameOptions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetComponents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PopulateOptions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CloseAndApply()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddHeader(string label)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddTextEntry(string label, string tooltip, bool labelOnSeparateLine, Func<string> get, Action<string> set, Action<OptionsTextEntry> configure = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddDropdown<T>(string label, string tooltip, bool labelOnSeparateLine, Func<T> get, Action<T> set, params KeyValuePair<string, T>[] dropdown_options)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddCheckbox(string label, string tooltip, Func<bool> get, Action<bool> set)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void applyMovementKey(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setScrollBarToCurrentIndex()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapCursorToCurrentSnappedComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetScrollFromY(int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ClickableComponent getCurrentlySnappedComponent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void setCurrentlySnappedComponentTo(int id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveScrollWheelAction(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDropdownActive()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void downArrowPressed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UnsubscribeFromSelectedTextbox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void preWindowSizeChange()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void postWindowSizeChange()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void upArrowPressed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
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
	public override void receiveGamePadButton(Buttons b)
	{
	}
}
