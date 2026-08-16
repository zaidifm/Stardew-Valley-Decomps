using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework.Graphics;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class ManorHouse : GameLocation
{
	[XmlIgnore]
	private Dictionary<string, Farmer> sendMoneyMapping;

	private static readonly bool changeWalletTypeImmediately;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ManorHouse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ManorHouse(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckLostAndFound()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Farmer> GetRetrievableFarmers()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readLedgerBook()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowOfflineFarmhandItemList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChooseRecipient()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void beginSendMoney(Farmer recipient)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sendMoney(Farmer recipient, int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SeparateWallets()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MergeWallets()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
