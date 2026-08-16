using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxySpecificUserDataListener : ISpecificUserDataListener
{
	private readonly Action<GalaxyID> Callback;

	public GalaxySpecificUserDataListener(Action<GalaxyID> callback)
	{
		Callback = callback;
		GalaxyInstance.ListenerRegistrar().Register(GalaxyTypeAwareListenerSpecificUserData.GetListenerType(), this);
	}

	public override void OnSpecificUserDataUpdated(GalaxyID userID)
	{
		Callback?.Invoke(userID);
	}

	public override void Dispose()
	{
		GalaxyInstance.ListenerRegistrar().Unregister(GalaxyTypeAwareListenerSpecificUserData.GetListenerType(), this);
		base.Dispose();
	}
}
