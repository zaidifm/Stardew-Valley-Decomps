using System.Collections.Generic;

namespace StardewValley.Inventories;

public delegate void OnInventoryReplacedDelegate(Inventory inventory, IList<Item> before, IList<Item> after);
