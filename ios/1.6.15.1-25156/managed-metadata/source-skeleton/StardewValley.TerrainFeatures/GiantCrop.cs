using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.GameData.GiantCrops;

namespace StardewValley.TerrainFeatures;

public class GiantCrop : ResourceClump
{
	private static readonly Dictionary<string, List<KeyValuePair<string, GiantCropData>>> CacheByCropId;

	private static int CacheTick;

	[XmlElement("id")]
	public readonly NetString netId;

	[XmlIgnore]
	public string Id
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiantCrop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiantCrop(string id, Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t, int damage, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiantCropData GetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(string id, out GiantCropData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IReadOnlyList<KeyValuePair<string, GiantCropData>> GetGiantCropsFor(string cropId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool RebuildCropIdCacheIfNeeded(bool forceRebuild = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item TryGetDrop(GiantCropHarvestItemData drop, Random r, Farmer targetFarmer, bool isShaving, float healthDeducted)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AdjustStackSizeWhenShaving(Item item, int? min, int? max, float healthDeducted, Random random)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetIdFromLegacySpriteIndex(int spriteIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
