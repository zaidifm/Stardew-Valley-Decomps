using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Mods;

namespace StardewValley.TerrainFeatures;

[XmlInclude(typeof(Flooring))]
[XmlInclude(typeof(FruitTree))]
[XmlInclude(typeof(Grass))]
[XmlInclude(typeof(HoeDirt))]
[XmlInclude(typeof(LargeTerrainFeature))]
[XmlInclude(typeof(ResourceClump))]
[XmlInclude(typeof(Tree))]
public abstract class TerrainFeature : INetObject<NetFields>, IHaveModData
{
	[XmlIgnore]
	public readonly bool NeedsTick;

	[XmlIgnore]
	public bool isTemporarilyInvisible;

	[XmlIgnore]
	protected bool _needsUpdate = true;

	[XmlIgnore]
	public virtual GameLocation Location { get; set; }

	[XmlIgnore]
	public virtual Vector2 Tile { get; set; }

	[XmlIgnore]
	public ModDataDictionary modData { get; } = new ModDataDictionary();

	[XmlElement("modData")]
	public ModDataDictionary modDataForSerialization
	{
		get
		{
			return modData.GetForSerialization();
		}
		set
		{
			modData.SetFromSerialization(value);
		}
	}

	[XmlIgnore]
	public bool NeedsUpdate
	{
		get
		{
			return _needsUpdate;
		}
		set
		{
			if (value != _needsUpdate)
			{
				_needsUpdate = value;
				Location?.UpdateTerrainFeatureUpdateSubscription(this);
			}
		}
	}

	public NetFields NetFields { get; }

	protected TerrainFeature(bool needsTick)
	{
		NetFields = new NetFields(NetFields.GetNameForInstance(this));
		NeedsTick = needsTick;
		initNetFields();
	}

	public virtual void initNetFields()
	{
		NetFields.SetOwner(this).AddField(modData, "modData");
	}

	public virtual Rectangle getBoundingBox()
	{
		Vector2 tile = Tile;
		return new Rectangle((int)tile.X * 64, (int)tile.Y * 64, 64, 64);
	}

	public virtual Rectangle getRenderBounds()
	{
		return getBoundingBox();
	}

	public virtual void loadSprite()
	{
	}

	public virtual bool isPassable(Character c = null)
	{
		return isTemporarilyInvisible;
	}

	public virtual void OnAddedToLocation(GameLocation location, Vector2 tile)
	{
		Location = location;
		Tile = tile;
	}

	public virtual void doCollisionAction(Rectangle positionOfCollider, int speedOfCollision, Vector2 tileLocation, Character who)
	{
	}

	public virtual bool performUseAction(Vector2 tileLocation)
	{
		return false;
	}

	public virtual bool performToolAction(Tool t, int damage, Vector2 tileLocation)
	{
		return false;
	}

	public virtual bool tickUpdate(GameTime time)
	{
		return false;
	}

	public virtual void dayUpdate()
	{
	}

	public virtual bool seasonUpdate(bool onLoad)
	{
		return false;
	}

	public virtual bool isActionable()
	{
		return false;
	}

	public virtual void performPlayerEntryAction()
	{
		isTemporarilyInvisible = false;
	}

	public virtual void draw(SpriteBatch spriteBatch)
	{
	}

	public virtual bool forceDraw()
	{
		return false;
	}

	public virtual void drawInMenu(SpriteBatch spriteBatch, Vector2 positionOnScreen, Vector2 tileLocation, float scale, float layerDepth)
	{
	}
}
