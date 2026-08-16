using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxyLobbyDataRetrieveListener : ILobbyDataRetrieveListener
{
	private readonly Action<GalaxyID> OnSuccess;

	private readonly Action<GalaxyID, FailureReason> OnFailure;

	public GalaxyLobbyDataRetrieveListener(Action<GalaxyID> success, Action<GalaxyID, FailureReason> failure)
	{
		OnSuccess = success;
		OnFailure = failure;
	}

	public override void OnLobbyDataRetrieveSuccess(GalaxyID lobbyID)
	{
		OnSuccess?.Invoke(lobbyID);
	}

	public override void OnLobbyDataRetrieveFailure(GalaxyID lobbyID, FailureReason failureReason)
	{
		OnFailure?.Invoke(lobbyID, failureReason);
	}
}
