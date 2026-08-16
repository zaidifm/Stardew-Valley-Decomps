using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace StardewValley.ConsoleAsync;

public abstract class AsyncTaskOperation : IAsyncOperation
{
	public Task Task;

	public bool TaskStarted;

	bool IAsyncOperation.Started
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public abstract bool Done
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void IAsyncOperation.Begin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void Conclude();

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AsyncTaskOperation()
	{
	}
}
