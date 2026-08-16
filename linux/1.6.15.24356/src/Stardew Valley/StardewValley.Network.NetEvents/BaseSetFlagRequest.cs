using System.IO;

namespace StardewValley.Network.NetEvents;

public abstract class BaseSetFlagRequest : BasePlayerActionRequest
{
	public string FlagId { get; private set; }

	public bool FlagState { get; private set; }

	public override void Read(BinaryReader reader)
	{
		base.Read(reader);
		FlagId = reader.ReadString();
		FlagState = reader.ReadBoolean();
	}

	public override void Write(BinaryWriter writer)
	{
		base.Write(writer);
		writer.Write(FlagId);
		writer.Write(FlagState);
	}

	protected BaseSetFlagRequest()
	{
	}

	protected BaseSetFlagRequest(PlayerActionTarget target, string flagId, bool flagState, long? onlyPlayerId)
		: base(target, onlyPlayerId)
	{
		FlagId = flagId;
		FlagState = flagState;
	}
}
