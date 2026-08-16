using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

public class CraftingQuest : Quest
{
	[XmlElement("isBigCraftable")]
	public bool? obsolete_isBigCraftable;

	[XmlElement("indexToCraft")]
	public readonly NetString ItemId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CraftingQuest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CraftingQuest(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnRecipeCrafted(CraftingRecipe recipe, Item item, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
