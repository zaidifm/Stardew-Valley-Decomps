using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;
using StardewValley.Network;

namespace StardewValley.Util;

public class SynchronizedShopStock : INetObject<NetFields>
{
	private readonly NetStringDictionary<int, NetInt> stockDictionary;

	protected static HashSet<string> _usedKeys;

	protected static List<ISalable> _stockSalables;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SynchronizedShopStock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnItemPurchased(string shop_id, ISalable item, Dictionary<ISalable, ItemStockInformation> stock, int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetQualifiedSyncedKey(string shop_id, ItemStockInformation item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateLocalStockWithSyncedQuanitities(string shop_id, Dictionary<ISalable, ItemStockInformation> local_stock)
	{
	}
}
