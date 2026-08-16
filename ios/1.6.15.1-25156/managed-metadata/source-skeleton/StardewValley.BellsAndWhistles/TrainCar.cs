using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.BellsAndWhistles;

public class TrainCar : INetObject<NetFields>
{
	public const int spotsForTopFeatures = 6;

	public const double chanceForTopFeature = 0.2;

	public const int engine = 3;

	public const int passengerCar = 2;

	public const int coalCar = 1;

	public const int plainCar = 0;

	public const int coal = 0;

	public const int metal = 1;

	public const int wood = 2;

	public const int compartments = 3;

	public const int grass = 4;

	public const int hay = 5;

	public const int bricks = 6;

	public const int rocks = 7;

	public const int packages = 8;

	public const int presents = 9;

	public readonly NetInt frontDecal;

	public readonly NetInt carType;

	public readonly NetInt resourceType;

	public readonly NetInt loaded;

	public readonly NetArray<int, NetInt> topFeatures;

	public readonly NetBool alternateCar;

	public readonly NetColor color;

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
	[Obsolete("This constructor is for deserialization and shouldn't be called directly.")]
	public TrainCar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrainCar(Random random, int carType, int frontDecal, Color color, int resourceType = 0, int loaded = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b, Vector2 globalPosition, float wheelRotation, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawFrontDecal(SpriteBatch b, Vector2 globalPosition)
	{
	}
}
