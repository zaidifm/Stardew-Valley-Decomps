using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Characters;

public class TrashBear : NPC
{
	private int showWantBubbleTimer;

	[XmlIgnore]
	public string itemWantedIndex;

	[XmlIgnore]
	private readonly NetEvent0 cutsceneEvent;

	[XmlIgnore]
	private readonly NetEvent1Field<string, NetString> eatEvent;

	[XmlIgnore]
	private string itemBeingEaten;

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
	public TrashBear()
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
	public override bool checkAction(Farmer who, GameLocation l)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateItemWanted()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool tryToReceiveActiveObject(Farmer who, bool probe = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doEatEvent(string item_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void throwUpItem(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chew(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doneAnimating(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doCutsceneEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doCutscene()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
