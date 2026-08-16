using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;

namespace StardewValley.BellsAndWhistles;

public class Train : INetObject<NetFields>
{
	public const int minCars = 8;

	public const int maxCars = 24;

	public const double chanceForLongTrain = 0.1;

	public const int randomTrain = 0;

	public const int jojaTrain = 1;

	public const int coalTrain = 2;

	public const int passengerTrain = 3;

	public const int uniformColorPlainTrain = 4;

	public const int prisonTrain = 5;

	public const int christmasTrain = 6;

	public readonly NetObjectList<TrainCar> cars;

	public readonly NetInt type;

	public readonly NetPosition position;

	public float speed;

	public float wheelRotation;

	public float smokeTimer;

	private TemporaryAnimatedSprite whistleSteam;

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
	public Train()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle getBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Update(GameTime time, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b, GameLocation location)
	{
	}
}
