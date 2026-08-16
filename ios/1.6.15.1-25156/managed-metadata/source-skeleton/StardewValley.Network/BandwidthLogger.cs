using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public class BandwidthLogger
{
	private long bitsDownSinceLastUpdate;

	private long bitsUpSinceLastUpdate;

	private DateTime lastUpdateTime;

	private double lastBitsDownPerSecond;

	private double lastBitsUpPerSecond;

	private double avgBitsUpPerSecond;

	private long bitsUpPerSecondCount;

	private double avgBitsDownPerSecond;

	private long bitsDownPerSecondCount;

	private long totalBitsDown;

	private long totalBitsUp;

	private double totalMs;

	private int queueCapacity;

	private Queue<double> bitsUp;

	private Queue<double> bitsDown;

	public double AvgBitsDownPerSecond
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public double AvgBitsUpPerSecond
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public double BitsDownPerSecond
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public double BitsUpPerSecond
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public double TotalBitsDown
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public double TotalBitsUp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public double TotalMs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Queue<double> LoggedAvgBitsUp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Queue<double> LoggedAvgBitsDown
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecordBytesDown(long bytes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecordBytesUp(long bytes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BandwidthLogger()
	{
	}
}
