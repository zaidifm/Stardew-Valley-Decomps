using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class LevelUpMenu : IClickableMenu
{
	public const int region_okButton = 101;

	public const int region_leftProfession = 102;

	public const int region_rightProfession = 103;

	public const int basewidth = 768;

	public const int baseheight = 512;

	public bool informationUp;

	public bool isActive;

	public bool isProfessionChooser;

	public bool hasUpdatedProfessions;

	private int currentLevel;

	private int currentSkill;

	private int timerBeforeStart;

	private float scale;

	private Color leftProfessionColor;

	private Color rightProfessionColor;

	private MouseState oldMouseState;

	public ClickableTextureComponent starIcon;

	public ClickableTextureComponent okButton;

	public ClickableComponent leftProfession;

	public ClickableComponent rightProfession;

	private List<CraftingRecipe> newCraftingRecipes;

	private List<string> extraInfoForLevel;

	private List<string> leftProfessionDescription;

	private List<string> rightProfessionDescription;

	private Rectangle sourceRectForLevelIcon;

	private string title;

	private List<int> professionsToChoose;

	private List<TemporaryAnimatedSprite> littleStars;

	private bool okButtonHeld;

	private bool dropTitle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LevelUpMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LevelUpMenu(int skill, int level)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetOKButtonBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
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
	public List<string> getExtraInfoForLevel(int whichSkill, int whichLevel)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void addProfessionDescriptions(List<string> descriptions, string professionName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string getProfessionName(int whichProfession)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<string> getProfessionDescription(int whichProfession)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getProfessionTitleFromNumber(int whichProfession)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddMissedProfessionChoices(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeImmediateProfessionPerk(int whichProfession)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void getImmediateProfessionPerk(int whichProfession)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RevalidateHealth(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void okButtonClicked()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveLevelFromLevelList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void getLevelPerk(int skill, int level)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updatePositions()
	{
	}
}
