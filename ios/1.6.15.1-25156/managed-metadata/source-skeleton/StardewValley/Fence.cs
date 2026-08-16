using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.GameData.Fences;

namespace StardewValley;

public class Fence : Object
{
	public const int debrisPieces = 4;

	public static int fencePieceWidth;

	public static int fencePieceHeight;

	public const int gateClosedPosition = 0;

	public const int gateOpenedPosition = 88;

	public const int sourceRectForSoloGate = 17;

	public const int globalHealthMultiplier = 2;

	public const int N = 1000;

	public const int E = 100;

	public const int S = 500;

	public const int W = 10;

	public const string woodFenceId = "322";

	public const string stoneFenceId = "323";

	public const string ironFenceId = "324";

	public const string hardwoodFenceId = "298";

	public const string gateId = "325";

	[XmlIgnore]
	public Lazy<Texture2D> fenceTexture;

	public static Dictionary<int, int> fenceDrawGuide;

	[XmlElement("health")]
	public new readonly NetFloat health;

	[XmlElement("maxHealth")]
	public readonly NetFloat maxHealth;

	[XmlElement("whichType")]
	public int? obsolete_whichType;

	[XmlElement("gatePosition")]
	public readonly NetInt gatePosition;

	public int gateMotion;

	[XmlElement("isGate")]
	public readonly NetBool isGate;

	[XmlIgnore]
	public readonly NetBool repairQueued;

	internal static Dictionary<string, FenceData> _FenceLookup;

	protected FenceData _data;

	public bool gateOpen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool isSoloGate
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
	public Fence(Vector2 tileLocation, string itemId, bool isGate)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Fence()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetHealth(float amount_adjustment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnIdChanged()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void repair()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void populateFenceDrawGuide()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PerformRepairIfNecessary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, FenceData> GetFenceLookup()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FenceData GetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(string itemId, out FenceData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void _LoadFenceData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getDrawSum()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void toggleGate(bool open, bool is_toggling_counterpart = false, Farmer who = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void toggleGate(Farmer who, bool open, bool is_toggling_counterpart = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void dropItem(GameLocation location, Vector2 origin, Vector2 destination)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsValidRemovalTool(Tool tool)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float GetRepairHealthAdjustment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetRepairSound()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanRepairWithThisItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performDropDownAction(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Texture2D loadFenceTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawWhenHeld(SpriteBatch spriteBatch, Vector2 objectPosition, Farmer f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scale, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool countsForDrawing(string otherItemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPassable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b, int x, int y, float alpha = 1f)
	{
	}
}
