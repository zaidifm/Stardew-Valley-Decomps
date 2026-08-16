using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;

namespace StardewValley.Tools;

public class Lantern : Tool
{
	public const float baseRadius = 10f;

	public const int millisecondsPerFuelUnit = 6000;

	public const int maxFuel = 100;

	public int fuelLeft;

	private int fuelTimer;

	public bool on;

	[XmlIgnore]
	public string lightSourceId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Lantern()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void tickUpdate(GameTime time, Farmer who)
	{
	}
}
