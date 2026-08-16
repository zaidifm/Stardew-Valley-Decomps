using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley;

public class MovieViewerLockEvent : NetEventArg
{
	public List<long> uids;

	public int movieStartTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MovieViewerLockEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MovieViewerLockEvent(List<Farmer> present_farmers, int movie_start_time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(BinaryWriter writer)
	{
	}
}
