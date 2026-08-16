using System.Runtime.CompilerServices;

namespace StardewValley.ConsoleAsync;

public interface IAsyncOperation
{
	bool Started
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool Done
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Begin();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Conclude();
}
