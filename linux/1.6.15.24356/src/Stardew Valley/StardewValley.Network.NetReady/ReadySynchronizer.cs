using System.Collections.Generic;
using StardewValley.Network.NetReady.Internal;

namespace StardewValley.Network.NetReady;

public class ReadySynchronizer
{
	private readonly Dictionary<string, BaseReadyCheck> ReadyChecks = new Dictionary<string, BaseReadyCheck>();

	public void SetLocalRequiredFarmers(string id, List<Farmer> requiredFarmers)
	{
		List<long> list = new List<long>();
		foreach (Farmer requiredFarmer in requiredFarmers)
		{
			list.Add(requiredFarmer.UniqueMultiplayerID);
		}
		GetOrCreate(id).SetRequiredFarmers(list);
	}

	public void SetLocalReady(string id, bool ready)
	{
		GetOrCreate(id).SetLocalReady(ready);
	}

	public bool IsReady(string id)
	{
		return GetIfExists(id)?.IsReady ?? false;
	}

	public bool IsReadyCheckCancelable(string id)
	{
		return GetIfExists(id)?.IsCancelable ?? false;
	}

	public int GetNumberReady(string id)
	{
		return GetIfExists(id)?.NumberReady ?? 0;
	}

	public int GetNumberRequired(string id)
	{
		return GetIfExists(id)?.NumberRequired ?? 0;
	}

	public void Update()
	{
		foreach (BaseReadyCheck value in ReadyChecks.Values)
		{
			value.Update();
		}
	}

	public void Reset()
	{
		ReadyChecks.Clear();
	}

	public void ProcessMessage(IncomingMessage message)
	{
		string id = message.Reader.ReadString();
		ReadyCheckMessageType messageType = (ReadyCheckMessageType)message.Reader.ReadByte();
		GetOrCreate(id).ProcessMessage(messageType, message);
	}

	private BaseReadyCheck GetIfExists(string id)
	{
		if (id == null || !ReadyChecks.TryGetValue(id, out var value))
		{
			return null;
		}
		return value;
	}

	private BaseReadyCheck GetOrCreate(string id)
	{
		if (ReadyChecks.TryGetValue(id, out var value))
		{
			return value;
		}
		value = (Game1.IsMasterGame ? ((BaseReadyCheck)new ServerReadyCheck(id)) : ((BaseReadyCheck)new ClientReadyCheck(id)));
		ReadyChecks.Add(id, value);
		return value;
	}
}
