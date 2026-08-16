using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class IslandFarmCave : IslandLocation
{
	[XmlIgnore]
	public NPC gourmand;

	[XmlElement("gourmandRequestsFulfilled")]
	public NetInt gourmandRequestsFulfilled;

	[XmlIgnore]
	public NetEvent0 requestGourmandCheckEvent;

	[XmlIgnore]
	public NetEvent1Field<string, NetString> gourmandResponseEvent;

	[XmlIgnore]
	public bool triggeredGourmand;

	[XmlIgnore]
	public static int TOTAL_GOURMAND_REQUESTS;

	[XmlIgnore]
	private NetMutex gourmandMutex;

	private Texture2D smokeTexture;

	private float smokeTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandFarmCave()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandFarmCave(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRequestGourmandCheck()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRelativeDirection(Point source, Point destination)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point FindNearbyUnoccupiedTileThatFitsCharacter(GameLocation location, int target_x, int target_y, int width = 1, Point? invalid_tile = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGourmandResponse(string response)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CompleteGourmandRequest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GiveReward()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowGourmandUnhappy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToGourmand()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string IndexForRequest(int request_number)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}
}
