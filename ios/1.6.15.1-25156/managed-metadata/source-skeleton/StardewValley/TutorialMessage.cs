using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Menus;

namespace StardewValley;

public class TutorialMessage : IClickableMenu
{
	public const float defaultTime = 5000f;

	public string message;

	public string type;

	public Color color;

	public float timeLeft;

	public float transparency;

	public int number;

	public int whatType;

	public bool add;

	public bool fadeIn;

	private Rectangle bounds;

	private float widthMod;

	private float heightMod;

	private DialogueBox tMenu;

	public string Message
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
	public TutorialMessage(string message, int x = -1, int y = -1, int maxWidth = -1, int maxHeight = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}
}
