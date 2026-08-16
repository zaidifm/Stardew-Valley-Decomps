using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.BellsAndWhistles;
using xTile;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class IslandLocation : GameLocation
{
	public const int TOTAL_WALNUTS = 130;

	[XmlIgnore]
	public List<ParrotPlatform> parrotPlatforms;

	[XmlIgnore]
	public NetList<ParrotUpgradePerch, NetRef<ParrotUpgradePerch>> parrotUpgradePerches;

	[XmlIgnore]
	public NetList<Point, NetPoint> buriedNutPoints;

	[XmlElement("locationGemBird")]
	public NetRef<IslandGemBird> locationGemBird;

	[XmlIgnore]
	protected Texture2D _dayParallaxTexture;

	[XmlIgnore]
	protected Texture2D _nightParallaxTexture;

	[XmlIgnore]
	protected TemporaryAnimatedSpriteList underwaterSprites;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyUnsafeMapOverride(string override_map, Microsoft.Xna.Framework.Rectangle? source_rect, Microsoft.Xna.Framework.Rectangle dest_rect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string doesTileHaveProperty(int xTile, int yTile, string propertyName, string layerName, bool ignoreTileSheetProperties = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetBuriedNutLocations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<Vector2> GetAdditionalWalnutBushes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandLocation(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool SeedsIgnoreSeasonsHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool catchOceanCrabPotFishFromThisSpot(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogue(Response answer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character, bool pathfinding, bool projectile = false, bool ignoreCharacterRequirement = false, bool skipCollisionEffects = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void addMoonlightJellies(int numTries, Random r, Microsoft.Xna.Framework.Rectangle exclusionRect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void tryToAddCritters(bool onlyIfOnScreen = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddAdditionalWalnutBushes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isActionableTile(int xTile, int yTile, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void digUpArtifactSpot(int xLocation, int yLocation, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsBuriedNutLocation(Point point)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Item getFish(float millisecondsAfterNibble, string bait, int waterDepth, Farmer who, double baitPotency, Vector2 bobberTile, string locationName = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsLocationSpecificOccupantOnTile(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void seasonUpdate(bool onLoad = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateSeasonalTileSheets(Map map = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawWater(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawParallaxHorizon(SpriteBatch b, bool horizontal_parallax = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AreMoonlightJelliesOut()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
