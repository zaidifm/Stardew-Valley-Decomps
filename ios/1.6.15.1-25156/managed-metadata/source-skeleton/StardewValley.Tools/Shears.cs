using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Tools;

public class Shears : Tool
{
	[XmlIgnore]
	private readonly NetEvent0 finishEvent;

	[XmlIgnore]
	public FarmAnimal animal;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shears()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool beginUsing(GameLocation location, int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void playSnip(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void tickUpdate(GameTime time, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void finish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doFinish()
	{
	}
}
