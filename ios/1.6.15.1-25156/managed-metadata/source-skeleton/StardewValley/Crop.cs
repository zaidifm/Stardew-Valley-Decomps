using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Characters;
using StardewValley.GameData.Crops;
using StardewValley.GameData.GiantCrops;
using StardewValley.Mods;
using StardewValley.TerrainFeatures;

namespace StardewValley;

public class Crop : INetObject<NetFields>, IHaveModData
{
	public const string mixedSeedsId = "770";

	public const string mixedSeedsQId = "(O)770";

	public const int seedPhase = 0;

	public const int rowOfWildSeeds = 23;

	public const int finalPhaseLength = 99999;

	public const int forageCrop_springOnion = 1;

	public const string forageCrop_springOnionID = "1";

	public const int forageCrop_ginger = 2;

	public const string forageCrop_gingerID = "2";

	public const int specialVariable_farmedForageCrop = 724519;

	private GameLocation currentLocationImpl;

	public readonly NetIntList phaseDays;

	[XmlElement("rowInSpriteSheet")]
	public readonly NetInt rowInSpriteSheet;

	[XmlElement("phaseToShow")]
	public readonly NetInt phaseToShow;

	[XmlElement("currentPhase")]
	public readonly NetInt currentPhase;

	[XmlElement("indexOfHarvest")]
	public readonly NetString indexOfHarvest;

	[XmlElement("dayOfCurrentPhase")]
	public readonly NetInt dayOfCurrentPhase;

	[XmlElement("whichForageCrop")]
	public readonly NetString whichForageCrop;

	[XmlElement("overrideHarvestItemId")]
	public readonly NetString replaceWithObjectOnFullGrown;

	[XmlElement("tintColor")]
	public readonly NetColor tintColor;

	[XmlElement("flip")]
	public readonly NetBool flip;

	[XmlElement("fullGrown")]
	public readonly NetBool fullyGrown;

	[XmlElement("raisedSeeds")]
	public readonly NetBool raisedSeeds;

	[XmlElement("programColored")]
	public readonly NetBool programColored;

	[XmlElement("dead")]
	public readonly NetBool dead;

	[XmlElement("forageCrop")]
	public readonly NetBool forageCrop;

	[XmlElement("seedIndex")]
	public readonly NetString netSeedIndex;

	[XmlElement("overrideTexturePath")]
	public readonly NetString overrideTexturePath;

	protected Texture2D _drawnTexture;

	protected bool? _isErrorCrop;

	[XmlIgnore]
	public Vector2 drawPosition;

	[XmlIgnore]
	public Vector2 tilePosition;

	[XmlIgnore]
	public float layerDepth;

	[XmlIgnore]
	public float coloredLayerDepth;

	[XmlIgnore]
	public Rectangle sourceRect;

	[XmlIgnore]
	public Rectangle coloredSourceRect;

	private static Vector2 origin;

	private static Vector2 smallestTileSizeOrigin;

	[XmlIgnore]
	public GameLocation currentLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[XmlIgnore]
	public HoeDirt Dirt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlIgnore]
	public Texture2D DrawnCropTexture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public ModDataDictionary modData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlElement("modData")]
	public ModDataDictionary modDataForSerialization
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool ReadyToHarvest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Crop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Crop(bool forageCrop, string which, int tileX, int tileY, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Crop(string seedId, int tileX, int tileY, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ResolveSeedId(string itemId, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CropData GetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(string seedId, out CropData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInSeason(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsInSeason(GameLocation location, string seedId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HarvestMethod GetHarvestMethod()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RegrowsAfterHarvest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsErrorCrop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetPhaseDays()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getRandomLowGradeCropForThisSeason(Season season)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getRandomFlowerSeedForThisSeason(Season season)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void growCompletely()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool hitWithHoe(int xTile, int yTile, GameLocation location, HoeDirt dirt)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool harvest(int xTile, int yTile, HoeDirt soil, JunimoHarvester junimoHarvester = null, bool isForcedScytheHarvest = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getRandomWildCropForSeason(bool onlyDeterministic = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getRandomWildCropForSeason(Season season)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle getSourceRect(int number)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetGiantCrops(out IReadOnlyList<KeyValuePair<string, GiantCropData>> giantCrops)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Kill()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isSourceRectEmpty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newDay(int state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TryGrowGiantCrop(bool checkPreconditions = true, Random random = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isPaddyCrop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool shouldDrawDarkWhenWatered()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isWildSeedCrop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateDrawMath(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b, Vector2 tileLocation, Color toTint, float rotation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawInMenu(SpriteBatch b, Vector2 screenPosition, Color toTint, float rotation, float scale, float layerDepth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawWithOffset(SpriteBatch b, Vector2 tileLocation, Color toTint, float rotation, Vector2 offset)
	{
	}
}
