using System.IO;
using Netcode;

namespace StardewValley.Network.NetEvents;

public abstract class BasePlayerActionRequest : NetEventArg
{
	public PlayerActionTarget Target { get; private set; }

	public long? OnlyPlayerId { get; private set; }

	public virtual void Read(BinaryReader reader)
	{
		Target = (PlayerActionTarget)reader.ReadByte();
		OnlyPlayerId = (reader.ReadBoolean() ? new long?(reader.ReadInt64()) : ((long?)null));
	}

	public virtual void Write(BinaryWriter writer)
	{
		writer.Write((byte)Target);
		writer.Write(OnlyPlayerId.HasValue);
		if (OnlyPlayerId.HasValue)
		{
			writer.Write(OnlyPlayerId.Value);
		}
	}

	public bool MatchesPlayer(Farmer player)
	{
		if (OnlyPlayerId.HasValue && player.UniqueMultiplayerID != OnlyPlayerId.Value)
		{
			return false;
		}
		switch (Target)
		{
		case PlayerActionTarget.Current:
			return true;
		case PlayerActionTarget.Host:
			return Game1.IsMasterGame;
		case PlayerActionTarget.All:
			return true;
		default:
			Game1.log.Warn($"Can't process net request {GetType().AssemblyQualifiedName}: Invalid target '{Target}'");
			return false;
		}
	}

	public bool OnlyForLocalPlayer()
	{
		if (OnlyPlayerId.HasValue)
		{
			return MatchesPlayer(Game1.player);
		}
		switch (Target)
		{
		case PlayerActionTarget.Current:
			return true;
		case PlayerActionTarget.Host:
			return Game1.IsMasterGame;
		case PlayerActionTarget.All:
			if (Game1.IsMasterGame)
			{
				return Game1.netWorldState.Value.farmhandData.Length == 0;
			}
			return false;
		default:
			Game1.log.Warn($"Can't process net request {GetType().AssemblyQualifiedName}: Invalid target '{Target}'");
			return false;
		}
	}

	public abstract void PerformAction(Farmer farmer);

	protected BasePlayerActionRequest()
		: this(PlayerActionTarget.Current, null)
	{
	}

	protected BasePlayerActionRequest(PlayerActionTarget target, long? onlyPlayerId)
	{
		Target = target;
		OnlyPlayerId = onlyPlayerId;
	}
}
