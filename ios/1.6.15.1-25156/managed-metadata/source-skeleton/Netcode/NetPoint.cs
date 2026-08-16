using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace Netcode;

public sealed class NetPoint : NetField<Point, NetPoint>
{
	public int X
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

	public int Y
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
	public NetPoint()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetPoint(Point value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(Point newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Point interpolate(Point startValue, Point endValue, float factor)
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
