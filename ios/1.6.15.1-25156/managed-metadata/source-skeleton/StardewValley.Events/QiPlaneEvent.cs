using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Events;

public class QiPlaneEvent : BaseFarmEvent
{
	private Vector2 qiPlanePos;

	private List<TemporaryAnimatedSprite> tempSprites;

	private float boxDropTimer;

	private float textTimer;

	private float finalFadeTimer;

	private string str;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QiPlaneEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveEverything(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool setUp()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool tickUpdate(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
