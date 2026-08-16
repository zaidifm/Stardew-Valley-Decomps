using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.TerrainFeatures;

[XmlInclude(typeof(Bush))]
public abstract class LargeTerrainFeature : TerrainFeature
{
	[XmlElement("tilePosition")]
	public readonly NetVector2 netTilePosition;

	public bool isDestroyedByNPCTrample;

	[XmlIgnore]
	public override Vector2 Tile
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
	protected LargeTerrainFeature(bool needsTick)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroy()
	{
	}
}
