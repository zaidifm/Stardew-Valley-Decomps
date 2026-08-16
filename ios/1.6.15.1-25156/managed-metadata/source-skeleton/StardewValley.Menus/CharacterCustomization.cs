using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Objects;

namespace StardewValley.Menus;

public class CharacterCustomization : GameMenu
{
	[XmlType(TypeName = "MobileSource")]
	public enum Source
	{
		NewGame,
		NewFarmhand,
		Wizard,
		HostNewFarm,
		Dresser,
		ClothesDye,
		DyePots
	}

	public static bool clickedOnMenu;

	public bool showingCoopHelp;

	public Source source;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterCustomization(Clothing item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterCustomization(Source source = Source.NewGame, bool tutorialsWanted = false, Clothing item = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showAdvancedCharacterCreationHighlight()
	{
	}
}
