using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public interface IBandwidthMonitor
{
	BandwidthLogger BandwidthLogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool LogBandwidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}
}
