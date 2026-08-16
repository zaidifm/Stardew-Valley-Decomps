using System;
using System.Runtime.CompilerServices;

namespace StardewValley.ConsoleAsync;

public sealed class GenericOp : AsyncTaskOperation
{
	public Action DoneCallback;

	public override bool Done
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool Result
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Conclude()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GenericOp()
	{
	}
}
