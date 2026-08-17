using System.Runtime.CompilerServices;
using StardewValley.Tools;

namespace StardewValley.Mobile;

public partial class TapToMoveUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SelectTool(string toolName)
	{
		for (int i = 0; i < Game1.player.Items.Count; i++)
		{
			Item item = Game1.player.Items[i];
			if (item != null && item.ItemId == toolName)
			{
				Game1.player.CurrentToolIndex = i;
				Game1.player.UpdateItemStow();
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool PlayerHasTool(string toolName)
	{
		for (int i = 0; i < Game1.player.Items.Count; i++)
		{
			Item item = Game1.player.Items[i];
			if (item != null && item.ItemId == toolName)
				return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MeleeWeapon getBestAvailableWeapon()
	{
		MeleeWeapon best = null;
		for (int i = 0; i < Game1.player.Items.Count; i++)
		{
			if (Game1.player.Items[i] is MeleeWeapon weapon)
			{
				if (best == null
					|| weapon.getItemLevel() > best.getItemLevel()
					|| best.ItemId == "Scythe")
				{
					best = weapon;
				}
			}
		}
		return best;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item FetchItemInInventoryByName(string itemName)
	{
		for (int i = 0; i < Game1.player.Items.Count; i++)
		{
			Item item = Game1.player.Items[i];
			if (item != null && item.ItemId == itemName)
				return item;
		}
		return null;
	}
}
