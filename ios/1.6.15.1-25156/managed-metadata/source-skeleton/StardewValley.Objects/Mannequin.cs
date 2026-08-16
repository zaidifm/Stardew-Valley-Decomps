using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Delegates;
using StardewValley.GameData;
using StardewValley.Network;

namespace StardewValley.Objects;

public class Mannequin : Object
{
	protected string _description;

	protected MannequinData _data;

	public string displayNameOverride;

	public readonly NetMutex changeMutex;

	public readonly NetRef<Hat> hat;

	public readonly NetRef<Clothing> shirt;

	public readonly NetRef<Clothing> pants;

	public readonly NetRef<Boots> boots;

	public readonly NetDirection facing;

	public readonly NetBool swappedWithFarmerTonight;

	private Farmer renderCache;

	internal int eyeTimer;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mannequin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mannequin(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnMannequinUpdated<TNetField, TValue>(TNetField field, TValue oldValue, TValue newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected internal MannequinData GetMannequinData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string loadDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPlaceable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ForEachItem(ForEachItemDelegate handler, GetForEachItemPathDelegate getPath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void emitGhost()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool minutesElapsed(int minutes)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void actionOnPlayerEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
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
	private void DropItem(Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Farmer GetFarmerForRendering()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
