using System.IO;
using Lidgren.Network;

namespace StardewValley.Network;

public static class LidgrenMessageUtils
{
	internal static void WriteMessage(OutgoingMessage srcMsg, NetOutgoingMessage destMsg)
	{
		byte[] data;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using BinaryWriter writer = new BinaryWriter(memoryStream);
			srcMsg.Write(writer);
			data = memoryStream.ToArray();
		}
		using MemoryStream memoryStream2 = new MemoryStream(Program.netCompression.CompressAbove(data, 1024));
		using NetBufferWriteStream destination = new NetBufferWriteStream(destMsg);
		memoryStream2.CopyTo(destination);
	}

	internal static void ReadStreamToMessage(NetBufferReadStream stream, IncomingMessage msg)
	{
		Stream input = stream;
		if (Program.netCompression.TryDecompressStream(stream, out var decompressed))
		{
			input = new MemoryStream(decompressed);
		}
		using BinaryReader reader = new BinaryReader(input);
		msg.Read(reader);
	}
}
