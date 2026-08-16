using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Characters;
using StardewValley.GameData.Buildings;
using StardewValley.Objects;

namespace StardewValley.Buildings;

public class JunimoHut : Building
{
	public int cropHarvestRadius;

	[XmlElement("output")]
	public Chest obsolete_output;

	[XmlElement("noHarvest")]
	public readonly NetBool noHarvest;

	[XmlElement("wasLit")]
	public readonly NetBool wasLit;

	private int junimoSendOutTimer;

	[XmlIgnore]
	public List<JunimoHarvester> myJunimos;

	[XmlIgnore]
	public Point lastKnownCropLocation;

	public NetInt raisinDays;

	[XmlElement("shouldSendOutJunimos")]
	public NetBool shouldSendOutJunimos;

	private Rectangle lightInteriorRect;

	private Rectangle bagRect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JunimoHut(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JunimoHut()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle getRectForAnimalDoor(BuildingData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle? getSourceRectForMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chest GetOutputChest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void dayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sendOutJunimos()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performActionOnConstruction(GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateLightState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getUnusedJunimoNumber()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenFarmNotCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color? getGemColor(ref bool isPrismatic)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool areThereMatureCropsWithinRadius()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteAction(int timeElapsed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool doAction(Vector2 tileLocation, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
