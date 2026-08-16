using System;
using System.IO;
using StardewValley.Extensions;

namespace StardewValley.Network.NetEvents;

public sealed class SetMailRequest : BaseSetFlagRequest
{
	public MailType MailType { get; private set; } = MailType.Tomorrow;

	public SetMailRequest()
	{
	}

	public SetMailRequest(PlayerActionTarget target, string mailId, MailType mailType, bool state, long? onlyPlayerId = null)
		: base(target, mailId, state, onlyPlayerId)
	{
		MailType = mailType;
	}

	public override void PerformAction(Farmer farmer)
	{
		switch (MailType)
		{
		case MailType.Now:
			ToggleMailbox(farmer, base.FlagId, base.FlagState);
			break;
		case MailType.Tomorrow:
			farmer.mailForTomorrow.Toggle(base.FlagId, base.FlagState);
			break;
		case MailType.Received:
			farmer.mailReceived.Toggle(base.FlagId, base.FlagState);
			break;
		case MailType.All:
			ToggleMailbox(farmer, base.FlagId, base.FlagState);
			farmer.mailForTomorrow.Toggle(base.FlagId, base.FlagState);
			farmer.mailReceived.Toggle(base.FlagId, base.FlagState);
			break;
		default:
			Game1.log.Warn($"Received request to add mail ID '{base.FlagId}' with unknown mail type '{MailType}'");
			break;
		}
	}

	public override void Read(BinaryReader reader)
	{
		base.Read(reader);
		MailType = (MailType)Enum.ToObject(typeof(MailType), reader.ReadByte());
	}

	public override void Write(BinaryWriter writer)
	{
		base.Write(writer);
		writer.Write((byte)MailType);
	}

	private void ToggleMailbox(Farmer farmer, string mailId, bool add)
	{
		if (add)
		{
			farmer.mailbox.Add(mailId);
			return;
		}
		farmer.mailbox.RemoveWhere((string p) => p == mailId);
	}
}
