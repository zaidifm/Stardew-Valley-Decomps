using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

internal class EventScript_GreenTea : ICustomEventScript
{
	private const int Phase_intro = 0;

	private const int Phase_text1 = 1;

	private const int Phase_text2 = 2;

	private const int Phase_text3 = 3;

	private const int Phase_buddy = 4;

	private const int Phase_end = 5;

	private int width;

	private int height;

	private int topLeftX;

	private int topLeftY;

	private int phaseTimer;

	private int steamTimer;

	private int cupTimer;

	private int currentPhase;

	private int buddyPhase;

	private int buddyTimer;

	private int textColor;

	private string text;

	private Texture2D tempText;

	private Color bgColor;

	private Color hillColor;

	private Color lightLeafColor;

	private Color darkLeafColor;

	private Vector2 globalCenterPosition;

	private TemporaryAnimatedSprite buddy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EventScript_GreenTea(Vector2 onScreenCenterPosition, Event e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addStar(Vector2 pos, Event e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawAboveAlwaysFront(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool update(GameTime time, Event e)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setBuddyFrame(int frame)
	{
	}
}
