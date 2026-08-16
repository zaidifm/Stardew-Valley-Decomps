using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Characters;
using StardewValley.Locations;

namespace StardewValley.Events;

public class PlayerCoupleBirthingEvent : BaseFarmEvent
{
	private int timer;

	private string soundName;

	private string message;

	private string babyName;

	private bool playedSound;

	private bool isMale;

	private bool getBabyName;

	private bool naming;

	private FarmHouse farmHouse;

	private long spouseID;

	private Farmer spouse;

	private bool isPlayersTurn;

	private Child child;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerCoupleBirthingEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool isSuitableHome(FarmHouse home)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmHouse chooseHome()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool setUp()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void returnBabyName(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void afterMessage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool tickUpdate(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
