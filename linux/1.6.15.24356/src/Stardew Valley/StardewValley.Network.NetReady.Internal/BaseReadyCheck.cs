using System;
using System.Collections.Generic;

namespace StardewValley.Network.NetReady.Internal;

internal abstract class BaseReadyCheck
{
	public string Id { get; }

	public int ActiveLockId { get; protected set; }

	public ReadyState State { get; protected set; }

	public int NumberReady { get; protected set; }

	public int NumberRequired { get; protected set; }

	public bool IsReady { get; protected set; }

	public bool IsCancelable => State != ReadyState.Locked;

	protected BaseReadyCheck(string id)
	{
		Id = id;
		State = ReadyState.NotReady;
		NumberReady = 0;
		NumberRequired = Game1.getOnlineFarmers().Count;
		IsReady = false;
	}

	public abstract void SetRequiredFarmers(List<long> farmerIds);

	public virtual bool SetLocalReady(bool ready)
	{
		if (!IsCancelable)
		{
			return false;
		}
		ReadyState state = State;
		State = (ready ? ReadyState.Ready : ReadyState.NotReady);
		return state != State;
	}

	public abstract void Update();

	public abstract void ProcessMessage(ReadyCheckMessageType messageType, IncomingMessage message);

	protected abstract void SendMessage(ReadyCheckMessageType messageType, params object[] data);

	protected OutgoingMessage CreateSyncMessage(ReadyCheckMessageType messageType, params object[] data)
	{
		object[] array = new object[data.Length + 2];
		array[0] = Id;
		array[1] = (byte)messageType;
		Array.Copy(data, 0, array, 2, data.Length);
		return new OutgoingMessage(31, Game1.player, array);
	}
}
