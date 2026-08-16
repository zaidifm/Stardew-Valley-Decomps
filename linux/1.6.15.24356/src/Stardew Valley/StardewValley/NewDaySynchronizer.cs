using System.Threading;
using Netcode;
using StardewValley.Network;

namespace StardewValley;

public class NewDaySynchronizer : NetSynchronizer
{
	private bool ServerReady;

	private bool Instantiated;

	public NewDaySynchronizer()
	{
		ServerReady = false;
		Instantiated = false;
	}

	public bool hasInstance()
	{
		return Instantiated;
	}

	public void create()
	{
		Instantiated = true;
	}

	public void destroy()
	{
		Instantiated = false;
		ServerReady = false;
		reset();
	}

	public void flagServerReady()
	{
		if (!Game1.IsMasterGame)
		{
			ServerReady = true;
		}
	}

	public void start()
	{
		Game1.multiplayer.UpdateEarly();
		if (Game1.IsMasterGame)
		{
			ServerReady = true;
			{
				foreach (Farmer value in Game1.otherFarmers.Values)
				{
					Game1.server.sendMessage(value.UniqueMultiplayerID, new OutgoingMessage(30, Game1.player));
				}
				return;
			}
		}
		while (!ServerReady)
		{
			processMessages();
			if (shouldAbort())
			{
				ServerReady = false;
				throw new AbortNetSynchronizerException();
			}
			if (LocalMultiplayer.IsLocalMultiplayer())
			{
				break;
			}
		}
	}

	public bool hasStarted()
	{
		if (ServerReady)
		{
			return true;
		}
		processMessages();
		return false;
	}

	public bool readyForFinish()
	{
		Game1.netReady.SetLocalReady("wakeup", ready: true);
		Game1.player.team.Update();
		Game1.multiplayer.UpdateLate();
		Game1.multiplayer.UpdateEarly();
		return Game1.netReady.IsReady("wakeup");
	}

	public bool readyForSave()
	{
		Game1.netReady.SetLocalReady("ready_for_save", ready: true);
		Game1.player.team.Update();
		Game1.multiplayer.UpdateLate();
		Game1.multiplayer.UpdateEarly();
		return Game1.netReady.IsReady("ready_for_save");
	}

	public int numReadyForSave()
	{
		return Game1.netReady.GetNumberReady("ready_for_save");
	}

	public void finish()
	{
		if (Game1.IsServer)
		{
			sendVar<NetBool, bool>("finished", value: true);
		}
		Game1.multiplayer.UpdateLate();
	}

	public bool hasFinished()
	{
		return hasVar("finished");
	}

	public void flagSaved()
	{
		if (Game1.IsServer)
		{
			sendVar<NetBool, bool>("saved", value: true);
		}
		Game1.multiplayer.UpdateLate();
	}

	public bool hasSaved()
	{
		return hasVar("saved");
	}

	public override void processMessages()
	{
		Game1.multiplayer.UpdateLate();
		Thread.Sleep(16);
		Program.sdk.Update();
		Game1.multiplayer.UpdateEarly();
	}

	protected override void sendMessage(params object[] data)
	{
		OutgoingMessage message = new OutgoingMessage(14, Game1.player, data);
		if (Game1.IsServer)
		{
			foreach (Farmer value in Game1.otherFarmers.Values)
			{
				Game1.server.sendMessage(value.UniqueMultiplayerID, message);
			}
			return;
		}
		if (Game1.IsClient)
		{
			Game1.client.sendMessage(message);
		}
	}
}
