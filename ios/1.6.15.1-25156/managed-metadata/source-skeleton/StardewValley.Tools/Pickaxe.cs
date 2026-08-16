using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Tools;

public class Pickaxe : Tool
{
	public const int hitMargin = 8;

	public const int BoulderStrength = 4;

	private int boulderTileX;

	private int boulderTileY;

	private int hitsToBoulder;

	public NetInt additionalPower;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pickaxe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void GetOneCopyFrom(Item source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool beginUsing(GameLocation location, int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
	{
	}
}
