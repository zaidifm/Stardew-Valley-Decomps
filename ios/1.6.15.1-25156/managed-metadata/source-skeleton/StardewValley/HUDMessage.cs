using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

public class HUDMessage
{
	public const float defaultTime = 3500f;

	public const int achievement_type = 1;

	public const int newQuest_type = 2;

	public const int error_type = 3;

	public const int stamina_type = 4;

	public const int health_type = 5;

	public const int screenshot_type = 6;

	public string message;

	public string type;

	public float timeLeft;

	public float transparency;

	public int number;

	public int whatType;

	public bool achievement;

	public bool noIcon;

	public Item messageSubject;

	protected Rectangle bounds;

	protected int textWidth;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HUDMessage(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HUDMessage(string message, int whatType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HUDMessage(string message, float timeLeft, bool fadeIn = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HUDMessage ForItemGained(Item item, int count, string type = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HUDMessage ForCornerTextbox(string message)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HUDMessage ForAchievement(string achievementName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b, int i, ref int heightUsed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void numbersEasterEgg(int number)
	{
	}
}
