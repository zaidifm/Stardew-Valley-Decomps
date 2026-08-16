using System.Collections.Generic;

namespace StardewValley.Network.NetReady.Internal;

internal sealed class ClientReadyCheck : BaseReadyCheck
{
	public ClientReadyCheck(string id)
		: base(id)
	{
	}

	public override void SetRequiredFarmers(List<long> farmerIds)
	{
		if (farmerIds == null)
		{
			int num = 0;
			foreach (Farmer onlineFarmer in Game1.getOnlineFarmers())
			{
				if (!Game1.multiplayer.isDisconnecting(onlineFarmer) && !onlineFarmer.IsDedicatedPlayer)
				{
					num++;
				}
			}
			base.NumberRequired = num;
			SendMessage(ReadyCheckMessageType.RequireFarmers, -1);
		}
		else
		{
			base.NumberRequired = farmerIds.Count;
			object[] array = new object[farmerIds.Count + 1];
			array[0] = farmerIds.Count;
			for (int i = 0; i < farmerIds.Count; i++)
			{
				array[i + 1] = farmerIds[i];
			}
			SendMessage(ReadyCheckMessageType.RequireFarmers, array);
		}
	}

	public override bool SetLocalReady(bool ready)
	{
		if (!base.SetLocalReady(ready))
		{
			return false;
		}
		base.NumberReady++;
		SendMessage((!ready) ? ReadyCheckMessageType.Cancel : ReadyCheckMessageType.Ready);
		return true;
	}

	public override void Update()
	{
	}

	public override void ProcessMessage(ReadyCheckMessageType messageType, IncomingMessage message)
	{
		switch (messageType)
		{
		case ReadyCheckMessageType.Lock:
			ProcessLock(message);
			return;
		case ReadyCheckMessageType.Release:
			ProcessRelease(message);
			return;
		case ReadyCheckMessageType.UpdateAmounts:
			ProcessUpdateAmounts(message);
			return;
		case ReadyCheckMessageType.Finish:
			ProcessFinish(message);
			return;
		}
		Game1.log.Warn($"{"ClientReadyCheck"} '{base.Id}' received invalid message type '{messageType}'.");
	}

	protected override void SendMessage(ReadyCheckMessageType messageType, params object[] data)
	{
		Game1.client?.sendMessage(CreateSyncMessage(messageType, data));
	}

	private void ProcessLock(IncomingMessage message)
	{
		base.ActiveLockId = message.Reader.ReadInt32();
		if (base.State == ReadyState.NotReady)
		{
			SendMessage(ReadyCheckMessageType.RejectLock, base.ActiveLockId);
		}
		else
		{
			base.State = ReadyState.Locked;
			SendMessage(ReadyCheckMessageType.AcceptLock, base.ActiveLockId);
		}
	}

	private void ProcessRelease(IncomingMessage message)
	{
		int num = message.Reader.ReadInt32();
		if (base.State == ReadyState.Locked && num == base.ActiveLockId)
		{
			base.State = ReadyState.Ready;
		}
	}

	private void ProcessUpdateAmounts(IncomingMessage message)
	{
		base.NumberReady = message.Reader.ReadInt32();
		base.NumberRequired = message.Reader.ReadInt32();
	}

	private void ProcessFinish(IncomingMessage message)
	{
		base.IsReady = true;
	}
}
