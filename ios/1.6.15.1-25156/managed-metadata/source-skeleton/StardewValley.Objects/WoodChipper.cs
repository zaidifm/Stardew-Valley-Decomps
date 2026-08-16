using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Objects;

public class WoodChipper : Object
{
	public const int CHIP_TIME = 1000;

	public readonly NetRef<Object> depositedItem;

	protected bool _isAnimatingChip;

	public int nextSmokeTime;

	public int nextShakeTime;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDepositedItemChange(NetRef<Object> field, Object old_value, Object new_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WoodChipper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WoodChipper(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void addWorkingAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}
}
