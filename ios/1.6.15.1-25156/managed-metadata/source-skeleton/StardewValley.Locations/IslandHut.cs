using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class IslandHut : IslandLocation
{
	public NetBool treeNutObtained;

	[XmlIgnore]
	public NetEvent0 hitTreeEvent;

	[XmlIgnore]
	public NetEvent0 parrotBoyEvent;

	[XmlIgnore]
	public bool treeHitLocal;

	[XmlElement("firstParrotDone")]
	public readonly NetBool firstParrotDone;

	[XmlIgnore]
	public List<string> hintDialogues;

	[XmlElement("hintForToday")]
	public NetString hintForToday;

	[XmlIgnore]
	public float hintShowTime;

	[XmlIgnore]
	public float hintShakeTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int ShowNutHint()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Squawk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool MissingLimitedNutDrops(ref int running_total, string key, int count = 1)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool MissingTheseNuts(ref int running_total, params string[] keys)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandHut()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandHut(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t, int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ParrotBoyEvent_onEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SpitTreeNut()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}
}
