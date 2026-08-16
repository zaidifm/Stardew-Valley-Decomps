using System.Runtime.CompilerServices;
using Lidgren.Network;

namespace StardewValley.Network;

public static class LidgrenMessageUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteMessage(OutgoingMessage srcMsg, NetOutgoingMessage destMsg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadStreamToMessage(NetBufferReadStream stream, IncomingMessage msg)
	{
	}
}
