using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Characters;

namespace StardewValley.Buildings;

public class PetBowl : Building
{
	[XmlElement("watered")]
	public readonly NetBool watered;

	private int nameTimer;

	private string nameTimerMessage;

	[XmlElement("petGuid")]
	public readonly NetGuid petId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PetBowl(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PetBowl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AssignPet(Pet pet)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point GetPetSpot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool doAction(Vector2 tileLocation, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performToolAction(Tool t, int tileX, int tileY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasPet()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
