using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.TerrainFeatures;

[XmlInclude(typeof(Bush))]
public abstract class LargeTerrainFeature : TerrainFeature
{
	[XmlElement("tilePosition")]
	public readonly NetVector2 netTilePosition = new NetVector2();

	public bool isDestroyedByNPCTrample;

	[XmlIgnore]
	public override Vector2 Tile
	{
		get
		{
			return netTilePosition.Value;
		}
		set
		{
			netTilePosition.Value = value;
		}
	}

	protected LargeTerrainFeature(bool needsTick)
		: base(needsTick)
	{
	}

	public override void initNetFields()
	{
		base.initNetFields();
		base.NetFields.AddField(netTilePosition, "netTilePosition");
	}

	public virtual void onDestroy()
	{
	}
}
