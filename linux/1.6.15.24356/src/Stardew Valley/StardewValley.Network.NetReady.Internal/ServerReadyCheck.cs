using System.Collections.Generic;

namespace StardewValley.Network.NetReady.Internal;

internal sealed class ServerReadyCheck : BaseReadyCheck
{
	private readonly Dictionary<long, ReadyState> ReadyStates = new Dictionary<long, ReadyState>();

	private bool Locking;

	private readonly HashSet<long> RequiredFarmers = new HashSet<long>();

	private bool IncludesAll => RequiredFarmers.Count == 0;

	public ServerReadyCheck(string id)
		: base(id)
	{
	}

	public override void SetRequiredFarmers(List<long> farmerIds)
	{
		RequireFarmers(farmerIds);
	}

	public override bool SetLocalReady(bool ready)
	{
		if (!base.SetLocalReady(ready))
		{
			return false;
		}
		if (!IsFarmerRequired(Game1.player.UniqueMultiplayerID))
		{
			base.State = ReadyState.NotReady;
			return false;
		}
		ReadyStates[Game1.player.UniqueMultiplayerID] = base.State;
		return true;
	}

	public override void Update()
	{
		if (base.IsReady)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		bool flag = IsFarmerRequired(Game1.player.UniqueMultiplayerID);
		foreach (Farmer onlineFarmer in Game1.getOnlineFarmers())
		{
			if (IsFarmerRequired(onlineFarmer.UniqueMultiplayerID) && !Game1.multiplayer.isDisconnecting(onlineFarmer))
			{
				if (!ReadyStates.TryGetValue(onlineFarmer.UniqueMultiplayerID, out var value))
				{
					value = ReadyState.NotReady;
					ReadyStates[onlineFarmer.UniqueMultiplayerID] = value;
				}
				num2++;
				switch (value)
				{
				case ReadyState.Ready:
					num++;
					break;
				case ReadyState.Locked:
					num++;
					num3++;
					break;
				}
			}
		}
		if (num != base.NumberReady || num2 != base.NumberRequired)
		{
			if (flag && Game1.IsDedicatedHost)
			{
				SendMessage(ReadyCheckMessageType.UpdateAmounts, num - ((base.State == ReadyState.Ready) ? 1 : 0), num2 - 1);
			}
			else
			{
				SendMessage(ReadyCheckMessageType.UpdateAmounts, num, num2);
			}
			if (num == num2)
			{
				if (!Locking)
				{
					base.ActiveLockId++;
					Locking = true;
					if (flag && base.State == ReadyState.Ready)
					{
						Dictionary<long, ReadyState> readyStates = ReadyStates;
						long uniqueMultiplayerID = Game1.player.UniqueMultiplayerID;
						ReadyState value2 = (base.State = ReadyState.Locked);
						readyStates[uniqueMultiplayerID] = value2;
						num3 = 1;
					}
					SendMessage(ReadyCheckMessageType.Lock, base.ActiveLockId);
				}
			}
			else if (Locking)
			{
				Locking = false;
				if (base.State == ReadyState.Locked)
				{
					base.State = ReadyState.Ready;
				}
				foreach (long key in ReadyStates.Keys)
				{
					if (ReadyStates[key] == ReadyState.Locked && IsFarmerRequired(key))
					{
						ReadyStates[key] = ReadyState.Ready;
					}
				}
				num3 = 0;
				SendMessage(ReadyCheckMessageType.Release, base.ActiveLockId);
			}
		}
		if (Locking && num3 == num2)
		{
			base.IsReady = true;
			SendMessage(ReadyCheckMessageType.Finish);
		}
		base.NumberReady = num;
		base.NumberRequired = num2;
	}

	public override void ProcessMessage(ReadyCheckMessageType messageType, IncomingMessage message)
	{
		switch (messageType)
		{
		case ReadyCheckMessageType.Ready:
			ProcessReady(message);
			return;
		case ReadyCheckMessageType.Cancel:
			ProcessCancel(message);
			return;
		case ReadyCheckMessageType.AcceptLock:
			ProcessAcceptLock(message);
			return;
		case ReadyCheckMessageType.RejectLock:
			ProcessRejectLock(message);
			return;
		case ReadyCheckMessageType.RequireFarmers:
			ProcessRequireFarmers(message);
			return;
		}
		Game1.log.Warn($"{"ServerReadyCheck"} '{base.Id}' received invalid message type '{messageType}'.");
	}

	protected override void SendMessage(ReadyCheckMessageType messageType, params object[] data)
	{
		if (Game1.server == null)
		{
			return;
		}
		foreach (Farmer value in Game1.otherFarmers.Values)
		{
			Game1.server.sendMessage(value.UniqueMultiplayerID, CreateSyncMessage(messageType, data));
		}
	}

	private void ProcessReady(IncomingMessage message)
	{
		if (!Locking)
		{
			ReadyStates[message.FarmerID] = ReadyState.Ready;
		}
	}

	private void ProcessCancel(IncomingMessage message)
	{
		if (!Locking)
		{
			ReadyStates[message.FarmerID] = ReadyState.NotReady;
		}
	}

	private void ProcessAcceptLock(IncomingMessage message)
	{
		if (message.Reader.ReadInt32() == base.ActiveLockId)
		{
			ReadyStates[message.FarmerID] = ReadyState.Locked;
		}
	}

	private void ProcessRejectLock(IncomingMessage message)
	{
		if (message.Reader.ReadInt32() == base.ActiveLockId)
		{
			ReadyStates[message.FarmerID] = ReadyState.NotReady;
		}
	}

	private void ProcessRequireFarmers(IncomingMessage message)
	{
		int num = message.Reader.ReadInt32();
		HashSet<long> hashSet = new HashSet<long>();
		for (int i = 0; i < num; i++)
		{
			hashSet.Add(message.Reader.ReadInt64());
		}
		RequireFarmers(hashSet);
	}

	private void RequireFarmers(ICollection<long> farmerIds)
	{
		RequiredFarmers.Clear();
		if (farmerIds == null)
		{
			return;
		}
		foreach (long farmerId in farmerIds)
		{
			RequiredFarmers.Add(farmerId);
		}
	}

	private bool IsFarmerRequired(long uid)
	{
		if (!IncludesAll)
		{
			return RequiredFarmers.Contains(uid);
		}
		return true;
	}
}
