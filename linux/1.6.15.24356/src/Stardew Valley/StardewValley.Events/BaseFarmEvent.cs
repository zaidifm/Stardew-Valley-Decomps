using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Events;

public abstract class BaseFarmEvent : FarmEvent, INetObject<NetFields>
{
	public NetFields NetFields { get; private set; }

	protected BaseFarmEvent()
	{
		initNetFields();
	}

	public virtual void initNetFields()
	{
		NetFields = new NetFields(GetType().Name).SetOwner(this);
	}

	public virtual bool setUp()
	{
		return false;
	}

	public virtual bool tickUpdate(GameTime time)
	{
		return true;
	}

	public virtual void draw(SpriteBatch b)
	{
	}

	public virtual void drawAboveEverything(SpriteBatch b)
	{
	}

	public virtual void makeChangesToLocation()
	{
	}

	protected virtual string GenerateLightSourceId()
	{
		return GetType().Name;
	}
}
