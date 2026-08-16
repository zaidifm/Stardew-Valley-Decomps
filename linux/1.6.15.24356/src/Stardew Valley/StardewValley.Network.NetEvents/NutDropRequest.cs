using System.IO;
using Microsoft.Xna.Framework;
using Netcode;

namespace StardewValley.Network.NetEvents;

public class NutDropRequest : NetEventArg
{
	public string Key { get; private set; }

	public string LocationName { get; private set; }

	public Point Tile { get; private set; }

	public int Limit { get; private set; } = 1;

	public int RewardAmount { get; private set; } = 1;

	public NutDropRequest()
	{
	}

	public NutDropRequest(string key, string locationName, Point tile, int limit, int rewardAmount)
	{
		Key = key;
		LocationName = locationName ?? "null";
		Tile = tile;
		Limit = limit;
		RewardAmount = rewardAmount;
	}

	public void Read(BinaryReader reader)
	{
		Key = reader.ReadString();
		LocationName = reader.ReadString();
		Tile = new Point(reader.ReadInt32(), reader.ReadInt32());
		Limit = reader.ReadInt32();
		RewardAmount = reader.ReadInt32();
	}

	public void Write(BinaryWriter writer)
	{
		writer.Write(Key);
		writer.Write(LocationName);
		writer.Write(Tile.X);
		writer.Write(Tile.Y);
		writer.Write(Limit);
		writer.Write(RewardAmount);
	}
}
