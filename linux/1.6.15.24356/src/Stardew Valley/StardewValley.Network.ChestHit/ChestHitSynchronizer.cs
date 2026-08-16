using System.Collections.Generic;
using StardewValley.Network.ChestHit.Internal;
using StardewValley.Objects;

namespace StardewValley.Network.ChestHit;

public sealed class ChestHitSynchronizer
{
	private readonly Queue<ChestHitArgs> EventQueue = new Queue<ChestHitArgs>();

	internal readonly Dictionary<string, Dictionary<ulong, ChestHitTimer>> SavedTimers = new Dictionary<string, Dictionary<ulong, ChestHitTimer>>();

	public void Reset()
	{
		EventQueue.Clear();
		SavedTimers.Clear();
	}

	public void Update()
	{
		if (!Game1.IsMasterGame)
		{
			return;
		}
		while (EventQueue.Count > 0)
		{
			ChestHitArgs chestHitArgs = EventQueue.Dequeue();
			if (chestHitArgs != null)
			{
				if (chestHitArgs.Location?.getObjectAtTile(chestHitArgs.ChestTile.X, chestHitArgs.ChestTile.Y, ignorePassables: true) is Chest chest)
				{
					chest.HandleChestHit(chestHitArgs);
				}
				continue;
			}
			break;
		}
	}

	public void Sync(ChestHitArgs args)
	{
		if (!(args.Location?.getObjectAtTile(args.ChestTile.X, args.ChestTile.Y, ignorePassables: true) is Chest chest))
		{
			return;
		}
		if (Game1.IsMasterGame)
		{
			EventQueue.Enqueue(args);
			return;
		}
		if (chest.hitTimerInstance != null)
		{
			chest.hitTimerInstance.SavedTime = (int)(Game1.currentGameTime?.TotalGameTime.TotalMilliseconds ?? (-999.0));
			if (!SavedTimers.TryGetValue(args.Location.NameOrUniqueName, out var value))
			{
				value = new Dictionary<ulong, ChestHitTimer>();
				SavedTimers.Add(args.Location.NameOrUniqueName, value);
			}
			value[HashPosition(args.ChestTile.X, args.ChestTile.Y)] = chest.hitTimerInstance;
		}
		Game1.client?.sendMessage(new OutgoingMessage(32, Game1.player, (byte)0, args.Location.isStructure.Value, args.Location.NameOrUniqueName, args.ChestTile.X, args.ChestTile.Y, args.ToolPosition, args.StandingPixel.X, args.StandingPixel.Y, args.Direction, args.HoldDownClick, args.ToolCanHit, args.RecentlyHit));
	}

	public void SignalMove(GameLocation location, int sourceTileX, int sourceTileY, int destTileX, int destTileY)
	{
		if (Game1.server == null || location == null)
		{
			return;
		}
		foreach (Farmer value in Game1.otherFarmers.Values)
		{
			Game1.server.sendMessage(value.UniqueMultiplayerID, new OutgoingMessage(32, Game1.player, (byte)1, location.NameOrUniqueName, sourceTileX, sourceTileY, destTileX, destTileY));
		}
	}

	public void SignalDelete(GameLocation location, int tileX, int tileY)
	{
		if (Game1.server == null || location == null)
		{
			return;
		}
		foreach (Farmer value in Game1.otherFarmers.Values)
		{
			Game1.server.sendMessage(value.UniqueMultiplayerID, new OutgoingMessage(32, Game1.player, (byte)2, location.NameOrUniqueName, tileX, tileY));
		}
	}

	public void ProcessMessage(IncomingMessage message)
	{
		switch ((ChestHitMessageType)message.Reader.ReadByte())
		{
		case ChestHitMessageType.Sync:
			ProcessSync(message);
			break;
		case ChestHitMessageType.Move:
			ProcessMove(message);
			break;
		case ChestHitMessageType.Delete:
			ProcessDelete(message);
			break;
		}
	}

	internal static ulong HashPosition(int x, int y)
	{
		return ((ulong)(uint)x << 32) | (uint)y;
	}

	private static GameLocation ReadLocation(IncomingMessage message)
	{
		bool isStructure = message.Reader.ReadBoolean();
		GameLocation locationFromName = Game1.getLocationFromName(message.Reader.ReadString(), isStructure);
		if (locationFromName == null || (object)Game1.multiplayer.locationRoot(locationFromName) == null)
		{
			return null;
		}
		return locationFromName;
	}

	private void ProcessSync(IncomingMessage message)
	{
		if (!Game1.IsMasterGame)
		{
			Game1.log.Warn("Unexpectedly received a chest hit sync message as a farmhand.");
			return;
		}
		ChestHitArgs chestHitArgs = new ChestHitArgs();
		bool isStructure = message.Reader.ReadBoolean();
		string name = message.Reader.ReadString();
		chestHitArgs.Location = Game1.getLocationFromName(name, isStructure);
		if (chestHitArgs.Location != null && (object)Game1.multiplayer.locationRoot(chestHitArgs.Location) != null)
		{
			chestHitArgs.ChestTile.X = message.Reader.ReadInt32();
			chestHitArgs.ChestTile.Y = message.Reader.ReadInt32();
			chestHitArgs.ToolPosition.X = message.Reader.ReadSingle();
			chestHitArgs.ToolPosition.Y = message.Reader.ReadSingle();
			chestHitArgs.StandingPixel.X = message.Reader.ReadInt32();
			chestHitArgs.StandingPixel.Y = message.Reader.ReadInt32();
			chestHitArgs.Direction = message.Reader.ReadInt32();
			chestHitArgs.HoldDownClick = message.Reader.ReadBoolean();
			chestHitArgs.ToolCanHit = message.Reader.ReadBoolean();
			chestHitArgs.RecentlyHit = message.Reader.ReadBoolean();
			EventQueue.Enqueue(chestHitArgs);
		}
	}

	private void ProcessMove(IncomingMessage message)
	{
		if (Game1.IsMasterGame)
		{
			Game1.log.Warn("Unexpectedly received a chest move message as the host.");
			return;
		}
		string text = message.Reader.ReadString();
		if (text == null)
		{
			return;
		}
		int x = message.Reader.ReadInt32();
		int y = message.Reader.ReadInt32();
		int x2 = message.Reader.ReadInt32();
		int y2 = message.Reader.ReadInt32();
		if (SavedTimers.TryGetValue(text, out var value))
		{
			ulong key = HashPosition(x, y);
			if (value.TryGetValue(key, out var value2))
			{
				value.Remove(key);
				value.TryAdd(HashPosition(x2, y2), value2);
			}
		}
	}

	private void ProcessDelete(IncomingMessage message)
	{
		if (Game1.IsMasterGame)
		{
			Game1.log.Warn("Unexpectedly received a chest delete message as the host.");
			return;
		}
		string text = message.Reader.ReadString();
		if (text != null)
		{
			int x = message.Reader.ReadInt32();
			int y = message.Reader.ReadInt32();
			if (SavedTimers.TryGetValue(text, out var value))
			{
				value.Remove(HashPosition(x, y));
			}
		}
	}
}
