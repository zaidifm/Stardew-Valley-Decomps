using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Buildings;
using StardewValley.Pathfinding;

namespace StardewValley.Characters;

public class JunimoHarvester : NPC
{
	protected float alpha;

	protected float alphaChange;

	protected Vector2 motion;

	protected new Rectangle nextPosition;

	protected readonly NetColor color;

	protected bool destroy;

	protected Item lastItemHarvested;

	public int whichJunimoFromThisHut;

	protected int harvestTimer;

	public readonly NetBool isPrismatic;

	protected readonly NetGuid netHome;

	protected readonly NetEvent1Field<int, NetInt> netAnimationEvent;

	public Guid HomeId
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

	[XmlIgnore]
	public JunimoHut home
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

	[XmlIgnore]
	public override bool IsVillager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JunimoHarvester()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JunimoHarvester(GameLocation location, Vector2 position, JunimoHut hut, int whichJunimoNumberFromThisHut, Color? c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void pickColor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChooseAppearance(LocalizedContentManager content = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void doAnimationEvent(int animId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void reachFirstDestinationFromHut(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void tryToHarvestHere()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void pokeToHarvest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldCollideWithBuildingLayer(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setMoving(int xSpeed, int ySpeed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setMoving(Vector2 motion)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Halt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canTalk()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void junimoReachedHut(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool foundCropEndFunction(PathNode currentNode, Point endPoint, GameLocation location, Character c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void pathfindToNewCrop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void returnToJunimoHut(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void faceDirection(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool isHarvestable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void pathfindToRandomSpotAroundHut()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void tryToAddItemToHut(Item i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b, float alpha = 1f)
	{
	}
}
