using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class EmoteMenu : IClickableMenu
{
	public Texture2D menuBackgroundTexture;

	public List<string> emotes;

	protected Point _mouseStartPosition;

	public bool _hasSelectedEmote;

	protected List<ClickableTextureComponent> _emoteButtons;

	protected string _selectedEmote;

	protected int _selectedIndex;

	protected int _oldSelection;

	protected int _selectedTime;

	protected float _alpha;

	protected int _menuCloseGracePeriod;

	protected int _age;

	public bool gamepadMode;

	protected int _expandTime;

	protected int _expandedButtonRadius;

	protected int _buttonRadius;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmoteMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _CreateEmoteButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Rectangle GetEmoteSpriteRect(int emote_index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Rectangle GetEmoteNonBubbleSpriteRect(int emote_index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void applyMovementKey(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void cleanupBeforeExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _RepositionButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _SnapToPlayerPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
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
	public void ConfirmSelection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
