using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Buildings;

namespace StardewValley.Events;

public class SoundInTheNightEvent : BaseFarmEvent
{
	public const int cropCircle = 0;

	public const int meteorite = 1;

	public const int dogs = 2;

	public const int owl = 3;

	public const int earthquake = 4;

	public const int raccoonStump = 5;

	private readonly NetInt behavior;

	private float timer;

	private float timeUntilText;

	private string soundName;

	private string message;

	private bool playedSound;

	private bool showedMessage;

	private bool finished;

	private Vector2 targetLocation;

	private Building targetBuilding;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoundInTheNightEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoundInTheNightEvent(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void makeChangesToLocation()
	{
	}
}
