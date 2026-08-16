using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.GameData;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class AdventureGuild : GameLocation
{
	public NPC Gil;

	public bool talkedToGil;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AdventureGuild()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AdventureGuild(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	private string killListLine(string monsterNamePlural, int killCount, int target)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showMonsterKillList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool areAllMonsterSlayerQuestsComplete()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool willThisKillCompleteAMonsterSlayerQuest(string nameOfMonster)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRewardCollected(Item item, Farmer who, List<KeyValuePair<string, MonsterSlayerQuestData>> completedGoals)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gil()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasCollectedReward(Farmer player, string goalId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsComplete(MonsterSlayerQuestData goal)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenRewardMenuIfNeeded(List<Item> rewards, List<KeyValuePair<string, MonsterSlayerQuestData>> completedGoals)
	{
	}
}
