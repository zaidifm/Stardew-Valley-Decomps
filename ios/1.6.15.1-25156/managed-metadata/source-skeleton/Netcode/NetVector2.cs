using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace Netcode;

public sealed class NetVector2 : NetField<Vector2, NetVector2>
{
	public bool AxisAlignedMovement;

	public float ExtrapolationSpeed;

	public float MinDeltaForDirectionChange;

	public float MaxInterpolationDistance;

	private bool interpolateXFirst;

	private bool isExtrapolating;

	private bool isFixingExtrapolation;

	public float X
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

	public float Y
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
	public NetVector2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetVector2(Vector2 value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(float x, float y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(Vector2 newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 InterpolationDelta()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool setUpInterpolation(Vector2 oldValue, Vector2 newValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 CurrentInterpolationDirection()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float CurrentInterpolationSpeed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Vector2 interpolate(Vector2 startValue, Vector2 endValue, float factor)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReadDelta(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteDelta(BinaryWriter writer)
	{
	}
}
