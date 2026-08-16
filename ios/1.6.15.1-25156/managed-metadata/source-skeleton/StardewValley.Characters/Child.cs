using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;
using StardewValley.Objects;
using xTile.Dimensions;

namespace StardewValley.Characters;

public class Child : NPC
{
	public const int newborn = 0;

	public const int baby = 1;

	public const int crawler = 2;

	public const int toddler = 3;

	[XmlElement("daysOld")]
	public readonly NetInt daysOld;

	[XmlElement("idOfParent")]
	public NetLong idOfParent;

	[XmlElement("darkSkinned")]
	public readonly NetBool darkSkinned;

	private readonly NetEvent1Field<int, NetInt> setStateEvent;

	[XmlElement("hat")]
	public readonly NetRef<Hat> hat;

	[XmlIgnore]
	public readonly NetMutex mutex;

	private int previousState;

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
	public Child()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Child(string name, bool isMale, bool isDarkSkinned, Farmer parent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChooseAppearance(LocalizedContentManager content = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void updateSlaveAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MovePosition(GameTime time, xTile.Dimensions.Rectangle viewport, GameLocation currentLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canPassThroughActionTiles()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void resetForNewDay(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string translateName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void dayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isInCrib()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool hasDarkSkin()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void toss(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void performToss(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doneTossing(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Microsoft.Xna.Framework.Rectangle getMugShotSourceRect()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setState(int state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doSetState(int state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setCrawlerInNewDirection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool hasSpecialCollisionRules()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isColliding(GameLocation l, Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void tenMinuteUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetChildIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void toddlerReachedDestination(Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canTalk()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Farmer who, GameLocation l)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<FarmerSprite.AnimationFrame> getRandomCrawlerAnimation(int which = -1)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<FarmerSprite.AnimationFrame> getRandomNewbornAnimation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<FarmerSprite.AnimationFrame> getRandomBabyAnimation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetForPlayerEntry(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void behaviorOnLocalFarmerLocationEntry(GameLocation location)
	{
	}
}
